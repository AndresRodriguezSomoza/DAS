namespace Desafio1Andres_Rodriguez
{
    partial class frmLibros
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibros));
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            this.Libros = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.chartLibros = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.chartUsuarios = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.Libros.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLibros)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(10, 80);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(443, 150);
            this.dgvBooks.TabIndex = 0;
            this.dgvBooks.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBooks_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTION DE BIBLIOTECA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Autor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Titulo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Año:";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCreate.Location = new System.Drawing.Point(279, 236);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.PowderBlue;
            this.btnEdit.Location = new System.Drawing.Point(360, 236);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDelete.Location = new System.Drawing.Point(360, 265);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.PowderBlue;
            this.btnClean.Location = new System.Drawing.Point(279, 265);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 9;
            this.btnClean.Text = "Vaciar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(47, 245);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(196, 20);
            this.txtId.TabIndex = 10;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(47, 271);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(196, 20);
            this.txtTitulo.TabIndex = 11;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(47, 296);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(196, 20);
            this.txtAutor.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(590, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 44);
            this.button1.TabIndex = 14;
            this.button1.Text = "Usuarios y Prestamos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnCambiarFormulario_Click);
            // 
            // dtpYear
            // 
            this.dtpYear.Location = new System.Drawing.Point(47, 324);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.Size = new System.Drawing.Size(196, 20);
            this.dtpYear.TabIndex = 15;
            // 
            // Libros
            // 
            this.Libros.Controls.Add(this.tabPage1);
            this.Libros.Controls.Add(this.tabPage2);
            this.Libros.Location = new System.Drawing.Point(476, 80);
            this.Libros.Name = "Libros";
            this.Libros.SelectedIndex = 0;
            this.Libros.Size = new System.Drawing.Size(303, 363);
            this.Libros.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.chartLibros);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(295, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LIBROS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "LIBROS MAS PRESTADO";
            // 
            // chartLibros
            // 
            chartArea1.Name = "ChartArea1";
            this.chartLibros.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartLibros.Legends.Add(legend1);
            this.chartLibros.Location = new System.Drawing.Point(3, 29);
            this.chartLibros.Name = "chartLibros";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartLibros.Series.Add(series1);
            this.chartLibros.Size = new System.Drawing.Size(286, 302);
            this.chartLibros.TabIndex = 0;
            this.chartLibros.Text = "chart2";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.chartUsuarios);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(295, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "USUARIOS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "USUARIOS MAS ACTIVO";
            // 
            // chartUsuarios
            // 
            chartArea2.Name = "ChartArea1";
            this.chartUsuarios.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartUsuarios.Legends.Add(legend2);
            this.chartUsuarios.Location = new System.Drawing.Point(6, 29);
            this.chartUsuarios.Name = "chartUsuarios";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartUsuarios.Series.Add(series2);
            this.chartUsuarios.Size = new System.Drawing.Size(286, 302);
            this.chartUsuarios.TabIndex = 0;
            this.chartUsuarios.Text = "chart1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Administración de Libros";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(545, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Estadisticas de Prestamos y Usuarios";
            // 
            // frmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Desafio1Andres_Rodriguez.Properties.Resources._0_cqPWt_uqeZgPWRby;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Libros);
            this.Controls.Add(this.dtpYear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBooks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLibros";
            this.Text = "frmLibros";
            this.Shown += new System.EventHandler(this.frmLibros_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.Libros.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLibros)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.DateTimePicker dtpYear;
        private System.Windows.Forms.TabControl Libros;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLibros;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUsuarios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

