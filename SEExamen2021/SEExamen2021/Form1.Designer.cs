namespace SEExamen2021
{
    partial class Form1
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
            this.cmbCRUD = new System.Windows.Forms.ComboBox();
            this.grpBoxInsertar = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtCasada = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefonoOne = new System.Windows.Forms.TextBox();
            this.txtTelefonoTwo = new System.Windows.Forms.TextBox();
            this.txtDpi = new System.Windows.Forms.TextBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.rdbActivoI = new System.Windows.Forms.RadioButton();
            this.rdbInactivoI = new System.Windows.Forms.RadioButton();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.dgvInserciones = new System.Windows.Forms.DataGridView();
            this.grpModificar = new System.Windows.Forms.GroupBox();
            this.txtSearchU = new System.Windows.Forms.TextBox();
            this.dgvModificar = new System.Windows.Forms.DataGridView();
            this.btnSelectCodeUpdate = new System.Windows.Forms.Button();
            this.txtCodeModificar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCasadaU = new System.Windows.Forms.TextBox();
            this.txtDireccionU = new System.Windows.Forms.TextBox();
            this.rdbActivoU = new System.Windows.Forms.RadioButton();
            this.rdbInactivoU = new System.Windows.Forms.RadioButton();
            this.txtEstadoU = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.chkBox = new System.Windows.Forms.CheckBox();
            this.chkCasadaU = new System.Windows.Forms.CheckBox();
            this.grpBoxDelete = new System.Windows.Forms.GroupBox();
            this.txtSearchD = new System.Windows.Forms.TextBox();
            this.dgvDelete = new System.Windows.Forms.DataGridView();
            this.btnSelectDCode = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPrimerNombreD = new System.Windows.Forms.TextBox();
            this.txtSegundoNombreD = new System.Windows.Forms.TextBox();
            this.txtPrimerApellidoD = new System.Windows.Forms.TextBox();
            this.txtSegundoApellidoD = new System.Windows.Forms.TextBox();
            this.txtDireccionD = new System.Windows.Forms.TextBox();
            this.dtpNacimientoD = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCodeToD = new System.Windows.Forms.TextBox();
            this.grpBoxInsertar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInserciones)).BeginInit();
            this.grpModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificar)).BeginInit();
            this.grpBoxDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCRUD
            // 
            this.cmbCRUD.FormattingEnabled = true;
            this.cmbCRUD.Items.AddRange(new object[] {
            "Seleccione...",
            "Creación de Clientes",
            "Actualización de Clientes",
            "Eliminación de Clientes"});
            this.cmbCRUD.Location = new System.Drawing.Point(210, 12);
            this.cmbCRUD.Name = "cmbCRUD";
            this.cmbCRUD.Size = new System.Drawing.Size(372, 21);
            this.cmbCRUD.TabIndex = 0;
            this.cmbCRUD.SelectedIndexChanged += new System.EventHandler(this.cmbCRUD_SelectedIndexChanged);
            // 
            // grpBoxInsertar
            // 
            this.grpBoxInsertar.Controls.Add(this.chkBox);
            this.grpBoxInsertar.Controls.Add(this.dgvInserciones);
            this.grpBoxInsertar.Controls.Add(this.btnInsertar);
            this.grpBoxInsertar.Controls.Add(this.txtEstado);
            this.grpBoxInsertar.Controls.Add(this.rdbInactivoI);
            this.grpBoxInsertar.Controls.Add(this.rdbActivoI);
            this.grpBoxInsertar.Controls.Add(this.dtpNacimiento);
            this.grpBoxInsertar.Controls.Add(this.txtDpi);
            this.grpBoxInsertar.Controls.Add(this.txtTelefonoTwo);
            this.grpBoxInsertar.Controls.Add(this.txtTelefonoOne);
            this.grpBoxInsertar.Controls.Add(this.txtDireccion);
            this.grpBoxInsertar.Controls.Add(this.txtCasada);
            this.grpBoxInsertar.Controls.Add(this.txtSegundoApellido);
            this.grpBoxInsertar.Controls.Add(this.txtPrimerApellido);
            this.grpBoxInsertar.Controls.Add(this.txtSegundoNombre);
            this.grpBoxInsertar.Controls.Add(this.txtPrimerNombre);
            this.grpBoxInsertar.Controls.Add(this.label11);
            this.grpBoxInsertar.Controls.Add(this.label10);
            this.grpBoxInsertar.Controls.Add(this.label9);
            this.grpBoxInsertar.Controls.Add(this.label8);
            this.grpBoxInsertar.Controls.Add(this.label7);
            this.grpBoxInsertar.Controls.Add(this.label6);
            this.grpBoxInsertar.Controls.Add(this.label4);
            this.grpBoxInsertar.Controls.Add(this.label3);
            this.grpBoxInsertar.Controls.Add(this.label2);
            this.grpBoxInsertar.Controls.Add(this.label1);
            this.grpBoxInsertar.Location = new System.Drawing.Point(36, 63);
            this.grpBoxInsertar.Name = "grpBoxInsertar";
            this.grpBoxInsertar.Size = new System.Drawing.Size(766, 639);
            this.grpBoxInsertar.TabIndex = 1;
            this.grpBoxInsertar.TabStop = false;
            this.grpBoxInsertar.Text = "INSERTAR";
            this.grpBoxInsertar.Visible = false;
            this.grpBoxInsertar.Enter += new System.EventHandler(this.grpBoxInsertar_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(193, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Estado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(501, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Fecha de Nacimiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "DPI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(586, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Teléfono 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Teléfono 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Segundo Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Primer Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segundo Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primer Nombre";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(128, 82);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(182, 20);
            this.txtPrimerNombre.TabIndex = 11;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(327, 82);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(171, 20);
            this.txtSegundoNombre.TabIndex = 12;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(128, 161);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(182, 20);
            this.txtPrimerApellido.TabIndex = 13;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(327, 161);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(171, 20);
            this.txtSegundoApellido.TabIndex = 14;
            // 
            // txtCasada
            // 
            this.txtCasada.Enabled = false;
            this.txtCasada.Location = new System.Drawing.Point(513, 161);
            this.txtCasada.Name = "txtCasada";
            this.txtCasada.Size = new System.Drawing.Size(155, 20);
            this.txtCasada.TabIndex = 15;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(128, 237);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(299, 20);
            this.txtDireccion.TabIndex = 16;
            // 
            // txtTelefonoOne
            // 
            this.txtTelefonoOne.Location = new System.Drawing.Point(462, 237);
            this.txtTelefonoOne.Name = "txtTelefonoOne";
            this.txtTelefonoOne.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoOne.TabIndex = 17;
            this.txtTelefonoOne.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtTelefonoTwo
            // 
            this.txtTelefonoTwo.Location = new System.Drawing.Point(568, 237);
            this.txtTelefonoTwo.Name = "txtTelefonoTwo";
            this.txtTelefonoTwo.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoTwo.TabIndex = 18;
            this.txtTelefonoTwo.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtDpi
            // 
            this.txtDpi.Location = new System.Drawing.Point(176, 307);
            this.txtDpi.Name = "txtDpi";
            this.txtDpi.Size = new System.Drawing.Size(205, 20);
            this.txtDpi.TabIndex = 19;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(462, 307);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(206, 20);
            this.dtpNacimiento.TabIndex = 20;
            // 
            // rdbActivoI
            // 
            this.rdbActivoI.AutoSize = true;
            this.rdbActivoI.Location = new System.Drawing.Point(128, 389);
            this.rdbActivoI.Name = "rdbActivoI";
            this.rdbActivoI.Size = new System.Drawing.Size(55, 17);
            this.rdbActivoI.TabIndex = 21;
            this.rdbActivoI.TabStop = true;
            this.rdbActivoI.Text = "Activo";
            this.rdbActivoI.UseVisualStyleBackColor = true;
            this.rdbActivoI.CheckedChanged += new System.EventHandler(this.rdbActivoI_CheckedChanged);
            // 
            // rdbInactivoI
            // 
            this.rdbInactivoI.AutoSize = true;
            this.rdbInactivoI.Location = new System.Drawing.Point(244, 389);
            this.rdbInactivoI.Name = "rdbInactivoI";
            this.rdbInactivoI.Size = new System.Drawing.Size(63, 17);
            this.rdbInactivoI.TabIndex = 22;
            this.rdbInactivoI.TabStop = true;
            this.rdbInactivoI.Text = "Inactivo";
            this.rdbInactivoI.UseVisualStyleBackColor = true;
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(159, 425);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 23;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(508, 397);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(160, 48);
            this.btnInsertar.TabIndex = 24;
            this.btnInsertar.Text = "Insertar Cliente";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dgvInserciones
            // 
            this.dgvInserciones.AllowUserToAddRows = false;
            this.dgvInserciones.AllowUserToDeleteRows = false;
            this.dgvInserciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInserciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInserciones.Location = new System.Drawing.Point(7, 469);
            this.dgvInserciones.Name = "dgvInserciones";
            this.dgvInserciones.ReadOnly = true;
            this.dgvInserciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInserciones.Size = new System.Drawing.Size(753, 150);
            this.dgvInserciones.TabIndex = 25;
            // 
            // grpModificar
            // 
            this.grpModificar.Controls.Add(this.grpBoxDelete);
            this.grpModificar.Controls.Add(this.chkCasadaU);
            this.grpModificar.Controls.Add(this.btnModificar);
            this.grpModificar.Controls.Add(this.txtEstadoU);
            this.grpModificar.Controls.Add(this.rdbInactivoU);
            this.grpModificar.Controls.Add(this.rdbActivoU);
            this.grpModificar.Controls.Add(this.txtDireccionU);
            this.grpModificar.Controls.Add(this.txtCasadaU);
            this.grpModificar.Controls.Add(this.label12);
            this.grpModificar.Controls.Add(this.label13);
            this.grpModificar.Controls.Add(this.txtCodeModificar);
            this.grpModificar.Controls.Add(this.btnSelectCodeUpdate);
            this.grpModificar.Controls.Add(this.dgvModificar);
            this.grpModificar.Controls.Add(this.txtSearchU);
            this.grpModificar.Location = new System.Drawing.Point(36, 63);
            this.grpModificar.Name = "grpModificar";
            this.grpModificar.Size = new System.Drawing.Size(900, 425);
            this.grpModificar.TabIndex = 2;
            this.grpModificar.TabStop = false;
            this.grpModificar.Text = "MODIFICAR";
            this.grpModificar.Visible = false;
            // 
            // txtSearchU
            // 
            this.txtSearchU.Location = new System.Drawing.Point(21, 20);
            this.txtSearchU.Name = "txtSearchU";
            this.txtSearchU.Size = new System.Drawing.Size(305, 20);
            this.txtSearchU.TabIndex = 0;
            this.txtSearchU.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchU_KeyUp);
            // 
            // dgvModificar
            // 
            this.dgvModificar.AllowUserToAddRows = false;
            this.dgvModificar.AllowUserToDeleteRows = false;
            this.dgvModificar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificar.Location = new System.Drawing.Point(21, 62);
            this.dgvModificar.Name = "dgvModificar";
            this.dgvModificar.ReadOnly = true;
            this.dgvModificar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModificar.Size = new System.Drawing.Size(739, 150);
            this.dgvModificar.TabIndex = 1;
            // 
            // btnSelectCodeUpdate
            // 
            this.btnSelectCodeUpdate.Location = new System.Drawing.Point(772, 82);
            this.btnSelectCodeUpdate.Name = "btnSelectCodeUpdate";
            this.btnSelectCodeUpdate.Size = new System.Drawing.Size(104, 42);
            this.btnSelectCodeUpdate.TabIndex = 2;
            this.btnSelectCodeUpdate.Text = "Seleccionar Cliente";
            this.btnSelectCodeUpdate.UseVisualStyleBackColor = true;
            this.btnSelectCodeUpdate.Click += new System.EventHandler(this.btnSelectCodeUpdate_Click);
            // 
            // txtCodeModificar
            // 
            this.txtCodeModificar.Enabled = false;
            this.txtCodeModificar.Location = new System.Drawing.Point(766, 141);
            this.txtCodeModificar.Name = "txtCodeModificar";
            this.txtCodeModificar.Size = new System.Drawing.Size(100, 20);
            this.txtCodeModificar.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(99, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Estado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(374, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Dirección";
            // 
            // txtCasadaU
            // 
            this.txtCasadaU.Enabled = false;
            this.txtCasadaU.Location = new System.Drawing.Point(31, 260);
            this.txtCasadaU.Name = "txtCasadaU";
            this.txtCasadaU.Size = new System.Drawing.Size(180, 20);
            this.txtCasadaU.TabIndex = 14;
            // 
            // txtDireccionU
            // 
            this.txtDireccionU.Location = new System.Drawing.Point(248, 260);
            this.txtDireccionU.Name = "txtDireccionU";
            this.txtDireccionU.Size = new System.Drawing.Size(305, 20);
            this.txtDireccionU.TabIndex = 15;
            // 
            // rdbActivoU
            // 
            this.rdbActivoU.AutoSize = true;
            this.rdbActivoU.Location = new System.Drawing.Point(31, 340);
            this.rdbActivoU.Name = "rdbActivoU";
            this.rdbActivoU.Size = new System.Drawing.Size(55, 17);
            this.rdbActivoU.TabIndex = 16;
            this.rdbActivoU.TabStop = true;
            this.rdbActivoU.Text = "Activo";
            this.rdbActivoU.UseVisualStyleBackColor = true;
            this.rdbActivoU.CheckedChanged += new System.EventHandler(this.rdbActivoU_CheckedChanged);
            // 
            // rdbInactivoU
            // 
            this.rdbInactivoU.AutoSize = true;
            this.rdbInactivoU.Location = new System.Drawing.Point(149, 340);
            this.rdbInactivoU.Name = "rdbInactivoU";
            this.rdbInactivoU.Size = new System.Drawing.Size(63, 17);
            this.rdbInactivoU.TabIndex = 17;
            this.rdbInactivoU.TabStop = true;
            this.rdbInactivoU.Text = "Inactivo";
            this.rdbInactivoU.UseVisualStyleBackColor = true;
            // 
            // txtEstadoU
            // 
            this.txtEstadoU.Location = new System.Drawing.Point(70, 377);
            this.txtEstadoU.Name = "txtEstadoU";
            this.txtEstadoU.Size = new System.Drawing.Size(100, 20);
            this.txtEstadoU.TabIndex = 18;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(649, 349);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(242, 48);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Actualizar Información";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // chkBox
            // 
            this.chkBox.AutoSize = true;
            this.chkBox.Location = new System.Drawing.Point(527, 133);
            this.chkBox.Name = "chkBox";
            this.chkBox.Size = new System.Drawing.Size(117, 17);
            this.chkBox.TabIndex = 26;
            this.chkBox.Text = "Apellido de Casada";
            this.chkBox.UseVisualStyleBackColor = true;
            this.chkBox.CheckedChanged += new System.EventHandler(this.chkBox_CheckedChanged);
            // 
            // chkCasadaU
            // 
            this.chkCasadaU.AutoSize = true;
            this.chkCasadaU.Location = new System.Drawing.Point(53, 240);
            this.chkCasadaU.Name = "chkCasadaU";
            this.chkCasadaU.Size = new System.Drawing.Size(117, 17);
            this.chkCasadaU.TabIndex = 20;
            this.chkCasadaU.Text = "Apellido de Casada";
            this.chkCasadaU.UseVisualStyleBackColor = true;
            this.chkCasadaU.CheckedChanged += new System.EventHandler(this.chkCasadaU_CheckedChanged);
            // 
            // grpBoxDelete
            // 
            this.grpBoxDelete.Controls.Add(this.txtCodeToD);
            this.grpBoxDelete.Controls.Add(this.btnDelete);
            this.grpBoxDelete.Controls.Add(this.dtpNacimientoD);
            this.grpBoxDelete.Controls.Add(this.txtDireccionD);
            this.grpBoxDelete.Controls.Add(this.txtSegundoApellidoD);
            this.grpBoxDelete.Controls.Add(this.txtPrimerApellidoD);
            this.grpBoxDelete.Controls.Add(this.txtSegundoNombreD);
            this.grpBoxDelete.Controls.Add(this.txtPrimerNombreD);
            this.grpBoxDelete.Controls.Add(this.label18);
            this.grpBoxDelete.Controls.Add(this.label17);
            this.grpBoxDelete.Controls.Add(this.label16);
            this.grpBoxDelete.Controls.Add(this.label15);
            this.grpBoxDelete.Controls.Add(this.label14);
            this.grpBoxDelete.Controls.Add(this.label5);
            this.grpBoxDelete.Controls.Add(this.btnSelectDCode);
            this.grpBoxDelete.Controls.Add(this.dgvDelete);
            this.grpBoxDelete.Controls.Add(this.txtSearchD);
            this.grpBoxDelete.Location = new System.Drawing.Point(0, 2);
            this.grpBoxDelete.Name = "grpBoxDelete";
            this.grpBoxDelete.Size = new System.Drawing.Size(845, 423);
            this.grpBoxDelete.TabIndex = 3;
            this.grpBoxDelete.TabStop = false;
            this.grpBoxDelete.Text = "ELIMINAR";
            this.grpBoxDelete.Visible = false;
            // 
            // txtSearchD
            // 
            this.txtSearchD.Location = new System.Drawing.Point(17, 32);
            this.txtSearchD.Name = "txtSearchD";
            this.txtSearchD.Size = new System.Drawing.Size(360, 20);
            this.txtSearchD.TabIndex = 0;
            this.txtSearchD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchD_KeyUp);
            // 
            // dgvDelete
            // 
            this.dgvDelete.AllowUserToAddRows = false;
            this.dgvDelete.AllowUserToDeleteRows = false;
            this.dgvDelete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelete.Location = new System.Drawing.Point(17, 71);
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.ReadOnly = true;
            this.dgvDelete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDelete.Size = new System.Drawing.Size(741, 150);
            this.dgvDelete.TabIndex = 1;
            // 
            // btnSelectDCode
            // 
            this.btnSelectDCode.Location = new System.Drawing.Point(764, 80);
            this.btnSelectDCode.Name = "btnSelectDCode";
            this.btnSelectDCode.Size = new System.Drawing.Size(75, 42);
            this.btnSelectDCode.TabIndex = 2;
            this.btnSelectDCode.Text = "Seleccionar Cliente";
            this.btnSelectDCode.UseVisualStyleBackColor = true;
            this.btnSelectDCode.Click += new System.EventHandler(this.btnSelectDCode_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Primer Nombre";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(183, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Segundo Nombre";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(342, 241);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Primer Apellido";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(491, 242);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Segundo Apellido";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 317);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Dirección";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 358);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "Fecha de Nacimiento";
            // 
            // txtPrimerNombreD
            // 
            this.txtPrimerNombreD.Enabled = false;
            this.txtPrimerNombreD.Location = new System.Drawing.Point(17, 270);
            this.txtPrimerNombreD.Name = "txtPrimerNombreD";
            this.txtPrimerNombreD.Size = new System.Drawing.Size(125, 20);
            this.txtPrimerNombreD.TabIndex = 9;
            // 
            // txtSegundoNombreD
            // 
            this.txtSegundoNombreD.Enabled = false;
            this.txtSegundoNombreD.Location = new System.Drawing.Point(167, 270);
            this.txtSegundoNombreD.Name = "txtSegundoNombreD";
            this.txtSegundoNombreD.Size = new System.Drawing.Size(125, 20);
            this.txtSegundoNombreD.TabIndex = 10;
            // 
            // txtPrimerApellidoD
            // 
            this.txtPrimerApellidoD.Enabled = false;
            this.txtPrimerApellidoD.Location = new System.Drawing.Point(318, 270);
            this.txtPrimerApellidoD.Name = "txtPrimerApellidoD";
            this.txtPrimerApellidoD.Size = new System.Drawing.Size(130, 20);
            this.txtPrimerApellidoD.TabIndex = 11;
            // 
            // txtSegundoApellidoD
            // 
            this.txtSegundoApellidoD.Enabled = false;
            this.txtSegundoApellidoD.Location = new System.Drawing.Point(475, 270);
            this.txtSegundoApellidoD.Name = "txtSegundoApellidoD";
            this.txtSegundoApellidoD.Size = new System.Drawing.Size(129, 20);
            this.txtSegundoApellidoD.TabIndex = 12;
            // 
            // txtDireccionD
            // 
            this.txtDireccionD.Enabled = false;
            this.txtDireccionD.Location = new System.Drawing.Point(83, 314);
            this.txtDireccionD.Name = "txtDireccionD";
            this.txtDireccionD.Size = new System.Drawing.Size(264, 20);
            this.txtDireccionD.TabIndex = 13;
            // 
            // dtpNacimientoD
            // 
            this.dtpNacimientoD.Enabled = false;
            this.dtpNacimientoD.Location = new System.Drawing.Point(17, 383);
            this.dtpNacimientoD.Name = "dtpNacimientoD";
            this.dtpNacimientoD.Size = new System.Drawing.Size(200, 20);
            this.dtpNacimientoD.TabIndex = 14;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(601, 338);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(205, 57);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Eliminar Registro";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCodeToD
            // 
            this.txtCodeToD.Location = new System.Drawing.Point(765, 138);
            this.txtCodeToD.Name = "txtCodeToD";
            this.txtCodeToD.Size = new System.Drawing.Size(62, 20);
            this.txtCodeToD.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1812, 723);
            this.Controls.Add(this.grpModificar);
            this.Controls.Add(this.grpBoxInsertar);
            this.Controls.Add(this.cmbCRUD);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxInsertar.ResumeLayout(false);
            this.grpBoxInsertar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInserciones)).EndInit();
            this.grpModificar.ResumeLayout(false);
            this.grpModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificar)).EndInit();
            this.grpBoxDelete.ResumeLayout(false);
            this.grpBoxDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCRUD;
        private System.Windows.Forms.GroupBox grpBoxInsertar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.RadioButton rdbInactivoI;
        private System.Windows.Forms.RadioButton rdbActivoI;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.TextBox txtDpi;
        private System.Windows.Forms.TextBox txtTelefonoTwo;
        private System.Windows.Forms.TextBox txtTelefonoOne;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCasada;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dgvInserciones;
        private System.Windows.Forms.GroupBox grpModificar;
        private System.Windows.Forms.TextBox txtEstadoU;
        private System.Windows.Forms.RadioButton rdbInactivoU;
        private System.Windows.Forms.RadioButton rdbActivoU;
        private System.Windows.Forms.TextBox txtDireccionU;
        private System.Windows.Forms.TextBox txtCasadaU;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCodeModificar;
        private System.Windows.Forms.Button btnSelectCodeUpdate;
        private System.Windows.Forms.DataGridView dgvModificar;
        private System.Windows.Forms.TextBox txtSearchU;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.CheckBox chkBox;
        private System.Windows.Forms.CheckBox chkCasadaU;
        private System.Windows.Forms.GroupBox grpBoxDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtpNacimientoD;
        private System.Windows.Forms.TextBox txtDireccionD;
        private System.Windows.Forms.TextBox txtSegundoApellidoD;
        private System.Windows.Forms.TextBox txtPrimerApellidoD;
        private System.Windows.Forms.TextBox txtSegundoNombreD;
        private System.Windows.Forms.TextBox txtPrimerNombreD;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelectDCode;
        private System.Windows.Forms.DataGridView dgvDelete;
        private System.Windows.Forms.TextBox txtSearchD;
        private System.Windows.Forms.TextBox txtCodeToD;
    }
}

