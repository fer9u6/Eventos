namespace Eventos
{
    partial class ReporteClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteClientes));
            this.buttonReporte = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReporte
            // 
            this.buttonReporte.Location = new System.Drawing.Point(545, 288);
            this.buttonReporte.Name = "buttonReporte";
            this.buttonReporte.Size = new System.Drawing.Size(105, 23);
            this.buttonReporte.TabIndex = 0;
            this.buttonReporte.Text = "Generar Reporte";
            this.buttonReporte.UseVisualStyleBackColor = true;
            this.buttonReporte.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(403, 33);
            this.label3.TabIndex = 41;
            this.label3.Text = "Clientes con mayor cantidad de eventos";
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(30, 124);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.Size = new System.Drawing.Size(477, 187);
            this.dataGridViewClientes.TabIndex = 40;
            this.dataGridViewClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientes_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "<- Inicio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 345);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.buttonReporte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteClientes";
            this.Text = "Reporte";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReporteClientes_FormClosed);
            this.Load += new System.EventHandler(this.MejoresClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Button button2;
    }
}