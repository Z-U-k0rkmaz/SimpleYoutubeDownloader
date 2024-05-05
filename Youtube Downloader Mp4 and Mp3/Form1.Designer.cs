namespace Youtube_Downloader_Mp4_and_Mp3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnexit = new System.Windows.Forms.Button();
            this.btnBilgi = new System.Windows.Forms.Button();
            this.chkMp3 = new System.Windows.Forms.CheckBox();
            this.btnİndir = new System.Windows.Forms.Button();
            this.lblİlerleme = new System.Windows.Forms.Label();
            this.barDurum = new System.Windows.Forms.ProgressBar();
            this.cmbxÇözünürlük = new System.Windows.Forms.ComboBox();
            this.lblÇözünürlük = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKayıtYeri = new System.Windows.Forms.Button();
            this.txtKayıtYeri = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(520, 254);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(123, 34);
            this.btnexit.TabIndex = 29;
            this.btnexit.Text = "Çıkış";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnBilgi
            // 
            this.btnBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgi.Location = new System.Drawing.Point(520, 20);
            this.btnBilgi.Name = "btnBilgi";
            this.btnBilgi.Size = new System.Drawing.Size(123, 34);
            this.btnBilgi.TabIndex = 27;
            this.btnBilgi.Text = "Video Bilgisi al";
            this.btnBilgi.UseVisualStyleBackColor = true;
            this.btnBilgi.Click += new System.EventHandler(this.btnBilgi_Click);
            // 
            // chkMp3
            // 
            this.chkMp3.AutoSize = true;
            this.chkMp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkMp3.Location = new System.Drawing.Point(255, 76);
            this.chkMp3.Name = "chkMp3";
            this.chkMp3.Size = new System.Drawing.Size(63, 24);
            this.chkMp3.TabIndex = 26;
            this.chkMp3.Text = "Mp3";
            this.chkMp3.UseVisualStyleBackColor = true;
            // 
            // btnİndir
            // 
            this.btnİndir.Location = new System.Drawing.Point(255, 228);
            this.btnİndir.Name = "btnİndir";
            this.btnİndir.Size = new System.Drawing.Size(123, 34);
            this.btnİndir.TabIndex = 25;
            this.btnİndir.Text = "Download";
            this.btnİndir.UseVisualStyleBackColor = true;
            this.btnİndir.Click += new System.EventHandler(this.btnİndir_Click);
            // 
            // lblİlerleme
            // 
            this.lblİlerleme.AutoSize = true;
            this.lblİlerleme.Location = new System.Drawing.Point(520, 179);
            this.lblİlerleme.Name = "lblİlerleme";
            this.lblİlerleme.Size = new System.Drawing.Size(26, 16);
            this.lblİlerleme.TabIndex = 24;
            this.lblİlerleme.Text = "0%";
            // 
            // barDurum
            // 
            this.barDurum.Location = new System.Drawing.Point(111, 170);
            this.barDurum.Name = "barDurum";
            this.barDurum.Size = new System.Drawing.Size(403, 35);
            this.barDurum.TabIndex = 23;
            // 
            // cmbxÇözünürlük
            // 
            this.cmbxÇözünürlük.FormattingEnabled = true;
            this.cmbxÇözünürlük.Location = new System.Drawing.Point(111, 77);
            this.cmbxÇözünürlük.Name = "cmbxÇözünürlük";
            this.cmbxÇözünürlük.Size = new System.Drawing.Size(129, 24);
            this.cmbxÇözünürlük.TabIndex = 22;
            // 
            // lblÇözünürlük
            // 
            this.lblÇözünürlük.AutoSize = true;
            this.lblÇözünürlük.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblÇözünürlük.Location = new System.Drawing.Point(12, 81);
            this.lblÇözünürlük.Name = "lblÇözünürlük";
            this.lblÇözünürlük.Size = new System.Drawing.Size(98, 20);
            this.lblÇözünürlük.TabIndex = 21;
            this.lblÇözünürlük.Text = "Çözünürlük:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Konum:";
            // 
            // btnKayıtYeri
            // 
            this.btnKayıtYeri.Location = new System.Drawing.Point(520, 113);
            this.btnKayıtYeri.Name = "btnKayıtYeri";
            this.btnKayıtYeri.Size = new System.Drawing.Size(123, 34);
            this.btnKayıtYeri.TabIndex = 19;
            this.btnKayıtYeri.Text = "Kayıt Yeri";
            this.btnKayıtYeri.UseVisualStyleBackColor = true;
            this.btnKayıtYeri.Click += new System.EventHandler(this.btnKayıtYeri_Click);
            // 
            // txtKayıtYeri
            // 
            this.txtKayıtYeri.Location = new System.Drawing.Point(111, 119);
            this.txtKayıtYeri.Name = "txtKayıtYeri";
            this.txtKayıtYeri.ReadOnly = true;
            this.txtKayıtYeri.Size = new System.Drawing.Size(403, 22);
            this.txtKayıtYeri.TabIndex = 18;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrl.Location = new System.Drawing.Point(69, 26);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(36, 20);
            this.lblUrl.TabIndex = 17;
            this.lblUrl.Text = "Url:";
            // 
            // txtUrl
            // 
            this.txtUrl.AllowDrop = true;
            this.txtUrl.Location = new System.Drawing.Point(111, 26);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(403, 22);
            this.txtUrl.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 303);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnBilgi);
            this.Controls.Add(this.chkMp3);
            this.Controls.Add(this.btnİndir);
            this.Controls.Add(this.lblİlerleme);
            this.Controls.Add(this.barDurum);
            this.Controls.Add(this.cmbxÇözünürlük);
            this.Controls.Add(this.lblÇözünürlük);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKayıtYeri);
            this.Controls.Add(this.txtKayıtYeri);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtUrl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Youtube Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnBilgi;
        private System.Windows.Forms.CheckBox chkMp3;
        private System.Windows.Forms.Button btnİndir;
        private System.Windows.Forms.Label lblİlerleme;
        private System.Windows.Forms.ProgressBar barDurum;
        private System.Windows.Forms.ComboBox cmbxÇözünürlük;
        private System.Windows.Forms.Label lblÇözünürlük;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKayıtYeri;
        private System.Windows.Forms.TextBox txtKayıtYeri;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrl;
    }
}

