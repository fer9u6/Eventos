namespace Eventos
{
    partial class EliminarServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarServicios));
            this.label_titulo = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.comboBox_nombre = new System.Windows.Forms.ComboBox();
            this.linkLabel_agregar = new System.Windows.Forms.LinkLabel();
            this.label_tuplas = new System.Windows.Forms.Label();
            this.dataGridView_eliminar = new System.Windows.Forms.DataGridView();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_eliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(280, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(101, 26);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Servicios";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(12, 57);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(44, 13);
            this.label_nombre.TabIndex = 1;
            this.label_nombre.Text = "Nombre";
            // 
            // comboBox_nombre
            // 
            this.comboBox_nombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_nombre.FormattingEnabled = true;
            this.comboBox_nombre.Location = new System.Drawing.Point(62, 49);
            this.comboBox_nombre.Name = "comboBox_nombre";
            this.comboBox_nombre.Size = new System.Drawing.Size(121, 21);
            this.comboBox_nombre.TabIndex = 2;
            this.comboBox_nombre.SelectedIndexChanged += new System.EventHandler(this.comboBox_nombre_SelectedIndexChanged);
            // 
            // linkLabel_agregar
            // 
            this.linkLabel_agregar.AutoSize = true;
            this.linkLabel_agregar.Location = new System.Drawing.Point(539, 9);
            this.linkLabel_agregar.Name = "linkLabel_agregar";
            this.linkLabel_agregar.Size = new System.Drawing.Size(105, 13);
            this.linkLabel_agregar.TabIndex = 5;
            this.linkLabel_agregar.TabStop = true;
            this.linkLabel_agregar.Text = "Ir a agregar servicios";
            this.linkLabel_agregar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_agregar_LinkClicked);
            // 
            // label_tuplas
            // 
            this.label_tuplas.AutoSize = true;
            this.label_tuplas.Location = new System.Drawing.Point(12, 105);
            this.label_tuplas.Name = "label_tuplas";
            this.label_tuplas.Size = new System.Drawing.Size(50, 13);
            this.label_tuplas.TabIndex = 6;
            this.label_tuplas.Text = "Servicios";
            // 
            // dataGridView_eliminar
            // 
            this.dataGridView_eliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_eliminar.Location = new System.Drawing.Point(12, 121);
            this.dataGridView_eliminar.Name = "dataGridView_eliminar";
            this.dataGridView_eliminar.Size = new System.Drawing.Size(632, 238);
            this.dataGridView_eliminar.TabIndex = 7;
            // 
            // button_eliminar
            // 
            this.button_eliminar.Location = new System.Drawing.Point(198, 49);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(74, 23);
            this.button_eliminar.TabIndex = 9;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "<- Inicio";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EliminarServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.dataGridView_eliminar);
            this.Controls.Add(this.label_tuplas);
            this.Controls.Add(this.linkLabel_agregar);
            this.Controls.Add(this.comboBox_nombre);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.label_titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EliminarServicios";
            this.Text = "Eliminar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EliminarServicios_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_eliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.ComboBox comboBox_nombre;
        private System.Windows.Forms.LinkLabel linkLabel_agregar;
        private System.Windows.Forms.Label label_tuplas;
        private System.Windows.Forms.DataGridView dataGridView_eliminar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button1;
    }
}