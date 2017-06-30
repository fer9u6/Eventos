namespace Eventos
{
    partial class Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.ContTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CedTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CorreoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NomTextBox = new System.Windows.Forms.TextBox();
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ContTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CedTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CorreoTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NomTextBox);
            this.groupBox1.Controls.Add(this.BotonAgregar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 669);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(850, 385);
            this.dataGridView1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Contacto";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ContTextBox
            // 
            this.ContTextBox.Location = new System.Drawing.Point(470, 109);
            this.ContTextBox.Name = "ContTextBox";
            this.ContTextBox.Size = new System.Drawing.Size(294, 20);
            this.ContTextBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cédula";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CedTextBox
            // 
            this.CedTextBox.Location = new System.Drawing.Point(470, 139);
            this.CedTextBox.Name = "CedTextBox";
            this.CedTextBox.Size = new System.Drawing.Size(294, 20);
            this.CedTextBox.TabIndex = 16;
            this.CedTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Correo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CorreoTextBox
            // 
            this.CorreoTextBox.Location = new System.Drawing.Point(90, 139);
            this.CorreoTextBox.Name = "CorreoTextBox";
            this.CorreoTextBox.Size = new System.Drawing.Size(284, 20);
            this.CorreoTextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 47);
            this.label4.TabIndex = 8;
            this.label4.Text = "Crear proveedor";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NomTextBox
            // 
            this.NomTextBox.Location = new System.Drawing.Point(90, 108);
            this.NomTextBox.Name = "NomTextBox";
            this.NomTextBox.Size = new System.Drawing.Size(284, 20);
            this.NomTextBox.TabIndex = 5;
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.Location = new System.Drawing.Point(747, 179);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(139, 23);
            this.BotonAgregar.TabIndex = 4;
            this.BotonAgregar.Text = "Agregar Proveedor";
            this.BotonAgregar.UseVisualStyleBackColor = true;
            this.BotonAgregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "<- Inicio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proveedores";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(924, 669);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Proveedor";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.Proveedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BotonAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CorreoTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ContTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}