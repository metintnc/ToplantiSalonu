using System.Diagnostics.Eventing.Reader;
using System.IO;

namespace odev5
{
    public partial class Form1 : Form
    {
        List<string> kay�tlar = new List<string>();
        List<int> kontrol = new List<int> {0,1,2};
        List<string> �zetliste = new List<string>(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Odalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            kontrol.Clear();
            kontrol.Add(0);
            kontrol.Add(1);
            kontrol.Add(2);
            if (Odalar.SelectedIndex == 0)
            {
                saat.Items.Clear();
                saat.Items.Add("9.00 - 10.00");
                saat.Items.Add("10.30 - 11.30");
                saat.Items.Add("12.00 - 13.00");
            }
            else if (Odalar.SelectedIndex == 1)
            {
                saat.Items.Clear();
                saat.Items.Add("15.00 - 16.00");
                saat.Items.Add("16.30 - 17.30");
                saat.Items.Add("18.00 - 19.00");
            }
            else if (Odalar.SelectedIndex == 2)
            {
                saat.Items.Clear();
                saat.Items.Add("21.00 - 22.00");
                saat.Items.Add("22.30 - 23.30");
                saat.Items.Add("24.00 - 01.00");
            }

        }

        private void ay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ay.SelectedIndex == 1)
            {
                gun.Items.Clear();
                for (int i = 1; i < 29; i++)
                {
                    gun.Items.Add(i);
                }
            }
            else if (ay.SelectedIndex == 3 || ay.SelectedIndex == 5 || ay.SelectedIndex == 8 || ay.SelectedIndex == 10)
            {
                gun.Items.Clear();
                for (int i = 1; i < 31; i++)
                {
                    gun.Items.Add(i);
                }
            }
            else
            {
                gun.Items.Clear();
                for (int i = 1; i < 32; i++)
                {
                    gun.Items.Add(i);
                }
            }
        }

        private void rezervasyon_Click(object sender, EventArgs e)
        {
            string istenen;
            string dosya = "kay�t.txt";
            int a = 1;
            istenen = Odalar.Text + gun.Text + ay.Text + saat.Text;
            for (int i = 0; i < kay�tlar.Count; i++)
            {
                if (kay�tlar[i] == istenen)
                {
                    MessageBox.Show("Daha �nce bu saate rezervasyon yap�ld��� i�in rezervasyon yap�lamam��t�r");
                    for (int j = 0; j < 3; j++)
                    {
                        if (Convert.ToString(saat.Items[j]) == saat.Text)
                        {
                            kontrol.Remove(j);
                        }
                    }
                    if (kontrol.Count == 0)
                    {
                        MessageBox.Show(string.Format("Bu saatte bu odada bo� yer kalmam��t�r. L�tfen ba�ka bir oda veya ba�ka bir tarih se�iniz."));
                    }
                    else if (kontrol.Count == 1)
                    {
                        MessageBox.Show(string.Format("Size en yak�n uygun zaman: {0}", saat.Items[kontrol[0]]));

                    }
                    else if (kontrol.Count == 2)
                    {
                        if (Convert.ToString(saat.Items[0]) == saat.Text)
                            MessageBox.Show(string.Format("Size en yak�n uygun zaman: {0}", saat.Items[1]));
                        else if (Convert.ToString(saat.Items[2]) == saat.Text)
                            MessageBox.Show(string.Format("Size en yak�n uygun zaman: {0}", saat.Items[1]));
                        else
                            MessageBox.Show(string.Format("Size en yak�n uygun zaman: {0}", saat.Items[0]));
                    }
                    a = 0;
                    break;
                }
            }
            if (a == 1)
            {
                �zetliste.Add(isim.Text + " / " + Odalar.Text + " / " + gun.Text + " " + ay.Text + " / " + saat.Text);
                kay�tlar.Add(Odalar.Text + gun.Text + ay.Text + saat.Text);
                using (StreamWriter sw = File.AppendText(dosya))
                {
                    sw.WriteLine(isim.Text + " / " + Odalar.Text + " / " + gun.Text + " " + ay.Text + " / " + saat.Text);
                }
                MessageBox.Show("Rezervasyon Yap�lm��t�r.");
            }
            isim.Text = string.Empty;
        }

        private void ozetbutton_Click(object sender, EventArgs e)
        {
            �zetLabel.Text = string.Empty;
            foreach(string � in �zetliste)
            {
                �zetLabel.Text += � + "\n";
            }
        }
    }
}
     