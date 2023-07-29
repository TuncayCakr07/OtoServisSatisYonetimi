namespace OtoServisSatis.WinApp
{
    partial class ServisYonetimi
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
            this.dgvServisler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtSaseNo = new System.Windows.Forms.TextBox();
            this.TxtKasaTipi = new System.Windows.Forms.TextBox();
            this.TxtModel = new System.Windows.Forms.TextBox();
            this.TxtMArka = new System.Windows.Forms.TextBox();
            this.TxtAracPlaka = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGaranti = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.TxtNotlar = new System.Windows.Forms.TextBox();
            this.TxtServisUcreti = new System.Windows.Forms.TextBox();
            this.TxtYapilanİslemler = new System.Windows.Forms.TextBox();
            this.TxtAracSorunu = new System.Windows.Forms.TextBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.dtServiseGelisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServisler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvServisler
            // 
            this.dgvServisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvServisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServisler.Location = new System.Drawing.Point(12, 2);
            this.dgvServisler.Name = "dgvServisler";
            this.dgvServisler.RowHeadersWidth = 51;
            this.dgvServisler.RowTemplate.Height = 24;
            this.dgvServisler.Size = new System.Drawing.Size(1273, 268);
            this.dgvServisler.TabIndex = 2;
            this.dgvServisler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServisler_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtSaseNo);
            this.groupBox1.Controls.Add(this.TxtKasaTipi);
            this.groupBox1.Controls.Add(this.TxtModel);
            this.groupBox1.Controls.Add(this.TxtMArka);
            this.groupBox1.Controls.Add(this.TxtAracPlaka);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbGaranti);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtCikisTarihi);
            this.groupBox1.Controls.Add(this.TxtNotlar);
            this.groupBox1.Controls.Add(this.TxtServisUcreti);
            this.groupBox1.Controls.Add(this.TxtYapilanİslemler);
            this.groupBox1.Controls.Add(this.TxtAracSorunu);
            this.groupBox1.Controls.Add(this.BtnGuncelle);
            this.groupBox1.Controls.Add(this.BtnSil);
            this.groupBox1.Controls.Add(this.BtnEkle);
            this.groupBox1.Controls.Add(this.dtServiseGelisTarihi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(2, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1283, 390);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış Bilgileri";
            // 
            // TxtSaseNo
            // 
            this.TxtSaseNo.Location = new System.Drawing.Point(964, 73);
            this.TxtSaseNo.Name = "TxtSaseNo";
            this.TxtSaseNo.Size = new System.Drawing.Size(200, 28);
            this.TxtSaseNo.TabIndex = 26;
            // 
            // TxtKasaTipi
            // 
            this.TxtKasaTipi.Location = new System.Drawing.Point(964, 29);
            this.TxtKasaTipi.Name = "TxtKasaTipi";
            this.TxtKasaTipi.Size = new System.Drawing.Size(200, 28);
            this.TxtKasaTipi.TabIndex = 26;
            // 
            // TxtModel
            // 
            this.TxtModel.Location = new System.Drawing.Point(548, 204);
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Size = new System.Drawing.Size(200, 28);
            this.TxtModel.TabIndex = 26;
            // 
            // TxtMArka
            // 
            this.TxtMArka.Location = new System.Drawing.Point(548, 159);
            this.TxtMArka.Name = "TxtMArka";
            this.TxtMArka.Size = new System.Drawing.Size(200, 28);
            this.TxtMArka.TabIndex = 26;
            // 
            // TxtAracPlaka
            // 
            this.TxtAracPlaka.Location = new System.Drawing.Point(548, 111);
            this.TxtAracPlaka.Name = "TxtAracPlaka";
            this.TxtAracPlaka.Size = new System.Drawing.Size(200, 28);
            this.TxtAracPlaka.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(871, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "Şase No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(867, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Kasa Tipi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(450, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Model:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Marka:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Araç Plaka:\r\n";
            // 
            // cbGaranti
            // 
            this.cbGaranti.AutoSize = true;
            this.cbGaranti.Location = new System.Drawing.Point(59, 239);
            this.cbGaranti.Name = "cbGaranti";
            this.cbGaranti.Size = new System.Drawing.Size(278, 23);
            this.cbGaranti.TabIndex = 23;
            this.cbGaranti.Text = "Araç Garanti Kapsamında Mı?";
            this.cbGaranti.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(891, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "Notlar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Yapılan İşlemler:";
            // 
            // dtCikisTarihi
            // 
            this.dtCikisTarihi.Location = new System.Drawing.Point(137, 187);
            this.dtCikisTarihi.Name = "dtCikisTarihi";
            this.dtCikisTarihi.Size = new System.Drawing.Size(200, 28);
            this.dtCikisTarihi.TabIndex = 21;
            // 
            // TxtNotlar
            // 
            this.TxtNotlar.Location = new System.Drawing.Point(964, 115);
            this.TxtNotlar.Multiline = true;
            this.TxtNotlar.Name = "TxtNotlar";
            this.TxtNotlar.Size = new System.Drawing.Size(200, 72);
            this.TxtNotlar.TabIndex = 19;
            // 
            // TxtServisUcreti
            // 
            this.TxtServisUcreti.Location = new System.Drawing.Point(137, 147);
            this.TxtServisUcreti.Name = "TxtServisUcreti";
            this.TxtServisUcreti.Size = new System.Drawing.Size(200, 28);
            this.TxtServisUcreti.TabIndex = 20;
            // 
            // TxtYapilanİslemler
            // 
            this.TxtYapilanİslemler.Location = new System.Drawing.Point(548, 23);
            this.TxtYapilanİslemler.Multiline = true;
            this.TxtYapilanİslemler.Name = "TxtYapilanİslemler";
            this.TxtYapilanİslemler.Size = new System.Drawing.Size(200, 72);
            this.TxtYapilanİslemler.TabIndex = 19;
            // 
            // TxtAracSorunu
            // 
            this.TxtAracSorunu.Location = new System.Drawing.Point(137, 67);
            this.TxtAracSorunu.Multiline = true;
            this.TxtAracSorunu.Name = "TxtAracSorunu";
            this.TxtAracSorunu.Size = new System.Drawing.Size(200, 72);
            this.TxtAracSorunu.TabIndex = 19;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(375, 334);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(113, 29);
            this.BtnGuncelle.TabIndex = 18;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(494, 334);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(99, 29);
            this.BtnSil.TabIndex = 17;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(270, 334);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(99, 29);
            this.BtnEkle.TabIndex = 16;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // dtServiseGelisTarihi
            // 
            this.dtServiseGelisTarihi.Location = new System.Drawing.Point(137, 23);
            this.dtServiseGelisTarihi.Name = "dtServiseGelisTarihi";
            this.dtServiseGelisTarihi.Size = new System.Drawing.Size(200, 28);
            this.dtServiseGelisTarihi.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giriş Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Çıkış Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Servis Ücreti:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aracın Sorunu:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(1258, 23);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 19);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "0";
            // 
            // ServisYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 674);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvServisler);
            this.Name = "ServisYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servis Yönetimi";
            this.Load += new System.EventHandler(this.ServisYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServisler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServisler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.DateTimePicker dtServiseGelisTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox TxtServisUcreti;
        private System.Windows.Forms.TextBox TxtAracSorunu;
        private System.Windows.Forms.DateTimePicker dtCikisTarihi;
        private System.Windows.Forms.CheckBox cbGaranti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtYapilanİslemler;
        private System.Windows.Forms.TextBox TxtAracPlaka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSaseNo;
        private System.Windows.Forms.TextBox TxtKasaTipi;
        private System.Windows.Forms.TextBox TxtModel;
        private System.Windows.Forms.TextBox TxtMArka;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtNotlar;
    }
}