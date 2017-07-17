namespace Eventos
{
    partial class Reporte_Servicio
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
            this.button_inicio = new System.Windows.Forms.Button();
            this.dataGridView_servicios = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_servicios)).BeginInit();
            this.SuspendLayout();
            // 
            // button_inicio
            // 
            this.button_inicio.Location = new System.Drawing.Point(12, 12);
            this.button_inicio.Name = "button_inicio";
            this.button_inicio.Size = new System.Drawing.Size(75, 23);
            this.button_inicio.TabIndex = 0;
            this.button_inicio.Text = "<- Inicio";
            this.button_inicio.UseVisualStyleBackColor = true;
            this.button_inicio.Click += new System.EventHandler(this.button_inicio_Click);
            // 
            // dataGridView_servicios
            // 
            this.dataGridView_servicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_servicios.Location = new System.Drawing.Point(29, 106);
            this.dataGridView_servicios.Name = "dataGridView_servicios";
            this.dataGridView_servicios.Size = new System.Drawing.Size(471, 195);
            this.dataGridView_servicios.TabIndex = 1;
            this.dataGridView_servicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 33);
            this.label3.TabIndex = 42;
            this.label3.Text = "Servicios más contratados";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonReporte
            // 
            this.buttonReporte.Location = new System.Drawing.Point(545, 278);
            this.buttonReporte.Name = "buttonReporte";
            this.buttonReporte.Size = new System.Drawing.Size(105, 23);
            this.buttonReporte.TabIndex = 43;
            this.buttonReporte.Text = "Generar Reporte";
            this.buttonReporte.UseVisualStyleBackColor = true;
            this.buttonReporte.Click += new System.EventHandler(this.buttonReporte_Click);
            // 
            // Reporte_Servicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 345);
            this.Controls.Add(this.buttonReporte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_servicios);
            this.Controls.Add(this.button_inicio);
            this.Name = "Reporte_Servicio";
            this.Text = "Reporte_Servicio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_servicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_inicio;
        private System.Windows.Forms.DataGridView dataGridView_servicios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonReporte;
    }
}