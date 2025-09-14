namespace Desafio1Andres_Rodriguez
{
    partial class frmUserAndBookLending
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAndBookLending));
            this.dgvCRUDUsers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtUserNombre = new System.Windows.Forms.TextBox();
            this.txtUserCorreo = new System.Windows.Forms.TextBox();
            this.btnUserCreate = new System.Windows.Forms.Button();
            this.btnUserEdit = new System.Windows.Forms.Button();
            this.txtUserClear = new System.Windows.Forms.Button();
            this.txtUserDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrestamoID = new System.Windows.Forms.TextBox();
            this.cmbPrestamoLibros = new System.Windows.Forms.ComboBox();
            this.cmbPrestamoUsuarios = new System.Windows.Forms.ComboBox();
            this.dtpFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvPrestamoLibros = new System.Windows.Forms.DataGridView();
            this.btnAgregarPrestamo = new System.Windows.Forms.Button();
            this.btnEditarPrestamo = new System.Windows.Forms.Button();
            this.btnEliminarPrestamo = new System.Windows.Forms.Button();
            this.btnVaciarPrestamo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCRUDUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCRUDUsers
            // 
            this.dgvCRUDUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCRUDUsers.Location = new System.Drawing.Point(12, 64);
            this.dgvCRUDUsers.Name = "dgvCRUDUsers";
            this.dgvCRUDUsers.Size = new System.Drawing.Size(467, 150);
            this.dgvCRUDUsers.TabIndex = 0;
            this.dgvCRUDUsers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCRUDUsers_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(485, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(485, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(485, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Correo:";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(540, 65);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(154, 20);
            this.txtUserId.TabIndex = 4;
            // 
            // txtUserNombre
            // 
            this.txtUserNombre.Location = new System.Drawing.Point(540, 95);
            this.txtUserNombre.Name = "txtUserNombre";
            this.txtUserNombre.Size = new System.Drawing.Size(154, 20);
            this.txtUserNombre.TabIndex = 5;
            // 
            // txtUserCorreo
            // 
            this.txtUserCorreo.Location = new System.Drawing.Point(540, 123);
            this.txtUserCorreo.Name = "txtUserCorreo";
            this.txtUserCorreo.Size = new System.Drawing.Size(154, 20);
            this.txtUserCorreo.TabIndex = 6;
            // 
            // btnUserCreate
            // 
            this.btnUserCreate.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUserCreate.Location = new System.Drawing.Point(522, 155);
            this.btnUserCreate.Name = "btnUserCreate";
            this.btnUserCreate.Size = new System.Drawing.Size(75, 23);
            this.btnUserCreate.TabIndex = 7;
            this.btnUserCreate.Text = "Crear";
            this.btnUserCreate.UseVisualStyleBackColor = false;
            this.btnUserCreate.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnUserEdit
            // 
            this.btnUserEdit.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUserEdit.Location = new System.Drawing.Point(522, 185);
            this.btnUserEdit.Name = "btnUserEdit";
            this.btnUserEdit.Size = new System.Drawing.Size(75, 23);
            this.btnUserEdit.TabIndex = 8;
            this.btnUserEdit.Text = "Editar";
            this.btnUserEdit.UseVisualStyleBackColor = false;
            this.btnUserEdit.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // txtUserClear
            // 
            this.txtUserClear.BackColor = System.Drawing.Color.PowderBlue;
            this.txtUserClear.Location = new System.Drawing.Point(618, 154);
            this.txtUserClear.Name = "txtUserClear";
            this.txtUserClear.Size = new System.Drawing.Size(75, 23);
            this.txtUserClear.TabIndex = 9;
            this.txtUserClear.Text = "Vaciar";
            this.txtUserClear.UseVisualStyleBackColor = false;
            this.txtUserClear.Click += new System.EventHandler(this.btnVaciarUsuario_Click);
            // 
            // txtUserDelete
            // 
            this.txtUserDelete.BackColor = System.Drawing.Color.PowderBlue;
            this.txtUserDelete.Location = new System.Drawing.Point(618, 184);
            this.txtUserDelete.Name = "txtUserDelete";
            this.txtUserDelete.Size = new System.Drawing.Size(75, 23);
            this.txtUserDelete.TabIndex = 10;
            this.txtUserDelete.Text = "Eliminar";
            this.txtUserDelete.UseVisualStyleBackColor = false;
            this.txtUserDelete.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Administración de Usuarios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gestion de Prestamos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(26, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nombre del Libro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(26, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nombre del Usuario:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(26, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fecha del prestamo:";
            // 
            // txtPrestamoID
            // 
            this.txtPrestamoID.Location = new System.Drawing.Point(153, 277);
            this.txtPrestamoID.Name = "txtPrestamoID";
            this.txtPrestamoID.ReadOnly = true;
            this.txtPrestamoID.Size = new System.Drawing.Size(200, 20);
            this.txtPrestamoID.TabIndex = 17;
            // 
            // cmbPrestamoLibros
            // 
            this.cmbPrestamoLibros.FormattingEnabled = true;
            this.cmbPrestamoLibros.Location = new System.Drawing.Point(153, 306);
            this.cmbPrestamoLibros.Name = "cmbPrestamoLibros";
            this.cmbPrestamoLibros.Size = new System.Drawing.Size(200, 21);
            this.cmbPrestamoLibros.TabIndex = 18;
            // 
            // cmbPrestamoUsuarios
            // 
            this.cmbPrestamoUsuarios.FormattingEnabled = true;
            this.cmbPrestamoUsuarios.Location = new System.Drawing.Point(153, 334);
            this.cmbPrestamoUsuarios.Name = "cmbPrestamoUsuarios";
            this.cmbPrestamoUsuarios.Size = new System.Drawing.Size(200, 21);
            this.cmbPrestamoUsuarios.TabIndex = 19;
            // 
            // dtpFechaPrestamo
            // 
            this.dtpFechaPrestamo.CustomFormat = "dd/mm/yyyy";
            this.dtpFechaPrestamo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(153, 362);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            this.dtpFechaPrestamo.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPrestamo.TabIndex = 20;
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(153, 389);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDevolucion.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(26, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Fecha de devolución:";
            // 
            // dgvPrestamoLibros
            // 
            this.dgvPrestamoLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamoLibros.Location = new System.Drawing.Point(382, 250);
            this.dgvPrestamoLibros.Name = "dgvPrestamoLibros";
            this.dgvPrestamoLibros.Size = new System.Drawing.Size(386, 188);
            this.dgvPrestamoLibros.TabIndex = 23;
            this.dgvPrestamoLibros.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPrestamoLibros_RowHeaderMouseClick);
            // 
            // btnAgregarPrestamo
            // 
            this.btnAgregarPrestamo.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAgregarPrestamo.Location = new System.Drawing.Point(29, 419);
            this.btnAgregarPrestamo.Name = "btnAgregarPrestamo";
            this.btnAgregarPrestamo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPrestamo.TabIndex = 24;
            this.btnAgregarPrestamo.Text = "Crear";
            this.btnAgregarPrestamo.UseVisualStyleBackColor = false;
            this.btnAgregarPrestamo.Click += new System.EventHandler(this.btnAgregarPrestamo_Click);
            // 
            // btnEditarPrestamo
            // 
            this.btnEditarPrestamo.BackColor = System.Drawing.Color.PowderBlue;
            this.btnEditarPrestamo.Location = new System.Drawing.Point(110, 419);
            this.btnEditarPrestamo.Name = "btnEditarPrestamo";
            this.btnEditarPrestamo.Size = new System.Drawing.Size(75, 23);
            this.btnEditarPrestamo.TabIndex = 25;
            this.btnEditarPrestamo.Text = "Editar";
            this.btnEditarPrestamo.UseVisualStyleBackColor = false;
            this.btnEditarPrestamo.Click += new System.EventHandler(this.btnEditarPrestamo_Click);
            // 
            // btnEliminarPrestamo
            // 
            this.btnEliminarPrestamo.BackColor = System.Drawing.Color.PowderBlue;
            this.btnEliminarPrestamo.Location = new System.Drawing.Point(192, 418);
            this.btnEliminarPrestamo.Name = "btnEliminarPrestamo";
            this.btnEliminarPrestamo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPrestamo.TabIndex = 26;
            this.btnEliminarPrestamo.Text = "Eliminar";
            this.btnEliminarPrestamo.UseVisualStyleBackColor = false;
            this.btnEliminarPrestamo.Click += new System.EventHandler(this.btnEliminarPrestamo_Click);
            // 
            // btnVaciarPrestamo
            // 
            this.btnVaciarPrestamo.BackColor = System.Drawing.Color.PowderBlue;
            this.btnVaciarPrestamo.Location = new System.Drawing.Point(274, 417);
            this.btnVaciarPrestamo.Name = "btnVaciarPrestamo";
            this.btnVaciarPrestamo.Size = new System.Drawing.Size(75, 23);
            this.btnVaciarPrestamo.TabIndex = 27;
            this.btnVaciarPrestamo.Text = "Vaciar";
            this.btnVaciarPrestamo.UseVisualStyleBackColor = false;
            this.btnVaciarPrestamo.Click += new System.EventHandler(this.btnLimpiarPrestamo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(599, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 40);
            this.button1.TabIndex = 28;
            this.button1.Text = "Libros y Estadisticas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnCambiarFormulario_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(8, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(440, 39);
            this.label11.TabIndex = 29;
            this.label11.Text = "GESTION DE BIBLIOTECA";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(29, 240);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(324, 21);
            this.cmbFiltro.TabIndex = 30;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // frmUserAndBookLending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Desafio1Andres_Rodriguez.Properties.Resources._0_cqPWt_uqeZgPWRby;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVaciarPrestamo);
            this.Controls.Add(this.btnEliminarPrestamo);
            this.Controls.Add(this.btnEditarPrestamo);
            this.Controls.Add(this.btnAgregarPrestamo);
            this.Controls.Add(this.dgvPrestamoLibros);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpFechaDevolucion);
            this.Controls.Add(this.dtpFechaPrestamo);
            this.Controls.Add(this.cmbPrestamoUsuarios);
            this.Controls.Add(this.cmbPrestamoLibros);
            this.Controls.Add(this.txtPrestamoID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUserDelete);
            this.Controls.Add(this.txtUserClear);
            this.Controls.Add(this.btnUserEdit);
            this.Controls.Add(this.btnUserCreate);
            this.Controls.Add(this.txtUserCorreo);
            this.Controls.Add(this.txtUserNombre);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCRUDUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserAndBookLending";
            this.Text = "frmUserAndBookLending";
            this.Activated += new System.EventHandler(this.frmUserAndBookLending_Activated);
            this.Load += new System.EventHandler(this.frmUserAndBookLending_Load);
            this.Shown += new System.EventHandler(this.frmUserAndBookLending_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCRUDUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCRUDUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtUserNombre;
        private System.Windows.Forms.TextBox txtUserCorreo;
        private System.Windows.Forms.Button btnUserCreate;
        private System.Windows.Forms.Button btnUserEdit;
        private System.Windows.Forms.Button txtUserClear;
        private System.Windows.Forms.Button txtUserDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrestamoID;
        private System.Windows.Forms.ComboBox cmbPrestamoLibros;
        private System.Windows.Forms.ComboBox cmbPrestamoUsuarios;
        private System.Windows.Forms.DateTimePicker dtpFechaPrestamo;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvPrestamoLibros;
        private System.Windows.Forms.Button btnAgregarPrestamo;
        private System.Windows.Forms.Button btnEditarPrestamo;
        private System.Windows.Forms.Button btnEliminarPrestamo;
        private System.Windows.Forms.Button btnVaciarPrestamo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbFiltro;
    }
}