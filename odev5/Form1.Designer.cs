namespace odev5
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
            rezervasyon = new Button();
            isim = new TextBox();
            Odalar = new ComboBox();
            saat = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            gun = new ComboBox();
            ay = new ComboBox();
            ozetbutton = new Button();
            ÖzetLabel = new Label();
            SuspendLayout();
            // 
            // rezervasyon
            // 
            rezervasyon.Location = new Point(397, 40);
            rezervasyon.Name = "rezervasyon";
            rezervasyon.Size = new Size(189, 40);
            rezervasyon.TabIndex = 0;
            rezervasyon.Text = "Rezervasyon Oluştur";
            rezervasyon.UseVisualStyleBackColor = true;
            rezervasyon.Click += rezervasyon_Click;
            // 
            // isim
            // 
            isim.Location = new Point(99, 33);
            isim.Name = "isim";
            isim.Size = new Size(164, 27);
            isim.TabIndex = 1;
            // 
            // Odalar
            // 
            Odalar.DropDownStyle = ComboBoxStyle.DropDownList;
            Odalar.FormattingEnabled = true;
            Odalar.Items.AddRange(new object[] { "Oda A", "Oda B", "Oda C" });
            Odalar.Location = new Point(99, 88);
            Odalar.Name = "Odalar";
            Odalar.Size = new Size(164, 28);
            Odalar.TabIndex = 3;
            Odalar.SelectedIndexChanged += Odalar_SelectedIndexChanged;
            // 
            // saat
            // 
            saat.DropDownStyle = ComboBoxStyle.DropDownList;
            saat.FormattingEnabled = true;
            saat.Location = new Point(99, 190);
            saat.Name = "saat";
            saat.Size = new Size(164, 28);
            saat.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 40);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 5;
            label1.Text = "Adınız:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 91);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 6;
            label2.Text = "Odalar:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 193);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 7;
            label3.Text = "Saat:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 145);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 8;
            label4.Text = "Tarih:";
            // 
            // gun
            // 
            gun.DropDownStyle = ComboBoxStyle.DropDownList;
            gun.FormattingEnabled = true;
            gun.Items.AddRange(new object[] { "1" });
            gun.Location = new Point(269, 142);
            gun.Name = "gun";
            gun.Size = new Size(53, 28);
            gun.TabIndex = 9;
            // 
            // ay
            // 
            ay.DropDownStyle = ComboBoxStyle.DropDownList;
            ay.FormattingEnabled = true;
            ay.Items.AddRange(new object[] { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" });
            ay.Location = new Point(99, 142);
            ay.Name = "ay";
            ay.Size = new Size(151, 28);
            ay.TabIndex = 10;
            ay.SelectedIndexChanged += ay_SelectedIndexChanged;
            // 
            // ozetbutton
            // 
            ozetbutton.Location = new Point(663, 384);
            ozetbutton.Name = "ozetbutton";
            ozetbutton.Size = new Size(125, 54);
            ozetbutton.TabIndex = 11;
            ozetbutton.Text = "Özet";
            ozetbutton.UseVisualStyleBackColor = true;
            ozetbutton.Click += ozetbutton_Click;
            // 
            // ÖzetLabel
            // 
            ÖzetLabel.AutoSize = true;
            ÖzetLabel.Location = new Point(37, 281);
            ÖzetLabel.Name = "ÖzetLabel";
            ÖzetLabel.Size = new Size(0, 20);
            ÖzetLabel.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ÖzetLabel);
            Controls.Add(ozetbutton);
            Controls.Add(ay);
            Controls.Add(gun);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(saat);
            Controls.Add(Odalar);
            Controls.Add(isim);
            Controls.Add(rezervasyon);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button rezervasyon;
        private TextBox isim;
        private ComboBox Odalar;
        private ComboBox saat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox gun;
        private ComboBox ay;
        private Button ozetbutton;
        private Label ÖzetLabel;
    }
}
