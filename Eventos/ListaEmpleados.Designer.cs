namespace Eventos
{
    partial class ListaEmpleados
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
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.comboBox1Ape = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxCed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(46, 106);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(565, 244);
            this.dataGridViewEmpleados.TabIndex = 11;
            this.dataGridViewEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpleados_CellContentClick);
            // 
            // comboBox1Ape
            // 
            this.comboBox1Ape.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1Ape.FormattingEnabled = true;
            this.comboBox1Ape.Location = new System.Drawing.Point(93, 37);
            this.comboBox1Ape.Name = "comboBox1Ape";
            this.comboBox1Ape.Size = new System.Drawing.Size(121, 23);
            this.comboBox1Ape.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCed
            // 
            this.textBoxCed.Location = new System.Drawing.Point(350, 38);
            this.textBoxCed.Name = "textBoxCed";
            this.textBoxCed.Size = new System.Drawing.Size(100, 20);
            this.textBoxCed.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cedula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Apellido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(651, 335);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(34, 15);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Atras";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ListaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 392);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dataGridViewEmpleados);
            this.Controls.Add(this.comboBox1Ape);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListaEmpleados";
            this.Text = "ListaEmpleados";
            this.Load += new System.EventHandler(this.ListaEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        private System.Windows.Forms.ComboBox comboBox1Ape;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxCed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}