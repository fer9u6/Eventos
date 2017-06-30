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
            this.label_filtro = new System.Windows.Forms.Label();
            this.textBox_filtro = new System.Windows.Forms.TextBox();
            this.button_buscar = new System.Windows.Forms.Button();
            this.dataGridView_buscar = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(17, 104);
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
            this.comboBox_nombre.Location = new System.Drawing.Point(67, 101);
            this.comboBox_nombre.Name = "comboBox_nombre";
            this.comboBox_nombre.Size = new System.Drawing.Size(121, 21);
            this.comboBox_nombre.TabIndex = 1;
            this.comboBox_nombre.SelectedIndexChanged += new System.EventHandler(this.comboBox_nombre_SelectedIndexChanged);
            // 
            // label_filtro
            // 
            this.label_filtro.AutoSize = true;
            this.label_filtro.Location = new System.Drawing.Point(303, 104);
            this.label_filtro.Name = "label_filtro";
            this.label_filtro.Size = new System.Drawing.Size(67, 13);
            this.label_filtro.TabIndex = 3;
            this.label_filtro.Text = "Filtro general";
            this.label_filtro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_filtro.Click += new System.EventHandler(this.label_filtro_Click);
            // 
            // textBox_filtro
            // 
            this.textBox_filtro.Location = new System.Drawing.Point(376, 101);
            this.textBox_filtro.Name = "textBox_filtro";
            this.textBox_filtro.Size = new System.Drawing.Size(100, 20);
            this.textBox_filtro.TabIndex = 5;
            this.textBox_filtro.TextChanged += new System.EventHandler(this.textBox_filtro_TextChanged);
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(567, 98);
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
            this.dataGridView_buscar.Location = new System.Drawing.Point(15, 189);
            this.dataGridView_buscar.Name = "dataGridView_buscar";
            this.dataGridView_buscar.Size = new System.Drawing.Size(647, 234);
            this.dataGridView_buscar.TabIndex = 7;
            this.dataGridView_buscar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 47);
            this.label10.TabIndex = 35;
            this.label10.Text = "Servicios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 47);
            this.label1.TabIndex = 36;
            this.label1.Text = "Buscar Servicios";
            // 
            // BuscarServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_buscar);
            this.Controls.Add(this.button_buscar);
            this.Controls.Add(this.textBox_filtro);
            this.Controls.Add(this.label_filtro);
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
        private System.Windows.Forms.Label label_filtro;
        private System.Windows.Forms.TextBox textBox_filtro;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.DataGridView dataGridView_buscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
    }
}