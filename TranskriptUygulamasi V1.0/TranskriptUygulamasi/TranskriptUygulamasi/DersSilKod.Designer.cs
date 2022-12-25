namespace TranskriptUygulamasi
{
    partial class DersSilKod
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
            this.btnDevam = new System.Windows.Forms.Button();
            this.txtDersKod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDevam
            // 
            this.btnDevam.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDevam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevam.Location = new System.Drawing.Point(177, 88);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(80, 25);
            this.btnDevam.TabIndex = 5;
            this.btnDevam.Text = "Devam Et";
            this.btnDevam.UseVisualStyleBackColor = false;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // txtDersKod
            // 
            this.txtDersKod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDersKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDersKod.Location = new System.Drawing.Point(118, 47);
            this.txtDersKod.Name = "txtDersKod";
            this.txtDersKod.Size = new System.Drawing.Size(139, 23);
            this.txtDersKod.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ders Kodu";
            // 
            // DersSilKod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 165);
            this.Controls.Add(this.btnDevam);
            this.Controls.Add(this.txtDersKod);
            this.Controls.Add(this.label2);
            this.Name = "DersSilKod";
            this.Text = "Ders Sil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDevam;
        private System.Windows.Forms.TextBox txtDersKod;
        private System.Windows.Forms.Label label2;
    }
}