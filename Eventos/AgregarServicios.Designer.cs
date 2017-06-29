namespace Eventos
{
    partial class AgregarServicios
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
            this.button_guardar = new System.Windows.Forms.Button();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_detalle = new System.Windows.Forms.Label();
            this.label_precio = new System.Windows.Forms.Label();
            this.label_costo = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_detalle = new System.Windows.Forms.TextBox();
            this.textBox_precio = new System.Windows.Forms.TextBox();
            this.textBox_costo = new System.Windows.Forms.TextBox();
            this.linkLabel_buscar = new System.Windows.Forms.LinkLabel();
            this.linkLabel_eliminar_servicio = new System.Windows.Forms.LinkLabel();
            this.label_titulo = new System.Windows.Forms.Label();
            this.label_proveedor = new System.Windows.Forms.Label();
            this.comboBox_prov = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_guardar
            // 
            this.button_guardar.Location = new System.Drawing.Point(327, 208);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(75, 23);
            this.button_guardar.TabIndex = 0;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(12, 53);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(44, 13);
            this.label_nombre.TabIndex = 1;
            this.label_nombre.Text = "Nombre";
            // 
            // label_detalle
            // 
            this.label_detalle.AutoSize = true;
            this.label_detalle.Location = new System.Drawing.Point(12, 79);
            this.label_detalle.Name = "label_detalle";
            this.label_detalle.Size = new System.Drawing.Size(40, 13);
            this.label_detalle.TabIndex = 2;
            this.label_detalle.Text = "Detalle";
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.Location = new System.Drawing.Point(12, 103);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(37, 13);
            this.label_precio.TabIndex = 3;
            this.label_precio.Text = "Precio";
            // 
            // label_costo
            // 
            this.label_costo.AutoSize = true;
            this.label_costo.Location = new System.Drawing.Point(12, 131);
            this.label_costo.Name = "label_costo";
            this.label_costo.Size = new System.Drawing.Size(34, 13);
            this.label_costo.TabIndex = 4;
            this.label_costo.Text = "Costo";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(88, 46);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombre.TabIndex = 5;
            this.textBox_nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_detalle
            // 
            this.textBox_detalle.Location = new System.Drawing.Point(88, 72);
            this.textBox_detalle.Name = "textBox_detalle";
            this.textBox_detalle.Size = new System.Drawing.Size(100, 20);
            this.textBox_detalle.TabIndex = 6;
            this.textBox_detalle.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_precio
            // 
            this.textBox_precio.Location = new System.Drawing.Point(88, 98);
            this.textBox_precio.Name = "textBox_precio";
            this.textBox_precio.Size = new System.Drawing.Size(100, 20);
            this.textBox_precio.TabIndex = 7;
            // 
            // textBox_costo
            // 
            this.textBox_costo.Location = new System.Drawing.Point(88, 124);
            this.textBox_costo.Name = "textBox_costo";
            this.textBox_costo.Size = new System.Drawing.Size(100, 20);
            this.textBox_costo.TabIndex = 8;
            // 
            // linkLabel_buscar
            // 
            this.linkLabel_buscar.AutoSize = true;
            this.linkLabel_buscar.Location = new System.Drawing.Point(12, 179);
            this.linkLabel_buscar.Name = "linkLabel_buscar";
            this.linkLabel_buscar.Size = new System.Drawing.Size(96, 13);
            this.linkLabel_buscar.TabIndex = 9;
            this.linkLabel_buscar.TabStop = true;
            this.linkLabel_buscar.Text = "Ir a buscar servicio";
            this.linkLabel_buscar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_buscar_LinkClicked);
            // 
            // linkLabel_eliminar_servicio
            // 
            this.linkLabel_eliminar_servicio.AutoSize = true;
            this.linkLabel_eliminar_servicio.Location = new System.Drawing.Point(12, 208);
            this.linkLabel_eliminar_servicio.Name = "linkLabel_eliminar_servicio";
            this.linkLabel_eliminar_servicio.Size = new System.Drawing.Size(82, 13);
            this.linkLabel_eliminar_servicio.TabIndex = 10;
            this.linkLabel_eliminar_servicio.TabStop = true;
            this.linkLabel_eliminar_servicio.Text = "Eliminar servicio";
            this.linkLabel_eliminar_servicio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_eliminar_servicio_LinkClicked);
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_titulo.Location = new System.Drawing.Point(312, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(90, 26);
            this.label_titulo.TabIndex = 11;
            this.label_titulo.Text = "Servicio";
            this.label_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_titulo.Click += new System.EventHandler(this.label_titulo_Click);
            // 
            // label_proveedor
            // 
            this.label_proveedor.AutoSize = true;
            this.label_proveedor.Location = new System.Drawing.Point(213, 53);
            this.label_proveedor.Name = "label_proveedor";
            this.label_proveedor.Size = new System.Drawing.Size(56, 13);
            this.label_proveedor.TabIndex = 12;
            this.label_proveedor.Text = "Proveedor";
            // 
            // comboBox_prov
            // 
            this.comboBox_prov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_prov.FormattingEnabled = true;
            this.comboBox_prov.Location = new System.Drawing.Point(275, 53);
            this.comboBox_prov.Name = "comboBox_prov";
            this.comboBox_prov.Size = new System.Drawing.Size(121, 21);
            this.comboBox_prov.TabIndex = 13;
            this.comboBox_prov.SelectedIndexChanged += new System.EventHandler(this.comboBox_prov_SelectedIndexChanged);
            this.comboBox_prov.Click += new System.EventHandler(this.comboBox_prov_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "<- Inicio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgregarServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 243);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_prov);
            this.Controls.Add(this.label_proveedor);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.linkLabel_eliminar_servicio);
            this.Controls.Add(this.linkLabel_buscar);
            this.Controls.Add(this.textBox_costo);
            this.Controls.Add(this.textBox_precio);
            this.Controls.Add(this.textBox_detalle);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label_costo);
            this.Controls.Add(this.label_precio);
            this.Controls.Add(this.label_detalle);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.button_guardar);
            this.Name = "AgregarServicios";
            this.Text = "Servicios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AgregarServicios_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_detalle;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.Label label_costo;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_detalle;
        private System.Windows.Forms.TextBox textBox_precio;
        private System.Windows.Forms.TextBox textBox_costo;
        private System.Windows.Forms.LinkLabel linkLabel_buscar;
        private System.Windows.Forms.LinkLabel linkLabel_eliminar_servicio;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_proveedor;
        private System.Windows.Forms.ComboBox comboBox_prov;
        private System.Windows.Forms.Button button1;
    }
}