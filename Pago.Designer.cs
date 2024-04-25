namespace LibreriaG
{
    partial class Pago
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
            this.label1 = new System.Windows.Forms.Label();
            this.byes = new System.Windows.Forms.Button();
            this.bnot = new System.Windows.Forms.Button();
            this.pagos = new System.Windows.Forms.Label();
            this.tipos = new System.Windows.Forms.Label();
            this.totalpaginas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desea efectuar el pago ?";
            // 
            // byes
            // 
            this.byes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byes.Location = new System.Drawing.Point(82, 145);
            this.byes.Name = "byes";
            this.byes.Size = new System.Drawing.Size(75, 23);
            this.byes.TabIndex = 1;
            this.byes.Text = "SI";
            this.byes.UseVisualStyleBackColor = true;
            this.byes.Click += new System.EventHandler(this.byes_Click);
            // 
            // bnot
            // 
            this.bnot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnot.Location = new System.Drawing.Point(182, 145);
            this.bnot.Name = "bnot";
            this.bnot.Size = new System.Drawing.Size(75, 23);
            this.bnot.TabIndex = 2;
            this.bnot.Text = "NO";
            this.bnot.UseVisualStyleBackColor = true;
            this.bnot.Click += new System.EventHandler(this.bnot_Click);
            // 
            // pagos
            // 
            this.pagos.AutoSize = true;
            this.pagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagos.Location = new System.Drawing.Point(133, 96);
            this.pagos.Name = "pagos";
            this.pagos.Size = new System.Drawing.Size(54, 20);
            this.pagos.TabIndex = 3;
            this.pagos.Text = "00.00";
            // 
            // tipos
            // 
            this.tipos.AutoSize = true;
            this.tipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipos.Location = new System.Drawing.Point(125, 34);
            this.tipos.Name = "tipos";
            this.tipos.Size = new System.Drawing.Size(22, 16);
            this.tipos.TabIndex = 4;
            this.tipos.Text = "---";
            // 
            // totalpaginas
            // 
            this.totalpaginas.AutoSize = true;
            this.totalpaginas.Location = new System.Drawing.Point(134, 69);
            this.totalpaginas.Name = "totalpaginas";
            this.totalpaginas.Size = new System.Drawing.Size(13, 13);
            this.totalpaginas.TabIndex = 5;
            this.totalpaginas.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total apagar $:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "cantidad de paginas ";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(282, 8);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(34, 13);
            this.date.TabIndex = 8;
            this.date.Text = "fecha";
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 177);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalpaginas);
            this.Controls.Add(this.tipos);
            this.Controls.Add(this.pagos);
            this.Controls.Add(this.bnot);
            this.Controls.Add(this.byes);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Pago";
            this.Text = "Pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button byes;
        private System.Windows.Forms.Button bnot;
        private System.Windows.Forms.Label pagos;
        private System.Windows.Forms.Label tipos;
        private System.Windows.Forms.Label totalpaginas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label date;
    }
}