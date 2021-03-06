
namespace WinApp.Vendedor
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grillaClientes = new System.Windows.Forms.DataGridView();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habilitado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnNoSeleccionar = new System.Windows.Forms.Button();
            this.inputFiltroNombre = new System.Windows.Forms.TextBox();
            this.lblFiltroNombre = new System.Windows.Forms.Label();
            this.lblFiltroDocumento = new System.Windows.Forms.Label();
            this.inputFiltroDocumento = new System.Windows.Forms.TextBox();
            this.inputFiltroEmail = new System.Windows.Forms.TextBox();
            this.lblFiltroEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(93, 391);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "btnModificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Location = new System.Drawing.Point(174, 391);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnHabilitar.TabIndex = 9;
            this.btnHabilitar.Text = "btnHabilitar";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 391);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "btnAgregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grillaClientes
            // 
            this.grillaClientes.AllowUserToAddRows = false;
            this.grillaClientes.AllowUserToDeleteRows = false;
            this.grillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoDocumento,
            this.NroDocumento,
            this.Nombre,
            this.Email,
            this.Telefono,
            this.Habilitado});
            this.grillaClientes.Location = new System.Drawing.Point(12, 38);
            this.grillaClientes.MultiSelect = false;
            this.grillaClientes.Name = "grillaClientes";
            this.grillaClientes.ReadOnly = true;
            this.grillaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaClientes.Size = new System.Drawing.Size(776, 347);
            this.grillaClientes.TabIndex = 7;
            this.grillaClientes.SelectionChanged += new System.EventHandler(this.grillaClientes_SelectionChanged);
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.DataPropertyName = "TipoDocumento";
            this.TipoDocumento.HeaderText = "TipoDocumento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            // 
            // NroDocumento
            // 
            this.NroDocumento.DataPropertyName = "NroDocumento";
            this.NroDocumento.HeaderText = "NroDocumento";
            this.NroDocumento.Name = "NroDocumento";
            this.NroDocumento.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Habilitado
            // 
            this.Habilitado.DataPropertyName = "Habilitado";
            this.Habilitado.HeaderText = "Habilitado";
            this.Habilitado.Name = "Habilitado";
            this.Habilitado.ReadOnly = true;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(713, 391);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 11;
            this.btnSeleccionar.Text = "btnSeleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnNoSeleccionar
            // 
            this.btnNoSeleccionar.Location = new System.Drawing.Point(632, 391);
            this.btnNoSeleccionar.Name = "btnNoSeleccionar";
            this.btnNoSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnNoSeleccionar.TabIndex = 12;
            this.btnNoSeleccionar.Text = "btnNoSeleccionar";
            this.btnNoSeleccionar.UseVisualStyleBackColor = true;
            this.btnNoSeleccionar.Click += new System.EventHandler(this.btnNoSeleccionar_Click);
            // 
            // inputFiltroNombre
            // 
            this.inputFiltroNombre.Location = new System.Drawing.Point(382, 12);
            this.inputFiltroNombre.Name = "inputFiltroNombre";
            this.inputFiltroNombre.Size = new System.Drawing.Size(100, 20);
            this.inputFiltroNombre.TabIndex = 16;
            this.inputFiltroNombre.TextChanged += new System.EventHandler(this.inputFiltroNombre_TextChanged);
            // 
            // lblFiltroNombre
            // 
            this.lblFiltroNombre.AutoSize = true;
            this.lblFiltroNombre.Location = new System.Drawing.Point(271, 15);
            this.lblFiltroNombre.Name = "lblFiltroNombre";
            this.lblFiltroNombre.Size = new System.Drawing.Size(76, 13);
            this.lblFiltroNombre.TabIndex = 15;
            this.lblFiltroNombre.Text = "lblFiltroNombre";
            // 
            // lblFiltroDocumento
            // 
            this.lblFiltroDocumento.AutoSize = true;
            this.lblFiltroDocumento.Location = new System.Drawing.Point(16, 15);
            this.lblFiltroDocumento.Name = "lblFiltroDocumento";
            this.lblFiltroDocumento.Size = new System.Drawing.Size(94, 13);
            this.lblFiltroDocumento.TabIndex = 14;
            this.lblFiltroDocumento.Text = "lblFiltroDocumento";
            // 
            // inputFiltroDocumento
            // 
            this.inputFiltroDocumento.Location = new System.Drawing.Point(134, 12);
            this.inputFiltroDocumento.Name = "inputFiltroDocumento";
            this.inputFiltroDocumento.Size = new System.Drawing.Size(100, 20);
            this.inputFiltroDocumento.TabIndex = 13;
            this.inputFiltroDocumento.TextChanged += new System.EventHandler(this.inputFiltroDocumento_TextChanged);
            // 
            // inputFiltroEmail
            // 
            this.inputFiltroEmail.Location = new System.Drawing.Point(623, 12);
            this.inputFiltroEmail.Name = "inputFiltroEmail";
            this.inputFiltroEmail.Size = new System.Drawing.Size(100, 20);
            this.inputFiltroEmail.TabIndex = 18;
            this.inputFiltroEmail.TextChanged += new System.EventHandler(this.inputFiltroEmail_TextChanged);
            // 
            // lblFiltroEmail
            // 
            this.lblFiltroEmail.AutoSize = true;
            this.lblFiltroEmail.Location = new System.Drawing.Point(516, 15);
            this.lblFiltroEmail.Name = "lblFiltroEmail";
            this.lblFiltroEmail.Size = new System.Drawing.Size(64, 13);
            this.lblFiltroEmail.TabIndex = 17;
            this.lblFiltroEmail.Text = "lblFiltroEmail";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.inputFiltroEmail);
            this.Controls.Add(this.lblFiltroEmail);
            this.Controls.Add(this.inputFiltroNombre);
            this.Controls.Add(this.lblFiltroNombre);
            this.Controls.Add(this.lblFiltroDocumento);
            this.Controls.Add(this.inputFiltroDocumento);
            this.Controls.Add(this.btnNoSeleccionar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grillaClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClientes_FormClosing);
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView grillaClientes;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnNoSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Habilitado;
        private System.Windows.Forms.TextBox inputFiltroNombre;
        private System.Windows.Forms.Label lblFiltroNombre;
        private System.Windows.Forms.Label lblFiltroDocumento;
        private System.Windows.Forms.TextBox inputFiltroDocumento;
        private System.Windows.Forms.TextBox inputFiltroEmail;
        private System.Windows.Forms.Label lblFiltroEmail;
    }
}