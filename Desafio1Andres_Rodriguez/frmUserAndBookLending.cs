using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1Andres_Rodriguez
{
    public partial class frmUserAndBookLending : Form
    {
        public static List<Users> listaUsers { get; } = new List<Users>();
        private int contadorID = 1;

        private List<Lending> listaLendings = new List<Lending>();
        private int contadorLending = 1;

        public frmUserAndBookLending()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtUserId.Clear();
            txtUserNombre.Clear();
            txtUserCorreo.Clear();
        }

        private void RefrescarGridUsers()
        {
            dgvCRUDUsers.DataSource = null;
            dgvCRUDUsers.DataSource = DatosAlmacenados.Usuarios;
            dgvCRUDUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCRUDUsers.ClearSelection();
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedIndex < 0) return;

            if (cmbFiltro.SelectedIndex == 0)
            {
                RefrescarGridLendings();
                return;
            }

            var usuario = (Users)cmbFiltro.SelectedItem;

            var filtrados = DatosAlmacenados.Lending
                .Where(p => p.UserID == usuario.ID)
                .Select(p => new
                {
                    p.ID,
                    Usuario = DatosAlmacenados.Usuarios.First(u => u.ID == p.UserID).Nombre,
                    Libro = DatosAlmacenados.Libros.First(l => l.Id == p.LibroID).Titulo,
                    p.FechaPrestamo,
                    p.FechaDevolucion
                })
                .ToList();

            dgvPrestamoLibros.DataSource = null;
            dgvPrestamoLibros.DataSource = filtrados;
            dgvPrestamoLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private bool ValidarUsuario()
        {
            if (string.IsNullOrWhiteSpace(txtUserNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUserCorreo.Text))
            {
                MessageBox.Show("El correo es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserCorreo.Focus();
                return false;
            }

            if (!txtUserCorreo.Text.Contains("@"))
            {
                MessageBox.Show("Ingrese un correo válido que contenga '@'.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserCorreo.Focus();
                return false;
            }

            int idActual = string.IsNullOrWhiteSpace(txtUserId.Text) ? 0 : int.Parse(txtUserId.Text);
            if (DatosAlmacenados.Usuarios.Any(u => u.Correo.Equals(txtUserCorreo.Text.Trim(), StringComparison.OrdinalIgnoreCase) && u.ID != idActual))
            {
                MessageBox.Show("Ya existe un usuario con este correo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserCorreo.Focus();
                return false;
            }

            return true;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (!ValidarUsuario())
                return;

            Users nuevo = new Users
            {
                ID = DatosAlmacenados.Usuarios.Count + 1,
                Nombre = txtUserNombre.Text.Trim(),
                Correo = txtUserCorreo.Text.Trim()
            };

            DatosAlmacenados.Usuarios.Add(nuevo);
            RefrescarGridUsers();
            CargarCombosPrestamo();
            LimpiarCampos();
            MessageBox.Show("Usuario agregado correctamente.", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvCRUDUsers.CurrentRow == null ||
                string.IsNullOrWhiteSpace(txtUserNombre.Text) ||
                string.IsNullOrWhiteSpace(txtUserCorreo.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarUsuario())
                return;

            int id = (int)dgvCRUDUsers.CurrentRow.Cells["ID"].Value;
            var user = DatosAlmacenados.Usuarios.FirstOrDefault(u => u.ID == id);

            if (user != null)
            {
                user.Nombre = txtUserNombre.Text.Trim();
                user.Correo = txtUserCorreo.Text.Trim();

                dgvCRUDUsers.DataSource = null;
                dgvCRUDUsers.DataSource = DatosAlmacenados.Usuarios;
                dgvCRUDUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCRUDUsers.ClearSelection();

                LimpiarCampos();
                MessageBox.Show("Usuario editado correctamente.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvCRUDUsers.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvCRUDUsers.CurrentRow.Cells["ID"].Value;
            var user = DatosAlmacenados.Usuarios.FirstOrDefault(u => u.ID == id);

            if (user != null)
            {
                DatosAlmacenados.Usuarios.Remove(user);
                RefrescarGridUsers();
                LimpiarCampos();
                MessageBox.Show("Usuario eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVaciarUsuario_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            dgvCRUDUsers.ClearSelection();
            MessageBox.Show("Campos vaciados.", "Limpiar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ActualizarGrid()
        {
            dgvCRUDUsers.DataSource = null;
            dgvCRUDUsers.DataSource = listaUsers;
        }

        private void dgvCRUDUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCRUDUsers.CurrentRow != null)
            {
                txtUserId.Text = dgvCRUDUsers.CurrentRow.Cells[0].Value.ToString();
                txtUserNombre.Text = dgvCRUDUsers.CurrentRow.Cells[1].Value.ToString();
                txtUserCorreo.Text = dgvCRUDUsers.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void LimpiarCamposLending()
        {
            txtPrestamoID.Clear();
            cmbPrestamoUsuarios.SelectedIndex = -1;
            cmbPrestamoLibros.SelectedIndex = -1;
            dtpFechaPrestamo.Value = DateTime.Now;
            dtpFechaDevolucion.Value = DateTime.Now.AddDays(1);
        }

        private void RefrescarGridLendings()
        {
            var vista = DatosAlmacenados.Lending.Select(p => new
            {
                p.ID,
                Usuario = DatosAlmacenados.Usuarios.First(u => u.ID == p.UserID).Nombre,
                Libro = DatosAlmacenados.Libros.First(l => l.Id == p.LibroID).Titulo,
                Fecha_Préstamo = p.FechaPrestamo.ToString("dd/MM/yyyy"),
                Fecha_Devolución = p.FechaDevolucion.ToString("dd/MM/yyyy")
            }).ToList();

            dgvPrestamoLibros.DataSource = null;
            dgvPrestamoLibros.AutoGenerateColumns = true;
            dgvPrestamoLibros.DataSource = vista;
            dgvPrestamoLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPrestamoLibros.ClearSelection();
        }

        private void RefrescarCombosPrestamo()
        {
            // Parte Usuarios
            cmbPrestamoUsuarios.DataSource = null;
            cmbPrestamoUsuarios.DataSource = DatosAlmacenados.Usuarios;
            cmbPrestamoUsuarios.DisplayMember = "Nombre";
            cmbPrestamoUsuarios.ValueMember = "ID";

            // Parte Libros
            cmbPrestamoLibros.DataSource = null;
            cmbPrestamoLibros.DataSource = DatosAlmacenados.Libros;
            cmbPrestamoLibros.DisplayMember = "Titulo";
            cmbPrestamoLibros.ValueMember = "Id";
        }

        private void CargarCombosPrestamo()
        {
            // Parte Usuarios
            cmbPrestamoUsuarios.DataSource = null;
            cmbPrestamoUsuarios.DataSource = DatosAlmacenados.Usuarios;
            cmbPrestamoUsuarios.DisplayMember = "Nombre";
            cmbPrestamoUsuarios.ValueMember = "ID";      

            // Parte Libros
            cmbPrestamoLibros.DataSource = null;
            cmbPrestamoLibros.DataSource = DatosAlmacenados.Libros;
            cmbPrestamoLibros.DisplayMember = "Titulo";
            cmbPrestamoLibros.ValueMember = "Id";
        }

        private bool ValidarPrestamo()
        {
            if (cmbPrestamoUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPrestamoUsuarios.Focus();
                return false;
            }

            if (cmbPrestamoLibros.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un libro.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPrestamoLibros.Focus();
                return false;
            }

            if (dtpFechaPrestamo.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("La fecha de préstamo no puede ser menor a la fecha actual.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaPrestamo.Focus();
                return false;
            }

            if (dtpFechaDevolucion.Value.Date <= dtpFechaPrestamo.Value.Date)
            {
                MessageBox.Show("La fecha de devolución debe ser posterior a la de préstamo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaDevolucion.Focus();
                return false;
            }

            int userId = ((Users)cmbPrestamoUsuarios.SelectedItem).ID;
            int libroId = ((Books)cmbPrestamoLibros.SelectedItem).Id;

            bool existePrestamoActivo = DatosAlmacenados.Lending.Any(l =>
                l.UserID == userId &&
                l.LibroID == libroId &&
                l.FechaDevolucion >= DateTime.Now.Date);

            if (existePrestamoActivo)
            {
                MessageBox.Show("Este usuario ya tiene un préstamo activo de este libro.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            if (!ValidarPrestamo())
                return;

            int nuevoId = DatosAlmacenados.Lending.Any()
                ? DatosAlmacenados.Lending.Max(x => x.ID) + 1
                : 1;

            DatosAlmacenados.Lending.Add(new Lending
            {
                ID = nuevoId,
                UserID = ((Users)cmbPrestamoUsuarios.SelectedItem).ID,
                LibroID = ((Books)cmbPrestamoLibros.SelectedItem).Id,
                FechaPrestamo = dtpFechaPrestamo.Value.Date,
                FechaDevolucion = dtpFechaDevolucion.Value.Date
            });

            RefrescarGridLendings();
            LimpiarCamposLending();
            MessageBox.Show("Préstamo agregado correctamente.");
        }

        private void btnEditarPrestamo_Click(object sender, EventArgs e)
        {
            if (!ValidarPrestamo())
                return;

            if (dgvPrestamoLibros.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un préstamo para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            object idObj = null;
            if (dgvPrestamoLibros.Columns.Contains("ID"))
                idObj = dgvPrestamoLibros.CurrentRow.Cells["ID"]?.Value;
            if (idObj == null)
                idObj = dgvPrestamoLibros.CurrentRow.Cells.Count > 0 ? dgvPrestamoLibros.CurrentRow.Cells[0]?.Value : null;

            if (idObj == null || !int.TryParse(idObj.ToString(), out int id))
            {
                MessageBox.Show("ID inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lending = DatosAlmacenados.Lending.FirstOrDefault(l => l.ID == id);
            if (lending == null)
            {
                MessageBox.Show("No se encontró el préstamo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbPrestamoUsuarios.SelectedValue == null || cmbPrestamoLibros.SelectedValue == null)
            {
                MessageBox.Show("Seleccione usuario y libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpFechaDevolucion.Value.Date <= dtpFechaPrestamo.Value.Date)
            {
                MessageBox.Show("La fecha de devolución debe ser posterior a la de préstamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lending.UserID = Convert.ToInt32(cmbPrestamoUsuarios.SelectedValue);
            lending.LibroID = Convert.ToInt32(cmbPrestamoLibros.SelectedValue);
            lending.FechaPrestamo = dtpFechaPrestamo.Value.Date;
            lending.FechaDevolucion = dtpFechaDevolucion.Value.Date;

            RefrescarGridLendings();
            LimpiarCamposLending();

            MessageBox.Show("Préstamo editado correctamente.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminarPrestamo_Click(object sender, EventArgs e)
        {
            if (dgvPrestamoLibros.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un préstamo para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            object idObj = null;
            if (dgvPrestamoLibros.Columns.Contains("ID"))
                idObj = dgvPrestamoLibros.CurrentRow.Cells["ID"]?.Value;
            if (idObj == null)
                idObj = dgvPrestamoLibros.CurrentRow.Cells.Count > 0 ? dgvPrestamoLibros.CurrentRow.Cells[0]?.Value : null;

            if (idObj == null || !int.TryParse(idObj.ToString(), out int id))
            {
                MessageBox.Show("ID inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lending = DatosAlmacenados.Lending.FirstOrDefault(l => l.ID == id);
            if (lending == null)
            {
                MessageBox.Show("No se encontró el préstamo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DatosAlmacenados.Lending.Remove(lending);
            RefrescarGridLendings();
            LimpiarCamposLending();
            MessageBox.Show("Préstamo eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiarPrestamo_Click(object sender, EventArgs e)
        {
            LimpiarCamposLending();
            dgvPrestamoLibros.ClearSelection();

            cmbFiltro.SelectedIndex = 0;
            RefrescarGridLendings();

            MessageBox.Show("Campos y filtro vaciados.", "Limpiar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvPrestamoLibros_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvPrestamoLibros.CurrentRow == null) return;

            object idObj = null;
            if (dgvPrestamoLibros.Columns.Contains("ID"))
                idObj = dgvPrestamoLibros.CurrentRow.Cells["ID"]?.Value;
            if (idObj == null)
                idObj = dgvPrestamoLibros.CurrentRow.Cells.Count > 0 ? dgvPrestamoLibros.CurrentRow.Cells[0]?.Value : null;

            if (idObj == null) return;

            if (!int.TryParse(idObj.ToString(), out int id)) return;

            var lending = DatosAlmacenados.Lending.FirstOrDefault(l => l.ID == id);
            if (lending == null) return;

            if (cmbPrestamoUsuarios.DataSource == null) RefrescarCombosPrestamo();
            if (cmbPrestamoLibros.DataSource == null) RefrescarCombosPrestamo();

            txtPrestamoID.Text = lending.ID.ToString();

            cmbPrestamoUsuarios.SelectedValue = lending.UserID;
            cmbPrestamoLibros.SelectedValue = lending.LibroID;

            dtpFechaPrestamo.Value = lending.FechaPrestamo;
            dtpFechaDevolucion.Value = lending.FechaDevolucion;
        }

        /*********************************************/
        private void frmUserAndBookLending_Load(object sender, EventArgs e)
        {
            var listaFiltro = new List<Users>
            {
                new Users { ID = 0, Nombre = "Todos" }
            };
            listaFiltro.AddRange(DatosAlmacenados.Usuarios);

            cmbFiltro.DataSource = null;
            cmbFiltro.DataSource = listaFiltro;
            cmbFiltro.DisplayMember = "Nombre";
            cmbFiltro.ValueMember = "ID";
            cmbFiltro.SelectedIndex = 0;

            dgvCRUDUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cmbPrestamoUsuarios.DataSource = listaUsers;
            cmbPrestamoUsuarios.DisplayMember = "Nombre";
            cmbPrestamoUsuarios.ValueMember = "ID";

            cmbPrestamoLibros.DataSource = frmLibros.Libro;
            cmbPrestamoLibros.DisplayMember = "Titulo";
            cmbPrestamoLibros.ValueMember = "ID";

            dtpFechaPrestamo.Format = DateTimePickerFormat.Custom;
            dtpFechaPrestamo.CustomFormat = "dd/MM/yyyy";

            dtpFechaDevolucion.Format = DateTimePickerFormat.Custom;
            dtpFechaDevolucion.CustomFormat = "dd/MM/yyyy";

            RefrescarGridUsers();
            RefrescarGridLendings();
            dgvPrestamoLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCambiarFormulario_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmLibros formLibros = new frmLibros();
            formLibros.ShowDialog();

            RefrescarGridUsers();
            RefrescarGridLendings();
            this.Show();
        }

        private void frmUserAndBookLending_Shown(object sender, EventArgs e)
        {
            RefrescarGridUsers();
            RefrescarGridLendings();
            CargarCombosPrestamo();
        }

        private void frmUserAndBookLending_Activated(object sender, EventArgs e)
        {
            RefrescarGridLendings();
        }
    }
}
