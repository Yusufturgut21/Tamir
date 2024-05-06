namespace Tamir
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            button2 = new Button();
            listBox1 = new ListBox();
            kayıttarih_txt = new TextBox();
            personno_txt = new TextBox();
            musterisoyad_txt = new TextBox();
            musteriad_txt = new TextBox();
            kayıtno_txt = new TextBox();
            serino_txt = new TextBox();
            model_txt = new TextBox();
            Marka_txt = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            personelno = new Label();
            tarih = new Label();
            tabPage2 = new TabPage();
            TamirList = new ListBox();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            durumCombo = new ComboBox();
            label12 = new Label();
            kayıtCombo = new ComboBox();
            label11 = new Label();
            Personel_txt = new TextBox();
            yedek_txt = new TextBox();
            label7 = new Label();
            Tarih_txt = new TextBox();
            label8 = new Label();
            islem_txt = new TextBox();
            label9 = new Label();
            label10 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(942, 577);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(934, 544);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(kayıttarih_txt);
            panel1.Controls.Add(personno_txt);
            panel1.Controls.Add(musterisoyad_txt);
            panel1.Controls.Add(musteriad_txt);
            panel1.Controls.Add(kayıtno_txt);
            panel1.Controls.Add(serino_txt);
            panel1.Controls.Add(model_txt);
            panel1.Controls.Add(Marka_txt);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(personelno);
            panel1.Controls.Add(tarih);
            panel1.Location = new Point(24, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(869, 494);
            panel1.TabIndex = 19;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(166, 416);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 30;
            button2.Text = "GÜNCELLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(396, 19);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(420, 384);
            listBox1.TabIndex = 29;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // kayıttarih_txt
            // 
            kayıttarih_txt.Location = new Point(190, 352);
            kayıttarih_txt.Name = "kayıttarih_txt";
            kayıttarih_txt.Size = new Size(125, 27);
            kayıttarih_txt.TabIndex = 28;
            // 
            // personno_txt
            // 
            personno_txt.Location = new Point(190, 310);
            personno_txt.Name = "personno_txt";
            personno_txt.Size = new Size(125, 27);
            personno_txt.TabIndex = 27;
            personno_txt.TextChanged += personno_txt_TextChanged;
            // 
            // musterisoyad_txt
            // 
            musterisoyad_txt.Location = new Point(190, 262);
            musterisoyad_txt.Name = "musterisoyad_txt";
            musterisoyad_txt.Size = new Size(125, 27);
            musterisoyad_txt.TabIndex = 26;
            // 
            // musteriad_txt
            // 
            musteriad_txt.Location = new Point(190, 216);
            musteriad_txt.Name = "musteriad_txt";
            musteriad_txt.Size = new Size(125, 27);
            musteriad_txt.TabIndex = 25;
            // 
            // kayıtno_txt
            // 
            kayıtno_txt.Location = new Point(190, 167);
            kayıtno_txt.Name = "kayıtno_txt";
            kayıtno_txt.Size = new Size(125, 27);
            kayıtno_txt.TabIndex = 24;
            kayıtno_txt.TextChanged += kayıtno_txt_TextChanged_1;
            // 
            // serino_txt
            // 
            serino_txt.Location = new Point(190, 113);
            serino_txt.Name = "serino_txt";
            serino_txt.Size = new Size(125, 27);
            serino_txt.TabIndex = 23;
            // 
            // model_txt
            // 
            model_txt.Location = new Point(190, 65);
            model_txt.Name = "model_txt";
            model_txt.Size = new Size(125, 27);
            model_txt.TabIndex = 22;
            // 
            // Marka_txt
            // 
            Marka_txt.Location = new Point(190, 19);
            Marka_txt.Name = "Marka_txt";
            Marka_txt.Size = new Size(125, 27);
            Marka_txt.TabIndex = 21;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(47, 416);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 20;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(56, 19);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "ÜRÜN MARKA:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(57, 68);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 1;
            label2.Text = "ÜRÜN MODEL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gray;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(56, 116);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 2;
            label3.Text = "ÜRÜN SERİNO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gray;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(47, 167);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 3;
            label4.Text = "ÜRÜN KAYITNO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gray;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(66, 216);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 4;
            label5.Text = "MÜŞTERİ AD:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gray;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(40, 265);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 5;
            label6.Text = "MÜŞTERİ SOYAD:";
            // 
            // personelno
            // 
            personelno.AutoSize = true;
            personelno.BackColor = Color.Gray;
            personelno.ForeColor = SystemColors.ButtonHighlight;
            personelno.Location = new Point(13, 310);
            personelno.Name = "personelno";
            personelno.Size = new Size(150, 20);
            personelno.TabIndex = 7;
            personelno.Text = "KAYIT PERSONEL NO:";
            // 
            // tarih
            // 
            tarih.AutoSize = true;
            tarih.BackColor = Color.Gray;
            tarih.ForeColor = SystemColors.ButtonHighlight;
            tarih.Location = new Point(64, 359);
            tarih.Name = "tarih";
            tarih.Size = new Size(99, 20);
            tarih.TabIndex = 8;
            tarih.Text = "KAYIT TARİHİ:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Yellow;
            tabPage2.Controls.Add(TamirList);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(934, 544);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // TamirList
            // 
            TamirList.FormattingEnabled = true;
            TamirList.Location = new Point(521, 30);
            TamirList.Name = "TamirList";
            TamirList.Size = new Size(397, 424);
            TamirList.TabIndex = 9;
            TamirList.SelectedIndexChanged += TamirList_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 192);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(durumCombo);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(kayıtCombo);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(Personel_txt);
            panel2.Controls.Add(yedek_txt);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(Tarih_txt);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(islem_txt);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(25, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(467, 424);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.ForeColor = Color.Red;
            button4.Location = new Point(223, 355);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 13;
            button4.Text = "GÜNCELLE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Lime;
            button3.ForeColor = Color.Red;
            button3.Location = new Point(105, 355);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "KAYDET";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // durumCombo
            // 
            durumCombo.FormattingEnabled = true;
            durumCombo.Items.AddRange(new object[] { "BAŞLAMADI", "DEVAM", "BİTTİ" });
            durumCombo.Location = new Point(242, 292);
            durumCombo.Name = "durumCombo";
            durumCombo.Size = new Size(151, 28);
            durumCombo.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(0, 192, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(47, 307);
            label12.Name = "label12";
            label12.Size = new Size(142, 20);
            label12.TabIndex = 10;
            label12.Text = "TAMİR DURUMLARI:";
            // 
            // kayıtCombo
            // 
            kayıtCombo.FormattingEnabled = true;
            kayıtCombo.Location = new Point(242, 240);
            kayıtCombo.Name = "kayıtCombo";
            kayıtCombo.Size = new Size(151, 28);
            kayıtCombo.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(0, 192, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(12, 250);
            label11.Name = "label11";
            label11.Size = new Size(177, 20);
            label11.TabIndex = 8;
            label11.Text = "ARIZALI ÜRÜN KAYIT NO:";
            // 
            // Personel_txt
            // 
            Personel_txt.Location = new Point(242, 15);
            Personel_txt.Name = "Personel_txt";
            Personel_txt.Size = new Size(125, 27);
            Personel_txt.TabIndex = 4;
            // 
            // yedek_txt
            // 
            yedek_txt.Location = new Point(242, 183);
            yedek_txt.Name = "yedek_txt";
            yedek_txt.Size = new Size(125, 27);
            yedek_txt.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(0, 192, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(105, 22);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 0;
            label7.Text = "PersonelNo";
            // 
            // Tarih_txt
            // 
            Tarih_txt.Location = new Point(242, 125);
            Tarih_txt.Name = "Tarih_txt";
            Tarih_txt.Size = new Size(125, 27);
            Tarih_txt.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(0, 192, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(23, 79);
            label8.Name = "label8";
            label8.Size = new Size(166, 20);
            label8.TabIndex = 1;
            label8.Text = "Tamir için yapılan işlem:";
            // 
            // islem_txt
            // 
            islem_txt.Location = new Point(242, 72);
            islem_txt.Name = "islem_txt";
            islem_txt.Size = new Size(125, 27);
            islem_txt.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(0, 192, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(106, 139);
            label9.Name = "label9";
            label9.Size = new Size(83, 20);
            label9.TabIndex = 2;
            label9.Text = "Tamir Tarih:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(0, 192, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(44, 197);
            label10.Name = "label10";
            label10.Size = new Size(145, 20);
            label10.TabIndex = 3;
            label10.Text = "Değişen Yedek Parça";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 643);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button kaydet;
        private Label tarih;
        private Label personelno;
        private Label label6;
        private Label label5;
        private Panel panel1;
        private Button button1;
        private TextBox kayıttarih_txt;
        private TextBox personno_txt;
        private TextBox musterisoyad_txt;
        private TextBox musteriad_txt;
        private TextBox kayıtno_txt;
        private TextBox serino_txt;
        private TextBox model_txt;
        private TextBox Marka_txt;
        private ListBox listBox1;
        private Button button2;
        private Label label7;
        private Panel panel2;
        private Label label11;
        private TextBox Personel_txt;
        private TextBox yedek_txt;
        private TextBox Tarih_txt;
        private Label label8;
        private TextBox islem_txt;
        private Label label9;
        private Label label10;
        private Button button3;
        private ComboBox durumCombo;
        private Label label12;
        private ComboBox kayıtCombo;
        private ListBox TamirList;
        private Button button4;
    }
}
