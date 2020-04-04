namespace hazirMetotlar
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSubString = new System.Windows.Forms.Button();
            this.listBoxStringSonuc = new System.Windows.Forms.ListBox();
            this.buttonIndexOf = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelKayanYazi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxUrunFiyati = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTaksit = new System.Windows.Forms.ComboBox();
            this.buttonOdeme = new System.Windows.Forms.Button();
            this.listBoxTakvim = new System.Windows.Forms.ListBox();
            this.dateTimePickerGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.labelGecenSure = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelKayanYazi);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonIndexOf);
            this.groupBox1.Controls.Add(this.listBoxStringSonuc);
            this.groupBox1.Controls.Add(this.buttonSubString);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "String Metotlar";
            // 
            // buttonSubString
            // 
            this.buttonSubString.Location = new System.Drawing.Point(21, 32);
            this.buttonSubString.Name = "buttonSubString";
            this.buttonSubString.Size = new System.Drawing.Size(75, 23);
            this.buttonSubString.TabIndex = 1;
            this.buttonSubString.Text = "Substring";
            this.buttonSubString.UseVisualStyleBackColor = true;
            this.buttonSubString.Click += new System.EventHandler(this.buttonSubString_Click);
            // 
            // listBoxStringSonuc
            // 
            this.listBoxStringSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStringSonuc.FormattingEnabled = true;
            this.listBoxStringSonuc.ItemHeight = 37;
            this.listBoxStringSonuc.Location = new System.Drawing.Point(6, 188);
            this.listBoxStringSonuc.Name = "listBoxStringSonuc";
            this.listBoxStringSonuc.Size = new System.Drawing.Size(377, 78);
            this.listBoxStringSonuc.TabIndex = 2;
            // 
            // buttonIndexOf
            // 
            this.buttonIndexOf.Location = new System.Drawing.Point(117, 32);
            this.buttonIndexOf.Name = "buttonIndexOf";
            this.buttonIndexOf.Size = new System.Drawing.Size(75, 23);
            this.buttonIndexOf.TabIndex = 3;
            this.buttonIndexOf.Text = "IndexOf";
            this.buttonIndexOf.UseVisualStyleBackColor = true;
            this.buttonIndexOf.Click += new System.EventHandler(this.buttonIndexOf_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Şov";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelKayanYazi
            // 
            this.labelKayanYazi.AutoSize = true;
            this.labelKayanYazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKayanYazi.Location = new System.Drawing.Point(6, 160);
            this.labelKayanYazi.Name = "labelKayanYazi";
            this.labelKayanYazi.Size = new System.Drawing.Size(298, 25);
            this.labelKayanYazi.TabIndex = 5;
            this.labelKayanYazi.Text = "String metotlarını öğreniyorum";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelGecenSure);
            this.groupBox2.Controls.Add(this.dateTimePickerGirisTarihi);
            this.groupBox2.Controls.Add(this.listBoxTakvim);
            this.groupBox2.Controls.Add(this.buttonOdeme);
            this.groupBox2.Controls.Add(this.comboBoxTaksit);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxUrunFiyati);
            this.groupBox2.Location = new System.Drawing.Point(439, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 297);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DateTime işlemleri";
            // 
            // textBoxUrunFiyati
            // 
            this.textBoxUrunFiyati.Location = new System.Drawing.Point(21, 47);
            this.textBoxUrunFiyati.Name = "textBoxUrunFiyati";
            this.textBoxUrunFiyati.Size = new System.Drawing.Size(100, 20);
            this.textBoxUrunFiyati.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Taksit Sayısı";
            // 
            // comboBoxTaksit
            // 
            this.comboBoxTaksit.FormattingEnabled = true;
            this.comboBoxTaksit.Location = new System.Drawing.Point(137, 46);
            this.comboBoxTaksit.Name = "comboBoxTaksit";
            this.comboBoxTaksit.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTaksit.TabIndex = 4;
            // 
            // buttonOdeme
            // 
            this.buttonOdeme.Location = new System.Drawing.Point(265, 43);
            this.buttonOdeme.Name = "buttonOdeme";
            this.buttonOdeme.Size = new System.Drawing.Size(99, 23);
            this.buttonOdeme.TabIndex = 5;
            this.buttonOdeme.Text = "Ödeme Takvimi";
            this.buttonOdeme.UseVisualStyleBackColor = true;
            this.buttonOdeme.Click += new System.EventHandler(this.buttonOdeme_Click);
            // 
            // listBoxTakvim
            // 
            this.listBoxTakvim.FormattingEnabled = true;
            this.listBoxTakvim.Location = new System.Drawing.Point(24, 86);
            this.listBoxTakvim.Name = "listBoxTakvim";
            this.listBoxTakvim.Size = new System.Drawing.Size(327, 186);
            this.listBoxTakvim.TabIndex = 6;
            // 
            // dateTimePickerGirisTarihi
            // 
            this.dateTimePickerGirisTarihi.CustomFormat = "dd MMMM yyyy HH:mm";
            this.dateTimePickerGirisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerGirisTarihi.Location = new System.Drawing.Point(435, 46);
            this.dateTimePickerGirisTarihi.Name = "dateTimePickerGirisTarihi";
            this.dateTimePickerGirisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerGirisTarihi.TabIndex = 7;
            this.dateTimePickerGirisTarihi.ValueChanged += new System.EventHandler(this.dateTimePickerGirisTarihi_ValueChanged);
            // 
            // labelGecenSure
            // 
            this.labelGecenSure.AutoSize = true;
            this.labelGecenSure.Location = new System.Drawing.Point(504, 99);
            this.labelGecenSure.Name = "labelGecenSure";
            this.labelGecenSure.Size = new System.Drawing.Size(35, 13);
            this.labelGecenSure.TabIndex = 8;
            this.labelGecenSure.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 485);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxStringSonuc;
        private System.Windows.Forms.Button buttonSubString;
        private System.Windows.Forms.Button buttonIndexOf;
        private System.Windows.Forms.Label labelKayanYazi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxTakvim;
        private System.Windows.Forms.Button buttonOdeme;
        private System.Windows.Forms.ComboBox comboBoxTaksit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUrunFiyati;
        private System.Windows.Forms.DateTimePicker dateTimePickerGirisTarihi;
        private System.Windows.Forms.Label labelGecenSure;
    }
}

