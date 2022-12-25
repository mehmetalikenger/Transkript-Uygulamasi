namespace TranskriptUygulamasi
{
    partial class Islemler
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
            this.btnTranskript = new System.Windows.Forms.Button();
            this.btnDersSil = new System.Windows.Forms.Button();
            this.btnDersGuncelle = new System.Windows.Forms.Button();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTranskript
            // 
            this.btnTranskript.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTranskript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranskript.Location = new System.Drawing.Point(35, 118);
            this.btnTranskript.Name = "btnTranskript";
            this.btnTranskript.Size = new System.Drawing.Size(308, 35);
            this.btnTranskript.TabIndex = 11;
            this.btnTranskript.Text = "Transkript";
            this.btnTranskript.UseVisualStyleBackColor = false;
            this.btnTranskript.Click += new System.EventHandler(this.btnTranskript_Click);
            // 
            // btnDersSil
            // 
            this.btnDersSil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDersSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDersSil.Location = new System.Drawing.Point(260, 50);
            this.btnDersSil.Name = "btnDersSil";
            this.btnDersSil.Size = new System.Drawing.Size(83, 35);
            this.btnDersSil.TabIndex = 10;
            this.btnDersSil.Text = "Ders Sil";
            this.btnDersSil.UseVisualStyleBackColor = false;
            this.btnDersSil.Click += new System.EventHandler(this.btnDersSil_Click);
            // 
            // btnDersGuncelle
            // 
            this.btnDersGuncelle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDersGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDersGuncelle.Location = new System.Drawing.Point(144, 50);
            this.btnDersGuncelle.Name = "btnDersGuncelle";
            this.btnDersGuncelle.Size = new System.Drawing.Size(91, 35);
            this.btnDersGuncelle.TabIndex = 9;
            this.btnDersGuncelle.Text = "Ders Guncelle";
            this.btnDersGuncelle.UseVisualStyleBackColor = false;
            this.btnDersGuncelle.Click += new System.EventHandler(this.btnDersGuncelle_Click);
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDersEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDersEkle.Location = new System.Drawing.Point(35, 50);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(83, 35);
            this.btnDersEkle.TabIndex = 8;
            this.btnDersEkle.Text = "Ders Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = false;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // Islemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 203);
            this.Controls.Add(this.btnTranskript);
            this.Controls.Add(this.btnDersSil);
            this.Controls.Add(this.btnDersGuncelle);
            this.Controls.Add(this.btnDersEkle);
            this.Name = "Islemler";
            this.Text = "Islemler";
            this.Load += new System.EventHandler(this.Islemler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTranskript;
        private System.Windows.Forms.Button btnDersSil;
        private System.Windows.Forms.Button btnDersGuncelle;
        private System.Windows.Forms.Button btnDersEkle;
    }
}