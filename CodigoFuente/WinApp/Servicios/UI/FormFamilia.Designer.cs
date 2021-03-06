
namespace Servicios.UI
{
    partial class FormFamilia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFamilia));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.grillaHijos = new System.Windows.Forms.DataGridView();
            this.lblHijos = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.grillaDisponibles = new System.Windows.Forms.DataGridView();
            this.lblDisponibles = new System.Windows.Forms.Label();
            this.Nombre_H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadHijos_H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadHijos_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillaHijos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(519, 255);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(12, 25);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(237, 20);
            this.inputNombre.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "lblNombre";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(643, 255);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "btnGrabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // grillaHijos
            // 
            this.grillaHijos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaHijos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_H,
            this.CantidadHijos_H});
            this.grillaHijos.Location = new System.Drawing.Point(12, 80);
            this.grillaHijos.Name = "grillaHijos";
            this.grillaHijos.Size = new System.Drawing.Size(325, 150);
            this.grillaHijos.TabIndex = 10;
            this.grillaHijos.SelectionChanged += new System.EventHandler(this.grillaHijos_SelectionChanged);
            // 
            // lblHijos
            // 
            this.lblHijos.AutoSize = true;
            this.lblHijos.Location = new System.Drawing.Point(12, 64);
            this.lblHijos.Name = "lblHijos";
            this.lblHijos.Size = new System.Drawing.Size(40, 13);
            this.lblHijos.TabIndex = 11;
            this.lblHijos.Text = "lblHijos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(343, 115);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(44, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "<<";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(343, 176);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(44, 23);
            this.btnQuitar.TabIndex = 13;
            this.btnQuitar.Text = ">>";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // grillaDisponibles
            // 
            this.grillaDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_D,
            this.CantidadHijos_D});
            this.grillaDisponibles.Location = new System.Drawing.Point(393, 80);
            this.grillaDisponibles.Name = "grillaDisponibles";
            this.grillaDisponibles.Size = new System.Drawing.Size(325, 150);
            this.grillaDisponibles.TabIndex = 14;
            this.grillaDisponibles.SelectionChanged += new System.EventHandler(this.grillaDisponibles_SelectionChanged);
            // 
            // lblDisponibles
            // 
            this.lblDisponibles.AutoSize = true;
            this.lblDisponibles.Location = new System.Drawing.Point(309, 61);
            this.lblDisponibles.Name = "lblDisponibles";
            this.lblDisponibles.Size = new System.Drawing.Size(71, 13);
            this.lblDisponibles.TabIndex = 15;
            this.lblDisponibles.Text = "lblDisponibles";
            // 
            // Nombre_H
            // 
            this.Nombre_H.DataPropertyName = "Nombre";
            this.Nombre_H.HeaderText = "Nombre";
            this.Nombre_H.Name = "Nombre_H";
            this.Nombre_H.ReadOnly = true;
            // 
            // CantidadHijos_H
            // 
            this.CantidadHijos_H.DataPropertyName = "CantidadHijos";
            this.CantidadHijos_H.HeaderText = "(Sub)Permisos";
            this.CantidadHijos_H.Name = "CantidadHijos_H";
            this.CantidadHijos_H.ReadOnly = true;
            // 
            // Nombre_D
            // 
            this.Nombre_D.DataPropertyName = "Nombre";
            this.Nombre_D.HeaderText = "Nombre";
            this.Nombre_D.Name = "Nombre_D";
            this.Nombre_D.ReadOnly = true;
            // 
            // CantidadHijos_D
            // 
            this.CantidadHijos_D.DataPropertyName = "CantidadHijos";
            this.CantidadHijos_D.HeaderText = "(Sub)Permisos";
            this.CantidadHijos_D.Name = "CantidadHijos_D";
            this.CantidadHijos_D.ReadOnly = true;
            // 
            // FormFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 301);
            this.Controls.Add(this.lblDisponibles);
            this.Controls.Add(this.grillaDisponibles);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblHijos);
            this.Controls.Add(this.grillaHijos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.inputNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnGrabar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFamilia";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFamilia_FormClosing);
            this.Load += new System.EventHandler(this.FormFamilia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaHijos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.DataGridView grillaHijos;
        private System.Windows.Forms.Label lblHijos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridView grillaDisponibles;
        private System.Windows.Forms.Label lblDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_H;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadHijos_H;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_D;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadHijos_D;
    }
}