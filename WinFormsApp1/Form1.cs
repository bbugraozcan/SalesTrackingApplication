using System.Drawing.Printing;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MüþteriAdýTextbox.Text))
            {
                MessageBox.Show("Müþteri adý ve soyadý giriniz.");
                return;
            }
            else
            {
                string musteriAdi = MüþteriAdýTextbox.Text;
                string tarih = TarihTextBox.Text;
                string toplamFiyat = ToplamFiyatTextbox.Text;
                if (!string.IsNullOrEmpty(Ürün1Textbox.Text) &&
                    !string.IsNullOrEmpty(SandýkAdeti1Textbox.Text) &&
                    !string.IsNullOrEmpty(ToplamKilo1Textbox.Text) &&
                    !string.IsNullOrEmpty(BirimFiyat1Textbox.Text) &&
                    !string.IsNullOrEmpty(ToplamFiyat1Textbox.Text))
                {
                    string urunAdi = Ürün1Textbox.Text;
                    string sandikAdeti = SandýkAdeti1Textbox.Text;
                    string toplamKilo = ToplamKilo1Textbox.Text;
                    string birimFiyat = BirimFiyat1Textbox.Text;
                    string araToplamFiyat = ToplamFiyat1Textbox.Text;

                    // DataGridView'e eklemek için
                    dataGridView1.Rows.Add(tarih, musteriAdi, urunAdi, sandikAdeti, toplamKilo, birimFiyat, araToplamFiyat);

                    // TextBox'larý temizle
                    // Temizle1Button_Click(sender, e);
                }

                if (!string.IsNullOrEmpty(Ürün2Textbox.Text) &&
                    !string.IsNullOrEmpty(SandýkAdeti2Textbox.Text) &&
                    !string.IsNullOrEmpty(ToplamKilo2Textbox.Text) &&
                    !string.IsNullOrEmpty(BirimFiyat2Textbox.Text) &&
                    !string.IsNullOrEmpty(ToplamFiyat2Textbox.Text))
                {
                    string urunAdi = Ürün2Textbox.Text;
                    string sandikAdeti = SandýkAdeti2Textbox.Text;
                    string toplamKilo = ToplamKilo2Textbox.Text;
                    string birimFiyat = BirimFiyat2Textbox.Text;
                    string araToplamFiyat = ToplamFiyat2Textbox.Text;

                    // DataGridView'e eklemek için
                    dataGridView1.Rows.Add(tarih, musteriAdi, urunAdi, sandikAdeti, toplamKilo, birimFiyat, araToplamFiyat);

                    // TextBox'larý temizle
                    // Temizle2Button_Click(sender, e);
                }

                if (!string.IsNullOrEmpty(Ürün3Textbox.Text) &&
                    !string.IsNullOrEmpty(SandýkAdeti3Textbox.Text) &&
                    !string.IsNullOrEmpty(ToplamKilo3Textbox.Text) &&
                    !string.IsNullOrEmpty(BirimFiyat3Textbox.Text) &&
                    !string.IsNullOrEmpty(ToplamFiyat3Textbox.Text))
                {
                    string urunAdi = Ürün3Textbox.Text;
                    string sandikAdeti = SandýkAdeti3Textbox.Text;
                    string toplamKilo = ToplamKilo3Textbox.Text;
                    string birimFiyat = BirimFiyat3Textbox.Text;
                    string araToplamFiyat = ToplamFiyat3Textbox.Text;

                    // DataGridView'e eklemek için
                    dataGridView1.Rows.Add(tarih, musteriAdi, urunAdi, sandikAdeti, toplamKilo, birimFiyat, araToplamFiyat);

                    // TextBox'larý temizle
                    // Temizle3Button_Click(sender, e);
                }

                if (!string.IsNullOrEmpty(Ürün4Textbox.Text) &&
                    !string.IsNullOrEmpty(SandýkAdeti4Textbox.Text) &&
                    !string.IsNullOrEmpty(ToplamKilo4Textbox.Text) &&
                    !string.IsNullOrEmpty(BirimFiyat4Textbox.Text) &&
                    !string.IsNullOrEmpty(ToplamFiyat4Textbox.Text))
                {
                    string urunAdi = Ürün4Textbox.Text;
                    string sandikAdeti = SandýkAdeti4Textbox.Text;
                    string toplamKilo = ToplamKilo4Textbox.Text;
                    string birimFiyat = BirimFiyat4Textbox.Text;
                    string araToplamFiyat = ToplamFiyat4Textbox.Text;

                    // DataGridView'e eklemek için
                    dataGridView1.Rows.Add(tarih, musteriAdi, urunAdi, sandikAdeti, toplamKilo, birimFiyat, araToplamFiyat);

                    // TextBox'larý temizle
                    // Temizle4Button_Click(sender, e);
                }
            }
        }

        private void ToplamFiyatHesaplaButon_Click(object sender, EventArgs e)
        {
            float toplamFiyat = 0;
            if (!string.IsNullOrEmpty(ToplamKilo1Textbox.Text))
            {
                float toplamKilo1 = float.Parse(ToplamKilo1Textbox.Text);
                float birimFiyat1 = float.Parse(BirimFiyat1Textbox.Text);
                float toplamFiyat1 = toplamKilo1 * birimFiyat1;
                ToplamFiyat1Textbox.Text = Convert.ToString(toplamFiyat1);
                toplamFiyat = toplamFiyat + toplamFiyat1;
            }
            if (!string.IsNullOrEmpty(ToplamKilo2Textbox.Text))
            {
                float toplamKilo2 = float.Parse(ToplamKilo2Textbox.Text);
                float birimFiyat2 = float.Parse(BirimFiyat2Textbox.Text);
                float toplamFiyat2 = toplamKilo2 * birimFiyat2;
                ToplamFiyat2Textbox.Text = Convert.ToString(toplamFiyat2);
                toplamFiyat = toplamFiyat + toplamFiyat2;
            }
            if (!string.IsNullOrEmpty(ToplamKilo3Textbox.Text))
            {
                float toplamKilo3 = float.Parse(ToplamKilo3Textbox.Text);
                float birimFiyat3 = float.Parse(BirimFiyat3Textbox.Text);
                float toplamFiyat3 = toplamKilo3 * birimFiyat3;
                ToplamFiyat3Textbox.Text = Convert.ToString(toplamFiyat3);
                toplamFiyat = toplamFiyat + toplamFiyat3;
            }

            if (!string.IsNullOrEmpty(ToplamKilo4Textbox.Text))
            {
                float toplamKilo4 = float.Parse(ToplamKilo4Textbox.Text);
                float birimFiyat4 = float.Parse(BirimFiyat4Textbox.Text);
                float toplamFiyat4 = toplamKilo4 * birimFiyat4;
                ToplamFiyat4Textbox.Text = Convert.ToString(toplamFiyat4);
                toplamFiyat = toplamFiyat + toplamFiyat4;
            }

            if (!string.IsNullOrEmpty(ToplamKilo5Textbox.Text))
            {
                float toplamKilo5 = float.Parse(ToplamKilo5Textbox.Text);
                float birimFiyat5 = float.Parse(BirimFiyat5Textbox.Text);
                float toplamFiyat5 = toplamKilo5 * birimFiyat5;
                ToplamFiyat5Textbox.Text = Convert.ToString(toplamFiyat5);
                toplamFiyat = toplamFiyat + toplamFiyat5;
            }

                ToplamFiyatTextbox.Text = Convert.ToString(toplamFiyat);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string formattedDate = now.ToString("dd/MM/yyyy");
            TarihTextBox.Text = formattedDate;
            
            //Fiþ çýktýsýný kontrl için oluþturulmuþ ve initilaze edilmiþ dummy veriler
            MüþteriAdýTextbox.Text = "Buðra Özcan";
            
            Ürün1Textbox.Text = "Domates";
            SandýkAdeti1Textbox.Text = "2";
            ToplamKilo1Textbox.Text = "20";
            BirimFiyat1Textbox.Text = "25,36";

            Ürün2Textbox.Text = "Salatalýk";
            SandýkAdeti2Textbox.Text = "3";
            ToplamKilo2Textbox.Text = "45";
            BirimFiyat2Textbox.Text = "28,95";

            Ürün3Textbox.Text = "KývýrcýkMarulKaraman";
            SandýkAdeti3Textbox.Text = "4";
            ToplamKilo3Textbox.Text = "32";
            BirimFiyat3Textbox.Text = "36,57";

            ToplamFiyatHesaplaButon_Click(sender, e);
        }

        private void Temizle1Button_Click(object sender, EventArgs e)
        {
            // TextBox'larý temizle
            Ürün1Textbox.Clear();
            SandýkAdeti1Textbox.Clear();
            ToplamKilo1Textbox.Clear();
            BirimFiyat1Textbox.Clear();
            ToplamFiyat1Textbox.Clear();
            ToplamFiyat1Textbox.Text = "0";
            ToplamFiyatHesaplaButon_Click(sender, e);
        }
        private void Temizle2Button_Click(object sender, EventArgs e)
        {
            // TextBox'larý temizle
            Ürün2Textbox.Clear();
            SandýkAdeti2Textbox.Clear();
            ToplamKilo2Textbox.Clear();
            BirimFiyat2Textbox.Clear();
            ToplamFiyat2Textbox.Clear();
            ToplamFiyat2Textbox.Text = "0";
            ToplamFiyatHesaplaButon_Click(sender, e);
        }
        private void Temizle3Button_Click(object sender, EventArgs e)
        {
            // TextBox'larý temizle
            Ürün3Textbox.Clear();
            SandýkAdeti3Textbox.Clear();
            ToplamKilo3Textbox.Clear();
            BirimFiyat3Textbox.Clear();
            ToplamFiyat3Textbox.Clear();
            ToplamFiyat3Textbox.Text = "0";
            ToplamFiyatHesaplaButon_Click(sender, e);
        }
        private void Temizle4Button_Click(object sender, EventArgs e)
        {
            // TextBox'larý temizle
            Ürün4Textbox.Clear();
            SandýkAdeti4Textbox.Clear();
            ToplamKilo4Textbox.Clear();
            BirimFiyat4Textbox.Clear();
            ToplamFiyat4Textbox.Clear();
            ToplamFiyat4Textbox.Text = "0";
            ToplamFiyatHesaplaButon_Click(sender, e);
        }

        private void Temizle5Button_Click(object sender, EventArgs e)
        {
            // TextBox'larý temizle
            Ürün5Textbox.Clear();
            SandýkAdeti5Textbox.Clear();
            ToplamKilo5Textbox.Clear();
            BirimFiyat5Textbox.Clear();
            ToplamFiyat5Textbox.Clear();
            ToplamFiyat5Textbox.Text = "0";
            ToplamFiyatHesaplaButon_Click(sender, e);
        }
        private void TümünüTemizleButton_Click(object sender, EventArgs e)
        {
            Temizle1Button_Click(sender, e);
            Temizle2Button_Click(sender, e);
            Temizle3Button_Click(sender, e);
            Temizle4Button_Click(sender, e);
            Temizle5Button_Click(sender, e);
            MüþteriAdýTextbox.Clear();
        }


        private void YazdýrButton_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", 580, 1000); // Kaðýt geniþliði 58 mm ve uzunluðu 100 mm (örnektir)
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Genel ayarlar
            int x = 5; // Sol kenardan baþlangýç
            int y = 5; // Üst kenardan baþlangýç
            int toplamWidth = e.PageBounds.Width - 10; // Kaðýdýn geniþliði
            int currentY = y;

            Font titleFont = new Font("Arial", 10, FontStyle.Bold);
            Font regularFont = new Font("Arial", 8);
            Pen blackPen = new Pen(Color.Black);

            // Baþlýk yazdýrma
            e.Graphics.DrawString("Satýþ Fiþi", titleFont, Brushes.Black, x, currentY);
            currentY += 20;

            // Baþlýklar
            string[] headers = { "Ürün", "Adet", "Kilo", "Birim Fiyat", "Ara Toplam" };
            int[] columnWidths = new int[headers.Length];

            // Ürün sütun geniþliði hesaplama
            int urunColumnWidth = toplamWidth / 2;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    string urunAdi = row.Cells[2].Value.ToString();
                    int urunAdiWidth = (int)e.Graphics.MeasureString(urunAdi, regularFont).Width;
                    if (urunAdiWidth > urunColumnWidth)
                    {
                        urunColumnWidth = urunAdiWidth + 10;
                    }
                }
            }
            columnWidths[0] = urunColumnWidth;

            // Kalan alaný diðer sütunlara daðýt
            int kalanWidth = toplamWidth - urunColumnWidth;
            int otherColumnWidth = kalanWidth / (headers.Length - 1);
            for (int i = 1; i < headers.Length; i++)
            {
                columnWidths[i] = otherColumnWidth;
            }

            // Baþlýk satýrýný yazdýr ve çizgiler ekle
            int headerX = x;
            for (int i = 0; i < headers.Length; i++)
            {
                e.Graphics.DrawString(headers[i], titleFont, Brushes.Black, headerX, currentY);
                e.Graphics.DrawRectangle(blackPen, headerX, currentY, columnWidths[i], 20); // Baþlýk için çizgi
                headerX += columnWidths[i];
            }
            currentY += 20;
            x = 5;

            // Satýþ bilgilerini yazdýr ve her hücrenin etrafýna çizgi ekle
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    string urunAdi = row.Cells[2].Value?.ToString() ?? "";
                    string adet = row.Cells[3].Value?.ToString() ?? "";
                    string kilo = row.Cells[4].Value?.ToString() ?? "";
                    string birimFiyat = row.Cells[5].Value?.ToString() ?? "";
                    string araToplam = row.Cells[6].Value?.ToString() ?? "";

                    int cellX = x;
                    e.Graphics.DrawString(urunAdi, regularFont, Brushes.Black, cellX, currentY);
                    e.Graphics.DrawRectangle(blackPen, cellX, currentY, columnWidths[0], 20);
                    cellX += columnWidths[0];

                    e.Graphics.DrawString(adet, regularFont, Brushes.Black, cellX, currentY);
                    e.Graphics.DrawRectangle(blackPen, cellX, currentY, columnWidths[1], 20);
                    cellX += columnWidths[1];

                    e.Graphics.DrawString(kilo, regularFont, Brushes.Black, cellX, currentY);
                    e.Graphics.DrawRectangle(blackPen, cellX, currentY, columnWidths[2], 20);
                    cellX += columnWidths[2];

                    e.Graphics.DrawString(birimFiyat, regularFont, Brushes.Black, cellX, currentY);
                    e.Graphics.DrawRectangle(blackPen, cellX, currentY, columnWidths[3], 20);
                    cellX += columnWidths[3];

                    e.Graphics.DrawString(araToplam, regularFont, Brushes.Black, cellX, currentY);
                    e.Graphics.DrawRectangle(blackPen, cellX, currentY, columnWidths[4], 20);

                    currentY += 20;
                }
            }

            // Toplam Fiyat
            currentY += 10;
            e.Graphics.DrawString($"Toplam: {ToplamFiyatTextbox.Text} TL", titleFont, Brushes.Black, x, currentY);
        }



        private void ToplamFiyatTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
