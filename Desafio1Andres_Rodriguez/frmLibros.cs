using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Desafio1Andres_Rodriguez
{
    public partial class frmLibros : Form
    {
        // Lista de libros accesible de forma segura por otros formularios
        public static List<Books> Libro { get; } = new List<Books>();

        private int nextId = 1;

        public frmLibros()
        {
            InitializeComponent();
        }

        private void frmLibros_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            RefrescarGrid();
            CargarLibros();
            LimpiarCampos();

            dtpYear.Format = DateTimePickerFormat.Custom;
            dtpYear.CustomFormat = "yyyy";
            dtpYear.ShowUpDown = true;
        }

        private void RefrescarGrid()
        {
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = DatosAlmacenados.Libros;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.ClearSelection();
        }

        private void ConfigurarDataGridView()
        {
            if (dgvBooks.Columns.Count > 0) return; // ya configurado

            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvBooks.Columns.Add("Id", "ID");
            dgvBooks.Columns.Add("Titulo", "Título");
            dgvBooks.Columns.Add("Autor", "Autor");
            dgvBooks.Columns.Add("Año", "Año");

            dgvBooks.Columns["Id"].DataPropertyName = "Id";
            dgvBooks.Columns["Titulo"].DataPropertyName = "Titulo";
            dgvBooks.Columns["Autor"].DataPropertyName = "Autor";
            dgvBooks.Columns["Año"].DataPropertyName = "Año";
        }

        private void CargarLibros()
        {
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = Libros;
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtTitulo.Text = "";
            txtAutor.Text = "";
            dtpYear.Value = DateTime.Now;
        }

        private bool ValidarLibro()
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("El título es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitulo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                MessageBox.Show("El autor es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAutor.Focus();
                return false;
            }

            int anio = dtpYear.Value.Year;
            if (anio < 1800 || anio > DateTime.Now.Year)
            {
                MessageBox.Show($"Ingrese un año válido entre 1800 y {DateTime.Now.Year}.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpYear.Focus();
                return false;
            }

            int idActual = string.IsNullOrWhiteSpace(txtId.Text) ? 0 : int.Parse(txtId.Text);
            if (DatosAlmacenados.Libros.Any(b => b.Titulo.Equals(txtTitulo.Text.Trim(), StringComparison.OrdinalIgnoreCase) && b.Id != idActual))
            {
                MessageBox.Show("Ya existe un libro con este título.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitulo.Focus();
                return false;
            }

            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            MessageBox.Show("Campos limpiados correctamente");
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!ValidarLibro()) return;

            Books nuevo = new Books
            {
                Id = DatosAlmacenados.Libros.Count + 1,
                Titulo = txtTitulo.Text.Trim(),
                Autor = txtAutor.Text.Trim(),
                Año = dtpYear.Value.Year
            };

            DatosAlmacenados.Libros.Add(nuevo);
            RefrescarGrid();
            LimpiarCampos();

            MessageBox.Show("Libro creado correctamente");
        }

        private void dgvBooks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Books libroSeleccionado = (Books)dgvBooks.Rows[e.RowIndex].DataBoundItem;
                txtId.Text = libroSeleccionado.Id.ToString();
                txtTitulo.Text = libroSeleccionado.Titulo;
                txtAutor.Text = libroSeleccionado.Autor;
                dtpYear.Value = new DateTime(libroSeleccionado.Año, 1, 1);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Seleccione un libro para editar");
                return;
            }

            if (!ValidarLibro()) return;

            int id = int.Parse(txtId.Text);
            Books libro = DatosAlmacenados.Libros.Find(l => l.Id == id);

            if (libro == null)
            {
                MessageBox.Show("Libro no encontrado");
                return;
            }

            libro.Titulo = txtTitulo.Text.Trim();
            libro.Autor = txtAutor.Text.Trim();
            libro.Año = dtpYear.Value.Year;

            RefrescarGrid();
            LimpiarCampos();
            MessageBox.Show("Libro actualizado correctamente");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Seleccione un libro para eliminar");
                return;
            }

            int id = int.Parse(txtId.Text);
            Books libro = DatosAlmacenados.Libros.Find(l => l.Id == id);

            if (libro != null)
            {
                DatosAlmacenados.Libros.Remove(libro);
                RefrescarGrid();
                LimpiarCampos();
                MessageBox.Show("Libro eliminado correctamente");
            }
            else
            {
                MessageBox.Show("Libro no encontrado");
            }
        }

        private void btnCambiarFormulario_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var formUsuarios = new frmUserAndBookLending())
            {
                formUsuarios.ShowDialog();
            }

            RefrescarGrid();
            this.Show();
        }

        private void frmLibros_Activated(object sender, EventArgs e)
        {
            RefrescarGrid();
        }

        private void frmLibros_Shown(object sender, EventArgs e)
        {
            RefrescarGrid();
            CargarGraficas();
        }

        private void CargarGraficas()
        {
            // ======= Libros más solicitados =======
            chartLibros.Series.Clear();
            chartLibros.ChartAreas.Clear();
            chartLibros.ChartAreas.Add(new ChartArea());

            // Agrupar por LibroID y obtener nombre + cantidad
            var librosMas = DatosAlmacenados.Lending
                .GroupBy(p => p.LibroID)
                .Select(g => new
                {
                    Libro = DatosAlmacenados.Libros.FirstOrDefault(b => b.Id == g.Key)?.Titulo ?? "Desconocido",
                    Cantidad = g.Count()
                })
                .OrderByDescending(x => x.Cantidad)
                .ToList();

            var nombresLibros = librosMas.Select(x => x.Libro).ToArray();
            var cantidadesLibros = librosMas.Select(x => x.Cantidad).ToArray();

            Series sLibros = new Series("Préstamos por Libro");
            sLibros.ChartType = SeriesChartType.Column; // barras verticales
            sLibros.Points.DataBindXY(nombresLibros, cantidadesLibros);
            chartLibros.Series.Add(sLibros);

            var areaLibros = chartLibros.ChartAreas[0];
            areaLibros.AxisX.Interval = 1;
            areaLibros.AxisX.LabelStyle.Angle = -45;
            areaLibros.AxisX.MajorGrid.Enabled = false;
            areaLibros.AxisX.LabelStyle.IsEndLabelVisible = true;
            areaLibros.AxisX.LabelStyle.TruncatedLabels = false;

            // ======= Usuarios con más préstamos =======
            chartUsuarios.Series.Clear();
            chartUsuarios.ChartAreas.Clear();
            chartUsuarios.ChartAreas.Add(new ChartArea());

            // Agrupar por UserID y obtener nombre + cantidad
            var usuariosMas = DatosAlmacenados.Lending
                .GroupBy(p => p.UserID)
                .Select(g => new
                {
                    Usuario = DatosAlmacenados.Usuarios.FirstOrDefault(u => u.ID == g.Key)?.Nombre ?? "Desconocido",
                    Cantidad = g.Count()
                })
                .OrderByDescending(x => x.Cantidad)
                .ToList();

            var nombresUsuarios = usuariosMas.Select(x => x.Usuario).ToArray();
            var cantidadesUsuarios = usuariosMas.Select(x => x.Cantidad).ToArray();

            Series sUsuarios = new Series("Préstamos por Usuario");
            sUsuarios.ChartType = SeriesChartType.Column; // barras verticales
            sUsuarios.Points.DataBindXY(nombresUsuarios, cantidadesUsuarios);
            chartUsuarios.Series.Add(sUsuarios);

            var areaUsuarios = chartUsuarios.ChartAreas[0];
            areaUsuarios.AxisX.Interval = 1;
            areaUsuarios.AxisX.LabelStyle.Angle = -45;
            areaUsuarios.AxisX.MajorGrid.Enabled = false;
            areaUsuarios.AxisX.LabelStyle.IsEndLabelVisible = true;
            areaUsuarios.AxisX.LabelStyle.TruncatedLabels = false;
        }
    }
}
