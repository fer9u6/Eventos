namespace Eventos
{
    partial class BuscarServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarServicios));
            this.label_nombre = new System.Windows.Forms.Label();
            this.comboBox_nombre = new System.Windows.Forms.ComboBox();
            this.label_titulo = new System.Windows.Forms.Label();
            this.label_filtro = new System.Windows.Forms.Label();
            this.linkLabel_servicios = new System.Windows.Forms.LinkLabel();
            this.textBox_filtro = new System.Windows.Forms.TextBox();
            this.button_buscar = new System.Windows.Forms.Button();
            this.dataGridView_buscar = new System.Windows.Forms.DataGridView();
            this.label_tuplas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(12, 51);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(44, 13);
            this.label_nombre.TabIndex = 0;
            this.label_nombre.Text = "Nombre";
            this.label_nombre.Click += new System.EventHandler(this.label_nombre_Click);
            // 
            // comboBox_nombre
            // 
            this.comboBox_nombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_nombre.FormattingEnabled = true;
            this.comboBox_nombre.Location = new System.Drawing.Point(62, 43);
            this.comboBox_nombre.Name = "comboBox_nombre";
            this.comboBox_nombre.Size = new System.Drawing.Size(121, 21);
            this.comboBox_nombre.TabIndex = 1;
            this.comboBox_nombre.SelectedIndexChanged += new System.EventHandler(this.comboBox_nombre_SelectedIndexChanged);
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(330, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(101, 26);
            this.label_titulo.TabIndex = 2;
            this.label_titulo.Text = "Servicios";
            this.label_titulo.Click += new System.EventHandler(this.label_titulo_Click);
            // 
            // label_filtro
            // 
            this.label_filtro.AutoSize = true;
            this.label_filtro.Location = new System.Drawing.Point(298, 51);
            this.label_filtro.Name = "label_filtro";
            this.label_filtro.Size = new System.Drawing.Size(67, 13);
            this.label_filtro.TabIndex = 3;
            this.label_filtro.Text = "Filtro general";
            this.label_filtro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_filtro.Click += new System.EventHandler(this.label_filtro_Click);
            // 
            // linkLabel_servicios
            // 
            this.linkLabel_servicios.AutoSize = true;
            this.linkLabel_servicios.Location = new System.Drawing.Point(559, 19);
            this.linkLabel_servicios.Name = "linkLabel_servicios";
            this.linkLabel_servicios.Size = new System.Drawing.Size(100, 13);
            this.linkLabel_servicios.TabIndex = 4;
            this.linkLabel_servicios.TabStop = true;
            this.linkLabel_servicios.Text = "Ir a agregar servicio";
            this.linkLabel_servicios.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_servicios_LinkClicked);
            // 
            // textBox_filtro
            // 
            this.textBox_filtro.Location = new System.Drawing.Point(371, 48);
            this.textBox_filtro.Name = "textBox_filtro";
            this.textBox_filtro.Size = new System.Drawing.Size(100, 20);
            this.textBox_filtro.TabIndex = 5;
            this.textBox_filtro.TextChanged += new System.EventHandler(this.textBox_filtro_TextChanged);
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(562, 45);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(75, 23);
            this.button_buscar.TabIndex = 6;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // dataGridView_buscar
            // 
            this.dataGridView_buscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_buscar.Location = new System.Drawing.Point(12, 115);
            this.dataGridView_buscar.Name = "dataGridView_buscar";
            this.dataGridView_buscar.Size = new System.Drawing.Size(647, 234);
            this.dataGridView_buscar.TabIndex = 7;
            this.dataGridView_buscar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label_tuplas
            // 
            this.label_tuplas.AutoSize = true;
            this.label_tuplas.Location = new System.Drawing.Point(12, 99);
            this.label_tuplas.Name = "label_tuplas";
            this.label_tuplas.Size = new System.Drawing.Size(50, 13);
            this.label_tuplas.TabIndex = 8;
            this.label_tuplas.Text = "Servicios";
            this.label_tuplas.Click += new System.EventHandler(this.label_tuplas_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "<- Inicio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BuscarServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_tuplas);
            this.Controls.Add(this.dataGridView_buscar);
            this.Controls.Add(this.button_buscar);
            this.Controls.Add(this.textBox_filtro);
            this.Controls.Add(this.linkLabel_servicios);
            this.Controls.Add(this.label_filtro);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.comboBox_nombre);
            this.Controls.Add(this.label_nombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarServicios";
            this.Text = "Buscar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BuscarServicios_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.ComboBox comboBox_nombre;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_filtro;
        private System.Windows.Forms.LinkLabel linkLabel_servicios;
        private System.Windows.Forms.TextBox textBox_filtro;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.DataGridView dataGridView_buscar;
        private System.Windows.Forms.Label label_tuplas;
        private System.Windows.Forms.Button button1;
    }
}