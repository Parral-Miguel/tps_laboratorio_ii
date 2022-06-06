
namespace GomeriaDatos
{
    partial class FormGomeria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnInforme = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.cmbTrabajo = new System.Windows.Forms.ComboBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbTamanio = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTamanio = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.rtbDatos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(33, 385);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(227, 62);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(33, 541);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(227, 57);
            this.btnInforme.TabIndex = 1;
            this.btnInforme.Text = "Informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(33, 466);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(227, 56);
            this.btnQuitar.TabIndex = 2;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // cmbTrabajo
            // 
            this.cmbTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrabajo.FormattingEnabled = true;
            this.cmbTrabajo.Items.AddRange(new object[] {
            "Cambio",
            "Mantenimiento",
            "Compra",
            "Chequeo"});
            this.cmbTrabajo.Location = new System.Drawing.Point(33, 157);
            this.cmbTrabajo.Name = "cmbTrabajo";
            this.cmbTrabajo.Size = new System.Drawing.Size(284, 23);
            this.cmbTrabajo.TabIndex = 3;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(33, 64);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(284, 23);
            this.txtCliente.TabIndex = 5;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.Location = new System.Drawing.Point(33, 19);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(72, 28);
            this.lblCliente.TabIndex = 6;
            this.lblCliente.Text = "Cliente";
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOperacion.Location = new System.Drawing.Point(33, 104);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(80, 30);
            this.lblOperacion.TabIndex = 7;
            this.lblOperacion.Text = "Trabajo";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Fate",
            "Goodyear",
            "Michelin",
            "Pirelli"});
            this.cmbMarca.Location = new System.Drawing.Point(33, 245);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(126, 23);
            this.cmbMarca.TabIndex = 8;
            // 
            // cmbTamanio
            // 
            this.cmbTamanio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTamanio.FormattingEnabled = true;
            this.cmbTamanio.Items.AddRange(new object[] {
            "Camion",
            "Sedan",
            "Ciclomotor"});
            this.cmbTamanio.Location = new System.Drawing.Point(192, 245);
            this.cmbTamanio.Name = "cmbTamanio";
            this.cmbTamanio.Size = new System.Drawing.Size(125, 23);
            this.cmbTamanio.TabIndex = 9;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(33, 212);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(48, 15);
            this.lblMarca.TabIndex = 10;
            this.lblMarca.Text = "Modelo";
            // 
            // lblTamanio
            // 
            this.lblTamanio.AutoSize = true;
            this.lblTamanio.Location = new System.Drawing.Point(192, 212);
            this.lblTamanio.Name = "lblTamanio";
            this.lblTamanio.Size = new System.Drawing.Size(49, 15);
            this.lblTamanio.TabIndex = 11;
            this.lblTamanio.Text = "Tamaño";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(33, 310);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(63, 23);
            this.txtCantidad.TabIndex = 13;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(33, 292);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 15);
            this.lblCantidad.TabIndex = 14;
            this.lblCantidad.Text = "Cantidad";
            // 
            // rtbDatos
            // 
            this.rtbDatos.Location = new System.Drawing.Point(350, 19);
            this.rtbDatos.Name = "rtbDatos";
            this.rtbDatos.Size = new System.Drawing.Size(695, 592);
            this.rtbDatos.TabIndex = 15;
            this.rtbDatos.Text = "";
            // 
            // FormGomeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 623);
            this.Controls.Add(this.rtbDatos);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblTamanio);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cmbTamanio);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.cmbTrabajo);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.btnAgregar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGomeria";
            this.Text = "Gomeria Parral 2C";
            this.Load += new System.EventHandler(this.FormGomeria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.ComboBox cmbTrabajo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbTamanio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblTamanio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.RichTextBox rtbDatos;
    }
}

