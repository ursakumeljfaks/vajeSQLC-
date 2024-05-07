namespace Filmi
{
    partial class Filmi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filmi));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.izpisReziser = new System.Windows.Forms.Button();
            this.izpisLeto = new System.Windows.Forms.Button();
            this.izpisNaslov = new System.Windows.Forms.Button();
            this.reziserji = new System.Windows.Forms.ComboBox();
            this.leta = new System.Windows.Forms.ComboBox();
            this.naslovi = new System.Windows.Forms.ComboBox();
            this.izpis = new System.Windows.Forms.Label();
            this.letaOd = new System.Windows.Forms.TextBox();
            this.letaDo = new System.Windows.Forms.TextBox();
            this.gumbLeta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.top10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(192, 103);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(360, 360);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(883, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "DOBORDOŠLI V BAZI FILMOV";
            // 
            // izpisReziser
            // 
            this.izpisReziser.Location = new System.Drawing.Point(956, 242);
            this.izpisReziser.Name = "izpisReziser";
            this.izpisReziser.Size = new System.Drawing.Size(343, 62);
            this.izpisReziser.TabIndex = 3;
            this.izpisReziser.Text = "Išči glede na izbranega režiserja";
            this.izpisReziser.UseVisualStyleBackColor = true;
            this.izpisReziser.Click += new System.EventHandler(this.izpisReziser_Click);
            // 
            // izpisLeto
            // 
            this.izpisLeto.Location = new System.Drawing.Point(956, 167);
            this.izpisLeto.Name = "izpisLeto";
            this.izpisLeto.Size = new System.Drawing.Size(343, 60);
            this.izpisLeto.TabIndex = 4;
            this.izpisLeto.Text = "Išči glede na izbrano leto";
            this.izpisLeto.UseVisualStyleBackColor = true;
            this.izpisLeto.Click += new System.EventHandler(this.izpisLeto_Click);
            // 
            // izpisNaslov
            // 
            this.izpisNaslov.Location = new System.Drawing.Point(956, 321);
            this.izpisNaslov.Name = "izpisNaslov";
            this.izpisNaslov.Size = new System.Drawing.Size(343, 62);
            this.izpisNaslov.TabIndex = 5;
            this.izpisNaslov.Text = "Išči glede na izbran naslov";
            this.izpisNaslov.UseVisualStyleBackColor = true;
            this.izpisNaslov.Click += new System.EventHandler(this.izpisNaslov_Click);
            // 
            // reziserji
            // 
            this.reziserji.FormattingEnabled = true;
            this.reziserji.Location = new System.Drawing.Point(605, 258);
            this.reziserji.Name = "reziserji";
            this.reziserji.Size = new System.Drawing.Size(271, 33);
            this.reziserji.TabIndex = 6;
            // 
            // leta
            // 
            this.leta.FormattingEnabled = true;
            this.leta.Location = new System.Drawing.Point(605, 167);
            this.leta.Name = "leta";
            this.leta.Size = new System.Drawing.Size(271, 33);
            this.leta.TabIndex = 7;
            // 
            // naslovi
            // 
            this.naslovi.FormattingEnabled = true;
            this.naslovi.Location = new System.Drawing.Point(605, 350);
            this.naslovi.Name = "naslovi";
            this.naslovi.Size = new System.Drawing.Size(271, 33);
            this.naslovi.TabIndex = 8;
            // 
            // izpis
            // 
            this.izpis.AutoSize = true;
            this.izpis.Location = new System.Drawing.Point(192, 591);
            this.izpis.Name = "izpis";
            this.izpis.Size = new System.Drawing.Size(0, 25);
            this.izpis.TabIndex = 9;
            // 
            // letaOd
            // 
            this.letaOd.Location = new System.Drawing.Point(1402, 167);
            this.letaOd.Name = "letaOd";
            this.letaOd.Size = new System.Drawing.Size(100, 31);
            this.letaOd.TabIndex = 10;
            // 
            // letaDo
            // 
            this.letaDo.Location = new System.Drawing.Point(1570, 164);
            this.letaDo.Name = "letaDo";
            this.letaDo.Size = new System.Drawing.Size(100, 31);
            this.letaDo.TabIndex = 11;
            // 
            // gumbLeta
            // 
            this.gumbLeta.Location = new System.Drawing.Point(1712, 158);
            this.gumbLeta.Name = "gumbLeta";
            this.gumbLeta.Size = new System.Drawing.Size(114, 48);
            this.gumbLeta.TabIndex = 12;
            this.gumbLeta.Text = "Išči filme";
            this.gumbLeta.UseVisualStyleBackColor = true;
            this.gumbLeta.Click += new System.EventHandler(this.gumbLeta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1345, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Od:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1518, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Do:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Leta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Režiserji:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(600, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Naslovi:";
            // 
            // top10
            // 
            this.top10.Location = new System.Drawing.Point(1350, 242);
            this.top10.Name = "top10";
            this.top10.Size = new System.Drawing.Size(343, 60);
            this.top10.TabIndex = 18;
            this.top10.Text = "Top 10 filmov vseh let";
            this.top10.UseVisualStyleBackColor = true;
            this.top10.Click += new System.EventHandler(this.top10_Click);
            // 
            // Filmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2055, 1099);
            this.Controls.Add(this.top10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gumbLeta);
            this.Controls.Add(this.letaDo);
            this.Controls.Add(this.letaOd);
            this.Controls.Add(this.izpis);
            this.Controls.Add(this.naslovi);
            this.Controls.Add(this.leta);
            this.Controls.Add(this.reziserji);
            this.Controls.Add(this.izpisNaslov);
            this.Controls.Add(this.izpisLeto);
            this.Controls.Add(this.izpisReziser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Name = "Filmi";
            this.Text = "Filmi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button izpisReziser;
        private System.Windows.Forms.Button izpisLeto;
        private System.Windows.Forms.Button izpisNaslov;
        private System.Windows.Forms.ComboBox reziserji;
        private System.Windows.Forms.ComboBox leta;
        private System.Windows.Forms.ComboBox naslovi;
        private System.Windows.Forms.Label izpis;
        private System.Windows.Forms.TextBox letaOd;
        private System.Windows.Forms.TextBox letaDo;
        private System.Windows.Forms.Button gumbLeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button top10;
    }
}

