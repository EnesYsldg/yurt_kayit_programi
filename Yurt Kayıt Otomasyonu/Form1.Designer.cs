
namespace YurKayit4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtOgrAd = new System.Windows.Forms.TextBox();
            this.TxtOgrSoyad = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.RchAdres = new System.Windows.Forms.RichTextBox();
            this.CmbBolum = new System.Windows.Forms.ComboBox();
            this.CmbOdaNo = new System.Windows.Forms.ComboBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.MskTel = new System.Windows.Forms.MaskedTextBox();
            this.MskVeliTel = new System.Windows.Forms.MaskedTextBox();
            this.MskDogum = new System.Windows.Forms.MaskedTextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Öğrenci Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(115, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(72, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Doğum Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(5, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Öğrenci Bölüm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(73, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Oda No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(18, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Veli Ad Soyad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(32, 463);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Veli Telefon:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(89, 513);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "Adres:";
            // 
            // TxtOgrAd
            // 
            this.TxtOgrAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrAd.Location = new System.Drawing.Point(162, 21);
            this.TxtOgrAd.Name = "TxtOgrAd";
            this.TxtOgrAd.Size = new System.Drawing.Size(267, 30);
            this.TxtOgrAd.TabIndex = 11;
            // 
            // TxtOgrSoyad
            // 
            this.TxtOgrSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrSoyad.Location = new System.Drawing.Point(162, 73);
            this.TxtOgrSoyad.Name = "TxtOgrSoyad";
            this.TxtOgrSoyad.Size = new System.Drawing.Size(267, 30);
            this.TxtOgrSoyad.TabIndex = 12;
            // 
            // TxtMail
            // 
            this.TxtMail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Location = new System.Drawing.Point(162, 300);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(267, 30);
            this.TxtMail.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(99, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 24);
            this.label12.TabIndex = 14;
            this.label12.Text = "Mail:";
            // 
            // TxtVeliAdSoyad
            // 
            this.TxtVeliAdSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtVeliAdSoyad.Location = new System.Drawing.Point(162, 401);
            this.TxtVeliAdSoyad.Name = "TxtVeliAdSoyad";
            this.TxtVeliAdSoyad.Size = new System.Drawing.Size(267, 30);
            this.TxtVeliAdSoyad.TabIndex = 15;
            // 
            // RchAdres
            // 
            this.RchAdres.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RchAdres.Location = new System.Drawing.Point(162, 513);
            this.RchAdres.Name = "RchAdres";
            this.RchAdres.Size = new System.Drawing.Size(267, 96);
            this.RchAdres.TabIndex = 16;
            this.RchAdres.Text = "";
            // 
            // CmbBolum
            // 
            this.CmbBolum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbBolum.FormattingEnabled = true;
            this.CmbBolum.Location = new System.Drawing.Point(162, 251);
            this.CmbBolum.Name = "CmbBolum";
            this.CmbBolum.Size = new System.Drawing.Size(267, 32);
            this.CmbBolum.TabIndex = 17;
            // 
            // CmbOdaNo
            // 
            this.CmbOdaNo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbOdaNo.FormattingEnabled = true;
            this.CmbOdaNo.Location = new System.Drawing.Point(162, 350);
            this.CmbOdaNo.Name = "CmbOdaNo";
            this.CmbOdaNo.Size = new System.Drawing.Size(267, 32);
            this.CmbOdaNo.TabIndex = 18;
            // 
            // MskTC
            // 
            this.MskTC.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTC.Location = new System.Drawing.Point(162, 109);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(267, 30);
            this.MskTC.TabIndex = 19;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // MskTel
            // 
            this.MskTel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTel.Location = new System.Drawing.Point(162, 161);
            this.MskTel.Mask = "(999) 000-0000";
            this.MskTel.Name = "MskTel";
            this.MskTel.Size = new System.Drawing.Size(267, 30);
            this.MskTel.TabIndex = 20;
            // 
            // MskVeliTel
            // 
            this.MskVeliTel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskVeliTel.Location = new System.Drawing.Point(162, 457);
            this.MskVeliTel.Mask = "(999) 000-0000";
            this.MskVeliTel.Name = "MskVeliTel";
            this.MskVeliTel.Size = new System.Drawing.Size(267, 30);
            this.MskVeliTel.TabIndex = 21;
            // 
            // MskDogum
            // 
            this.MskDogum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskDogum.Location = new System.Drawing.Point(162, 206);
            this.MskDogum.Mask = "00/00/0000";
            this.MskDogum.Name = "MskDogum";
            this.MskDogum.Size = new System.Drawing.Size(267, 30);
            this.MskDogum.TabIndex = 22;
            this.MskDogum.ValidatingType = typeof(System.DateTime);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(162, 639);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(187, 57);
            this.BtnKaydet.TabIndex = 23;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 741);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.MskDogum);
            this.Controls.Add(this.MskVeliTel);
            this.Controls.Add(this.MskTel);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.CmbOdaNo);
            this.Controls.Add(this.CmbBolum);
            this.Controls.Add(this.RchAdres);
            this.Controls.Add(this.TxtVeliAdSoyad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.TxtOgrSoyad);
            this.Controls.Add(this.TxtOgrAd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Öğrenci Kayit";
            this.Load += new System.EventHandler(this.FrmOgrKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtOgrAd;
        private System.Windows.Forms.TextBox TxtOgrSoyad;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtVeliAdSoyad;
        private System.Windows.Forms.RichTextBox RchAdres;
        private System.Windows.Forms.ComboBox CmbBolum;
        private System.Windows.Forms.ComboBox CmbOdaNo;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.MaskedTextBox MskTel;
        private System.Windows.Forms.MaskedTextBox MskVeliTel;
        private System.Windows.Forms.MaskedTextBox MskDogum;
        private System.Windows.Forms.Button BtnKaydet;
    }
}

