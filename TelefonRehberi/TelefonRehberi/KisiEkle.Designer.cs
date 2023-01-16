namespace TelefonRehberi
{
    partial class KisiEkle
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
            this.kisiKaydet = new System.Windows.Forms.Button();
            this.AdSoyad = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.telefonNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kisiKaydet
            // 
            this.kisiKaydet.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kisiKaydet.Location = new System.Drawing.Point(64, 180);
            this.kisiKaydet.Name = "kisiKaydet";
            this.kisiKaydet.Size = new System.Drawing.Size(237, 52);
            this.kisiKaydet.TabIndex = 0;
            this.kisiKaydet.Text = "Kaydet";
            this.kisiKaydet.UseVisualStyleBackColor = true;
            this.kisiKaydet.Click += new System.EventHandler(this.kisiKaydet_Click);
            // 
            // AdSoyad
            // 
            this.AdSoyad.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdSoyad.Location = new System.Drawing.Point(129, 29);
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.Size = new System.Drawing.Size(207, 31);
            this.AdSoyad.TabIndex = 1;
            this.AdSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AdSoyad_KeyPress);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(129, 72);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(207, 31);
            this.email.TabIndex = 2;
            // 
            // telefonNo
            // 
            this.telefonNo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.telefonNo.Location = new System.Drawing.Point(129, 118);
            this.telefonNo.MaxLength = 11;
            this.telefonNo.Name = "telefonNo";
            this.telefonNo.Size = new System.Drawing.Size(207, 31);
            this.telefonNo.TabIndex = 3;
            this.telefonNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefonNo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefon No:";
            // 
            // KisiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 257);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.telefonNo);
            this.Controls.Add(this.email);
            this.Controls.Add(this.AdSoyad);
            this.Controls.Add(this.kisiKaydet);
            this.Name = "KisiEkle";
            this.Text = "Kişi Ekle";
            this.Load += new System.EventHandler(this.KisiEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button kisiKaydet;
        private TextBox AdSoyad;
        private TextBox email;
        private TextBox telefonNo;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}