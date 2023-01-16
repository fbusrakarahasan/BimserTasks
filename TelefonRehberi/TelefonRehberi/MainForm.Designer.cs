namespace TelefonRehberi
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ekle = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.listele = new System.Windows.Forms.Button();
            this.dataGridRehber = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRehber)).BeginInit();
            this.SuspendLayout();
            // 
            // ekle
            // 
            this.ekle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ekle.Location = new System.Drawing.Point(226, 30);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(139, 37);
            this.ekle.TabIndex = 0;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // guncelle
            // 
            this.guncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guncelle.Location = new System.Drawing.Point(424, 30);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(139, 37);
            this.guncelle.TabIndex = 1;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // sil
            // 
            this.sil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sil.Location = new System.Drawing.Point(622, 30);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(139, 37);
            this.sil.TabIndex = 2;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // listele
            // 
            this.listele.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listele.Location = new System.Drawing.Point(28, 30);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(139, 37);
            this.listele.TabIndex = 3;
            this.listele.Text = "Listele";
            this.listele.UseVisualStyleBackColor = true;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // dataGridRehber
            // 
            this.dataGridRehber.AllowUserToAddRows = false;
            this.dataGridRehber.AllowUserToDeleteRows = false;
            this.dataGridRehber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRehber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.AdSoyad,
            this.Email,
            this.TelefonNo});
            this.dataGridRehber.Location = new System.Drawing.Point(28, 96);
            this.dataGridRehber.Name = "dataGridRehber";
            this.dataGridRehber.ReadOnly = true;
            this.dataGridRehber.RowHeadersWidth = 51;
            this.dataGridRehber.RowTemplate.Height = 29;
            this.dataGridRehber.Size = new System.Drawing.Size(733, 300);
            this.dataGridRehber.TabIndex = 4;
            this.dataGridRehber.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRehber_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 80;
            // 
            // AdSoyad
            // 
            this.AdSoyad.HeaderText = "Ad Soyad";
            this.AdSoyad.MinimumWidth = 6;
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.ReadOnly = true;
            this.AdSoyad.Width = 200;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // TelefonNo
            // 
            this.TelefonNo.HeaderText = "Telefon No";
            this.TelefonNo.MinimumWidth = 6;
            this.TelefonNo.Name = "TelefonNo";
            this.TelefonNo.ReadOnly = true;
            this.TelefonNo.Width = 200;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.dataGridRehber);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.ekle);
            this.Name = "MainForm";
            this.Text = "Telefon Rehberi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRehber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button ekle;
        private Button guncelle;
        private Button sil;
        private Button listele;
        private DataGridView dataGridRehber;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn AdSoyad;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn TelefonNo;
    }
}