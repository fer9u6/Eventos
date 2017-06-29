namespace Eventos
{
    partial class AgregarClientePJ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarClientePJ));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.idcliente = new System.Windows.Forms.Label();
            this.con = new System.Windows.Forms.TextBox();
            this.cor = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.ced = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contacto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idc);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.idcliente);
            this.groupBox1.Controls.Add(this.con);
            this.groupBox1.Controls.Add(this.cor);
            this.groupBox1.Controls.Add(this.nom);
            this.groupBox1.Controls.Add(this.ced);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 220);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // idc
            // 
            this.idc.Location = new System.Drawing.Point(99, 149);
            this.idc.Name = "idc";
            this.idc.Size = new System.Drawing.Size(247, 22);
            this.idc.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(271, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idcliente
            // 
            this.idcliente.AutoSize = true;
            this.idcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idcliente.Location = new System.Drawing.Point(19, 156);
            this.idcliente.Name = "idcliente";
            this.idcliente.Size = new System.Drawing.Size(55, 15);
            this.idcliente.TabIndex = 8;
            this.idcliente.Text = "IdCliente";
            // 
            // con
            // 
            this.con.Location = new System.Drawing.Point(99, 121);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(247, 22);
            this.con.TabIndex = 7;
            // 
            // cor
            // 
            this.cor.Location = new System.Drawing.Point(99, 93);
            this.cor.Name = "cor";
            this.cor.Size = new System.Drawing.Size(247, 22);
            this.cor.TabIndex = 6;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(99, 65);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(247, 22);
            this.nom.TabIndex = 5;
            // 
            // ced
            // 
            this.ced.Location = new System.Drawing.Point(99, 37);
            this.ced.Name = "ced";
            this.ced.Size = new System.Drawing.Size(247, 22);
            this.ced.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "<- Inicio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AgregarClientePJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 271);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarClientePJ";
            this.Text = "Agregar Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AgregarClientePJ_FormClosed);
            this.Load += new System.EventHandler(this.AgregarClientePJ_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox con;
        private System.Windows.Forms.TextBox cor;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox ced;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idc;
        private System.Windows.Forms.Label idcliente;
        private System.Windows.Forms.Button button2;
    }
}