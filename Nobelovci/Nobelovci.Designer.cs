namespace Nobelovci
{
    partial class Nobelovci
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nobelovci));
            this.leta = new System.Windows.Forms.ComboBox();
            this.zmagovalci = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.podrocja = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.isci = new System.Windows.Forms.Button();
            this.izpis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isciLeto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leta
            // 
            this.leta.FormattingEnabled = true;
            this.leta.Location = new System.Drawing.Point(63, 356);
            this.leta.Margin = new System.Windows.Forms.Padding(6);
            this.leta.Name = "leta";
            this.leta.Size = new System.Drawing.Size(238, 33);
            this.leta.TabIndex = 0;
            // 
            // zmagovalci
            // 
            this.zmagovalci.FormattingEnabled = true;
            this.zmagovalci.Location = new System.Drawing.Point(63, 514);
            this.zmagovalci.Margin = new System.Windows.Forms.Padding(6);
            this.zmagovalci.Name = "zmagovalci";
            this.zmagovalci.Size = new System.Drawing.Size(238, 33);
            this.zmagovalci.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(748, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1432, 1124);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // podrocja
            // 
            this.podrocja.FormattingEnabled = true;
            this.podrocja.Location = new System.Drawing.Point(63, 75);
            this.podrocja.Name = "podrocja";
            this.podrocja.Size = new System.Drawing.Size(238, 200);
            this.podrocja.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // isci
            // 
            this.isci.Location = new System.Drawing.Point(400, 226);
            this.isci.Name = "isci";
            this.isci.Size = new System.Drawing.Size(238, 49);
            this.isci.TabIndex = 9;
            this.isci.Text = "Išči nagrajenca";
            this.isci.UseVisualStyleBackColor = true;
            this.isci.Click += new System.EventHandler(this.isci_Click);
            // 
            // izpis
            // 
            this.izpis.AutoSize = true;
            this.izpis.Location = new System.Drawing.Point(58, 611);
            this.izpis.Name = "izpis";
            this.izpis.Size = new System.Drawing.Size(0, 25);
            this.izpis.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Izberi področje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Izberi leto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Izberi nagrajenca:";
            // 
            // isciLeto
            // 
            this.isciLeto.Location = new System.Drawing.Point(400, 338);
            this.isciLeto.Name = "isciLeto";
            this.isciLeto.Size = new System.Drawing.Size(238, 51);
            this.isciLeto.TabIndex = 14;
            this.isciLeto.Text = "Išči leto in področje";
            this.isciLeto.UseVisualStyleBackColor = true;
            this.isciLeto.Click += new System.EventHandler(this.isciLeto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 945);
            this.Controls.Add(this.isciLeto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.izpis);
            this.Controls.Add(this.isci);
            this.Controls.Add(this.podrocja);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.zmagovalci);
            this.Controls.Add(this.leta);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox leta;
        private System.Windows.Forms.ComboBox zmagovalci;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox podrocja;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.Button isci;
        private System.Windows.Forms.Label izpis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button isciLeto;
    }
}

