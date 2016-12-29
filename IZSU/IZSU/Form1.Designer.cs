namespace IZSU
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
            this.txtbAboneNo = new System.Windows.Forms.TextBox();
            this.txtbAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnIsYeri = new System.Windows.Forms.RadioButton();
            this.rbtnEv = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbSayac = new System.Windows.Forms.TextBox();
            this.txtbOncekiSayac = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstbAboneler = new System.Windows.Forms.ListBox();
            this.lsltbOdenenFatura = new System.Windows.Forms.ListBox();
            this.lstbAboneBilgileri = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbAboneNo
            // 
            this.txtbAboneNo.Location = new System.Drawing.Point(64, 9);
            this.txtbAboneNo.Name = "txtbAboneNo";
            this.txtbAboneNo.Size = new System.Drawing.Size(100, 20);
            this.txtbAboneNo.TabIndex = 0;
            this.txtbAboneNo.TextChanged += new System.EventHandler(this.txtbAboneNo_TextChanged);
            // 
            // txtbAdSoyad
            // 
            this.txtbAdSoyad.Location = new System.Drawing.Point(64, 35);
            this.txtbAdSoyad.Name = "txtbAdSoyad";
            this.txtbAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtbAdSoyad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Abone No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad Soyadı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnIsYeri);
            this.groupBox1.Controls.Add(this.rbtnEv);
            this.groupBox1.Location = new System.Drawing.Point(3, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abone Tipi";
            // 
            // rbtnIsYeri
            // 
            this.rbtnIsYeri.AutoSize = true;
            this.rbtnIsYeri.Location = new System.Drawing.Point(9, 52);
            this.rbtnIsYeri.Name = "rbtnIsYeri";
            this.rbtnIsYeri.Size = new System.Drawing.Size(54, 17);
            this.rbtnIsYeri.TabIndex = 5;
            this.rbtnIsYeri.TabStop = true;
            this.rbtnIsYeri.Text = "İş Yeri";
            this.rbtnIsYeri.UseVisualStyleBackColor = true;
            this.rbtnIsYeri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtnIsYeri_MouseClick);
            // 
            // rbtnEv
            // 
            this.rbtnEv.AutoSize = true;
            this.rbtnEv.Location = new System.Drawing.Point(9, 19);
            this.rbtnEv.Name = "rbtnEv";
            this.rbtnEv.Size = new System.Drawing.Size(38, 17);
            this.rbtnEv.TabIndex = 5;
            this.rbtnEv.TabStop = true;
            this.rbtnEv.Text = "Ev";
            this.rbtnEv.UseVisualStyleBackColor = true;
            this.rbtnEv.Click += new System.EventHandler(this.rbtnEv_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Son Sayaç";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Önceki Sayaç";
            // 
            // txtbSayac
            // 
            this.txtbSayac.Location = new System.Drawing.Point(28, 212);
            this.txtbSayac.Name = "txtbSayac";
            this.txtbSayac.Size = new System.Drawing.Size(100, 20);
            this.txtbSayac.TabIndex = 6;
            this.txtbSayac.TextChanged += new System.EventHandler(this.txtbSayac_TextChanged);
            // 
            // txtbOncekiSayac
            // 
            this.txtbOncekiSayac.Location = new System.Drawing.Point(28, 170);
            this.txtbOncekiSayac.Name = "txtbOncekiSayac";
            this.txtbOncekiSayac.Size = new System.Drawing.Size(100, 20);
            this.txtbOncekiSayac.TabIndex = 5;
            this.txtbOncekiSayac.TextChanged += new System.EventHandler(this.txtbOncekiSayac_TextChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(38, 238);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(83, 40);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstbAboneler
            // 
            this.lstbAboneler.FormattingEnabled = true;
            this.lstbAboneler.Location = new System.Drawing.Point(187, 9);
            this.lstbAboneler.Name = "lstbAboneler";
            this.lstbAboneler.Size = new System.Drawing.Size(104, 277);
            this.lstbAboneler.TabIndex = 10;
            this.lstbAboneler.DoubleClick += new System.EventHandler(this.lstbAboneler_DoubleClick);
            // 
            // lsltbOdenenFatura
            // 
            this.lsltbOdenenFatura.FormattingEnabled = true;
            this.lsltbOdenenFatura.Location = new System.Drawing.Point(297, 9);
            this.lsltbOdenenFatura.Name = "lsltbOdenenFatura";
            this.lsltbOdenenFatura.Size = new System.Drawing.Size(213, 277);
            this.lsltbOdenenFatura.TabIndex = 11;
            this.lsltbOdenenFatura.DoubleClick += new System.EventHandler(this.lsltbOdenenFatura_DoubleClick);
            // 
            // lstbAboneBilgileri
            // 
            this.lstbAboneBilgileri.FormattingEnabled = true;
            this.lstbAboneBilgileri.Location = new System.Drawing.Point(516, 9);
            this.lstbAboneBilgileri.Name = "lstbAboneBilgileri";
            this.lstbAboneBilgileri.Size = new System.Drawing.Size(245, 160);
            this.lstbAboneBilgileri.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 290);
            this.Controls.Add(this.lstbAboneBilgileri);
            this.Controls.Add(this.lsltbOdenenFatura);
            this.Controls.Add(this.lstbAboneler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbSayac);
            this.Controls.Add(this.txtbOncekiSayac);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbAdSoyad);
            this.Controls.Add(this.txtbAboneNo);
            this.Name = "Form1";
            this.Text = "İZSU Abone";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbAboneNo;
        private System.Windows.Forms.TextBox txtbAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnIsYeri;
        private System.Windows.Forms.RadioButton rbtnEv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbSayac;
        private System.Windows.Forms.TextBox txtbOncekiSayac;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstbAboneler;
        private System.Windows.Forms.ListBox lsltbOdenenFatura;
        private System.Windows.Forms.ListBox lstbAboneBilgileri;
    }
}

