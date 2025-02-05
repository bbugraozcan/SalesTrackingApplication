using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost;Database=deneme;User ID=root;Password=12345;";
        private bool printSuccessful = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddSaleButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CustomerInfoTextbox.Text))
            {
                MessageBox.Show("Müþteri adý ve soyadý giriniz.");
                return;
            }
            else
            {
                string customerInfo = CustomerInfoTextbox.Text;
                string date = DateTextBox.Text;
                string totalPrice = TotalPriceTextbox.Text;
                if (!string.IsNullOrEmpty(Product1Textbox.Text) &&
                    !string.IsNullOrEmpty(NumberofCrates1Textbox.Text) &&
                    !string.IsNullOrEmpty(TotalWeight1Textbox.Text) &&
                    !string.IsNullOrEmpty(UnitPrice1Textbox.Text) &&
                    !string.IsNullOrEmpty(TotalPrice1Textbox.Text))
                {
                    string productName = Product1Textbox.Text;
                    string numberOfCrates = NumberofCrates1Textbox.Text;
                    string totalWeight = TotalWeight1Textbox.Text;
                    string unitPrice = UnitPrice1Textbox.Text;
                    string subtotalPrice = TotalPrice1Textbox.Text;

                    // DataGridView'e eklemek için
                    dataGridView.Rows.Add(date, customerInfo, productName, numberOfCrates, totalWeight, unitPrice, subtotalPrice);

                    // TextBox'larý temizle
                    // Temizle1Button_Click(sender, e);
                }

                if (!string.IsNullOrEmpty(Product2Textbox.Text) &&
                    !string.IsNullOrEmpty(NumberofCrates2Textbox.Text) &&
                    !string.IsNullOrEmpty(TotalWeight2Textbox.Text) &&
                    !string.IsNullOrEmpty(UnitPrice2Textbox.Text) &&
                    !string.IsNullOrEmpty(TotalPrice2Textbox.Text))
                {
                    string productName = Product2Textbox.Text;
                    string numberOfCrates = NumberofCrates2Textbox.Text;
                    string totalWeight = TotalWeight2Textbox.Text;
                    string unitPrice = UnitPrice2Textbox.Text;
                    string subtotalPrice = TotalPrice2Textbox.Text;

                    // DataGridView'e eklemek için
                    dataGridView.Rows.Add(date, customerInfo, productName, numberOfCrates, totalWeight, unitPrice, subtotalPrice);

                    // TextBox'larý temizle
                    // Temizle2Button_Click(sender, e);
                }

                if (!string.IsNullOrEmpty(Product3Textbox.Text) &&
                    !string.IsNullOrEmpty(NumberofCrates3Textbox.Text) &&
                    !string.IsNullOrEmpty(TotalWeight3Textbox.Text) &&
                    !string.IsNullOrEmpty(UnitPrice3Textbox.Text) &&
                    !string.IsNullOrEmpty(TotalPrice3Textbox.Text))
                {
                    string productName = Product3Textbox.Text;
                    string numberOfCrates = NumberofCrates3Textbox.Text;
                    string totalWeight = TotalWeight3Textbox.Text;
                    string unitPrice = UnitPrice3Textbox.Text;
                    string subtotalPrice = TotalPrice3Textbox.Text;

                    // DataGridView'e eklemek için
                    dataGridView.Rows.Add(date, customerInfo, productName, numberOfCrates, totalWeight, unitPrice, subtotalPrice);

                    // TextBox'larý temizle
                    // Temizle3Button_Click(sender, e);
                }

                if (!string.IsNullOrEmpty(Product4Textbox.Text) &&
                    !string.IsNullOrEmpty(NumberofCrates4Textbox.Text) &&
                    !string.IsNullOrEmpty(TotalWeight4Textbox.Text) &&
                    !string.IsNullOrEmpty(UnitPrice4Textbox.Text) &&
                    !string.IsNullOrEmpty(TotalPrice4Textbox.Text))
                {
                    string productName = Product4Textbox.Text;
                    string numberOfCrates = NumberofCrates4Textbox.Text;
                    string totalWeight = TotalWeight4Textbox.Text;
                    string unitPrice = UnitPrice4Textbox.Text;
                    string subtotalPrice = TotalPrice4Textbox.Text;

                    // DataGridView'e eklemek için
                    dataGridView.Rows.Add(date, customerInfo, productName, numberOfCrates, totalWeight, unitPrice, subtotalPrice);
                }
            }
            CalculateGeneralTotalPrice();
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Eðer ToplamKilo veya BirimFiyat hücresi deðiþtiyse toplam fiyatý hesapla
            if (dataGridView.Columns[e.ColumnIndex].Name == "KiloKolon" ||
                dataGridView.Columns[e.ColumnIndex].Name == "BirimFiyatKolon")
            {
                UpdateRowTotal(e.RowIndex);
            }// Her deðiþiklikte tüm satýrlarýn toplam fiyatýný yeniden hesapla
            CalculateGeneralTotalPrice();
        }

        private void UpdateRowTotal(int rowIndex)
        {
            var row = dataGridView.Rows[rowIndex];

            // Hücrelerdeki deðerleri alýp kontrol ediyoruz, boþsa 0 varsayýyoruz
            float unitPrice = float.Parse(row.Cells["BirimFiyatKolon"].Value.ToString());
            float totalWeight = float.Parse(row.Cells["KiloKolon"].Value.ToString());

            // Toplam fiyatý hesapla ve ilgili hücreye yaz
            double totalPrice = Math.Round(unitPrice * totalWeight, 2, MidpointRounding.AwayFromZero);
            row.Cells["AraToplamKolon"].Value = totalPrice;

            // Diðer tüm satýrlardaki toplam fiyatlarýn genel toplamýný hesapla
            CalculateGeneralTotalPrice();
        }

        private void dataGridView_RowsRemoved(object sender, EventArgs e)
        {
            CalculateGeneralTotalPrice();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            printDocument1.EndPrint += new PrintEventHandler(printDocument1_EndPrint);

            DateTime now = DateTime.Now;
            string formattedDate = now.ToString("dd/MM/yyyy");
            DateTextBox.Text = formattedDate;

        }

        private void Clear1Button_Click(object sender, EventArgs e)
        {
            // TextBox'larý temizle
            Product1Textbox.Clear();
            NumberofCrates1Textbox.Clear();
            TotalWeight1Textbox.Clear();
            UnitPrice1Textbox.Clear();
            TotalPrice1Textbox.Clear();
            TotalPrice1Textbox.Text = "0";
        }

        private void Clear2Button_Click(object sender, EventArgs e)
        {
            // TextBox'larý temizle
            Product2Textbox.Clear();
            NumberofCrates2Textbox.Clear();
            TotalWeight2Textbox.Clear();
            UnitPrice2Textbox.Clear();
            TotalPrice2Textbox.Clear();
            TotalPrice2Textbox.Text = "0";
        }

        private void Clear3Button_Click(object sender, EventArgs e)
        {
            // TextBox'larý temizle
            Product3Textbox.Clear();
            NumberofCrates3Textbox.Clear();
            TotalWeight3Textbox.Clear();
            UnitPrice3Textbox.Clear();
            TotalPrice3Textbox.Clear();
            TotalPrice3Textbox.Text = "0";
        }

        private void Clear4Button_Click(object sender, EventArgs e)
        {
            // TextBox'larý temizle
            Product4Textbox.Clear();
            NumberofCrates4Textbox.Clear();
            TotalWeight4Textbox.Clear();
            UnitPrice4Textbox.Clear();
            TotalPrice4Textbox.Clear();
            TotalPrice4Textbox.Text = "0";
        }

        private void Clear5Button_Click(object sender, EventArgs e)
        {
            // TextBox'larý temizle
            Product5Textbox.Clear();
            NumberofCrates5Textbox.Clear();
            TotalWeight5Textbox.Clear();
            UnitPrice5Textbox.Clear();
            TotalPrice5Textbox.Clear();
            TotalPrice5Textbox.Text = "0";
        }

        private void TümünüTemizleButton_Click(object sender, EventArgs e)
        {
            Clear1Button_Click(sender, e);
            Clear2Button_Click(sender, e);
            Clear3Button_Click(sender, e);
            Clear4Button_Click(sender, e);
            Clear5Button_Click(sender, e);
            CustomerInfoTextbox.Clear();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            //printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", 800, 1000); // Kaðýt geniþliði 58 mm ve uzunluðu 100 mm (örnektir)
            //printPreviewDialog1.ShowDialog();
            //PrintReceipt();
            PrintPreview();
        }

        private void PrintPreview()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("80mm", 300, 500); // 80mm termal kaðýt boyutu

            printDocument.PrintPage += (sender, e) =>
            {
                Font font = new Font("Consolas", 9); // Monospace font kullanýlýyor
                float yPos = 10;
                float leftMargin = 5;
                int maxWidth = 280; // 80mm termal kaðýt geniþliði

                StringFormat formatRight = new StringFormat() { Alignment = StringAlignment.Far };
                StringFormat formatCenter = new StringFormat() { Alignment = StringAlignment.Center };

                // Baþlýk
                e.Graphics.DrawString("=== SATIÞ FÝÞÝ ===", font, Brushes.Black, new RectangleF(leftMargin, yPos, maxWidth, 20), formatCenter);
                yPos += 20;

                // Müþteri Bilgileri ve Tarih
                e.Graphics.DrawString($"Müþteri: {CustomerInfoTextbox.Text}", font, Brushes.Black, leftMargin, yPos);
                yPos += 20;
                e.Graphics.DrawString($"Tarih: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", font, Brushes.Black, leftMargin, yPos);
                yPos += 20;

                // Çizgi
                e.Graphics.DrawString(new string('-', 42), font, Brushes.Black, leftMargin, yPos);
                yPos += 20;

                // **Sütun baþlýklarý**
                int col1 = 0;   // Ürün
                int col2 = 100; // Adet
                int col3 = 140; // Kilo
                int col4 = 180; // Fiyat
                int col5 = 240; // Ara Toplam

                e.Graphics.DrawString("Ürün", font, Brushes.Black, new RectangleF(leftMargin + col1, yPos, col2 - col1, 20));
                e.Graphics.DrawString("Adet", font, Brushes.Black, new RectangleF(leftMargin + col2, yPos, col3 - col2, 20), formatRight);
                e.Graphics.DrawString("Kilo", font, Brushes.Black, new RectangleF(leftMargin + col3, yPos, col4 - col3, 20), formatRight);
                e.Graphics.DrawString("Fiyat", font, Brushes.Black, new RectangleF(leftMargin + col4, yPos, col5 - col4, 20), formatRight);
                e.Graphics.DrawString("AraToplam", font, Brushes.Black, new RectangleF(leftMargin + col5, yPos, maxWidth - col5, 20), formatRight);
                yPos += 20;

                // **Ürün Listesi**
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Cells[2].Value != null)
                    {
                        string productName = row.Cells[2].Value?.ToString() ?? "";
                        string quantity = row.Cells[3].Value?.ToString() ?? "";
                        string weight = row.Cells[4].Value?.ToString() ?? "";
                        string unitPrice = row.Cells[5].Value?.ToString() ?? "";
                        string subtotalPrice = row.Cells[6].Value?.ToString() ?? "";

                        // Ürün ismi
                        e.Graphics.DrawString(productName, font, Brushes.Black, new RectangleF(leftMargin + col1, yPos, col2 - col1, 20));

                        // Miktar ve fiyat bilgileri
                        e.Graphics.DrawString(quantity, font, Brushes.Black, new RectangleF(leftMargin + col2, yPos, col3 - col2, 20), formatRight);
                        e.Graphics.DrawString(weight, font, Brushes.Black, new RectangleF(leftMargin + col3, yPos, col4 - col3, 20), formatRight);
                        e.Graphics.DrawString(unitPrice, font, Brushes.Black, new RectangleF(leftMargin + col4, yPos, col5 - col4, 20), formatRight);
                        e.Graphics.DrawString(subtotalPrice, font, Brushes.Black, new RectangleF(leftMargin + col5, yPos, maxWidth - col5, 20), formatRight);

                        yPos += 20;
                    }
                }

                // Toplam Fiyat
                yPos += 10;
                e.Graphics.DrawString($"Toplam: {GeneralTotalPriceTextbox.Text} TL", font, Brushes.Black, new RectangleF(leftMargin, yPos, maxWidth, 20), formatRight);
                yPos += 30;

                // Çizgi ve kapanýþ mesajý
                e.Graphics.DrawString(new string('-', 42), font, Brushes.Black, leftMargin, yPos);
            };

            printDocument.EndPrint += (sender, e) =>
            {
                if (e.Cancel == false && e.PrintAction == PrintAction.PrintToPrinter)
                {
                    string customerInfo = CustomerInfoTextbox.Text;
                    DateTime date = DateTime.Now;
                    float generalTotalPrice = float.Parse(GeneralTotalPriceTextbox.Text);

                    AddSaleToDatabase(customerInfo, date, generalTotalPrice);

                }
            };

            // Önizleme penceresi
            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDocument
            };

            previewDialog.ShowDialog();
        } //escpos çýktýsýný görmek için yazýldý, silinebilirs

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Genel ayarlar
            int x = 5; // Sol kenardan baþlangýç
            int y = 5; // Üst kenardan baþlangýç
            int totalWidth = e.PageBounds.Width - 10; // Kaðýdýn geniþliði
            int currentY = y;

            Font titleFont = new Font("Arial", 10, FontStyle.Bold);
            Font regularFont = new Font("Arial", 8);
            Pen blackPen = new Pen(Color.Black);

            // Müþteri ismini ve tarihi yazdýr
            string customerInfo = CustomerInfoTextbox.Text;
            DateTime date = DateTime.Now;

            e.Graphics.DrawString($"Müþteri: {customerInfo}", titleFont, Brushes.Black, x, currentY);
            currentY += 20;

            e.Graphics.DrawString($"Tarih: {date.ToString("dd/MM/yyyy HH:mm:ss")}", titleFont, Brushes.Black, x, currentY);
            currentY += 20;

            // "Satýþ Fiþi" baþlýðý
            e.Graphics.DrawString("Satýþ Fiþi", titleFont, Brushes.Black, x, currentY);
            currentY += 20;

            // Sütun baþlýklarý
            string[] headers = { "Adet", "Kilo", "Birim Fiyat", "Ara Toplam" };
            int[] columnWidths = { 50, 50, 100, 100 }; // Sütun geniþlikleri

            // Her ürün için yazdýrma
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    // Ürün adý baþlýk olarak yazdýrýlýr
                    string productName = row.Cells[2].Value?.ToString() ?? "";
                    e.Graphics.DrawString($"Ürün: {productName}", titleFont, Brushes.Black, x, currentY);
                    currentY += 20;

                    // Sütun baþlýklarý yazdýrýlýr
                    int headerX = x;
                    for (int i = 0; i < headers.Length; i++)
                    {
                        e.Graphics.DrawString(headers[i], titleFont, Brushes.Black, headerX, currentY);
                        e.Graphics.DrawRectangle(blackPen, headerX, currentY, columnWidths[i], 20);
                        headerX += columnWidths[i];
                    }
                    currentY += 20;

                    // Ürüne ait veriler yazdýrýlýr
                    string quantity = row.Cells[3].Value?.ToString() ?? "";
                    string weight = row.Cells[4].Value?.ToString() ?? "";
                    string unitPrice = row.Cells[5].Value?.ToString() ?? "";
                    string subtotalPrice = row.Cells[6].Value?.ToString() ?? "";

                    int cellX = x;
                    e.Graphics.DrawString(quantity, regularFont, Brushes.Black, cellX, currentY);
                    e.Graphics.DrawRectangle(blackPen, cellX, currentY, columnWidths[0], 20);
                    cellX += columnWidths[0];

                    e.Graphics.DrawString(weight, regularFont, Brushes.Black, cellX, currentY);
                    e.Graphics.DrawRectangle(blackPen, cellX, currentY, columnWidths[1], 20);
                    cellX += columnWidths[1];

                    e.Graphics.DrawString(unitPrice, regularFont, Brushes.Black, cellX, currentY);
                    e.Graphics.DrawRectangle(blackPen, cellX, currentY, columnWidths[2], 20);
                    cellX += columnWidths[2];

                    e.Graphics.DrawString(subtotalPrice, regularFont, Brushes.Black, cellX, currentY);
                    e.Graphics.DrawRectangle(blackPen, cellX, currentY, columnWidths[3], 20);

                    currentY += 40; // Bir sonraki ürün için boþluk býrak
                }

                // Sayfa sýnýrlarýný kontrol et
                if (currentY > e.MarginBounds.Height)
                {
                    e.HasMorePages = true; // Yeni sayfa gerektiðini belirt
                    return;
                }
            }

            // Toplam Fiyat
            currentY += 10;
            e.Graphics.DrawString($"Toplam: {GeneralTotalPriceTextbox.Text} TL", titleFont, Brushes.Black, x, currentY);
            currentY += 40;

            // Fiþ sonu çizgisi
            e.Graphics.DrawLine(blackPen, x, currentY, totalWidth, currentY);
            currentY += 10;

            // Sayfa uzunluðunu belirle
            e.HasMorePages = false;
        } //silinebilir

        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            if (e.Cancel == false && e.PrintAction == PrintAction.PrintToPrinter)
            {
                string customerInfo = CustomerInfoTextbox.Text;
                DateTime date = DateTime.Now;
                float generalTotalPrice = float.Parse(GeneralTotalPriceTextbox.Text);

                AddSaleToDatabase(customerInfo, date, generalTotalPrice);

            }
        } //silinebilir

        private void TotalWeight1Textbox_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotalPrice(TotalWeight1Textbox, UnitPrice1Textbox, TotalPrice1Textbox);
        }

        private void UnitPrice1Textbox_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotalPrice(TotalWeight1Textbox, UnitPrice1Textbox, TotalPrice1Textbox);
        }

        private void TotalWeight2Textbox_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotalPrice(TotalWeight2Textbox, UnitPrice2Textbox, TotalPrice2Textbox);
        }

        private void UnitPrice2Textbox_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotalPrice(TotalWeight2Textbox, UnitPrice2Textbox, TotalPrice2Textbox);
        }

        private void TotalWeight3Textbox_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotalPrice(TotalWeight3Textbox, UnitPrice3Textbox, TotalPrice3Textbox);
        }

        private void UnitPrice3Textbox_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotalPrice(TotalWeight3Textbox, UnitPrice3Textbox, TotalPrice3Textbox);
        }

        private void TotalWeight4Textbox_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotalPrice(TotalWeight4Textbox, UnitPrice4Textbox, TotalPrice4Textbox);
        }

        private void UnitPrice4Textbox_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotalPrice(TotalWeight4Textbox, UnitPrice4Textbox, TotalPrice4Textbox);
        }

        private void TotalWeight5Textbox_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotalPrice(TotalWeight5Textbox, UnitPrice5Textbox, TotalPrice5Textbox);
        }

        private void UnitPrice5Textbox_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotalPrice(TotalWeight5Textbox, UnitPrice5Textbox, TotalPrice5Textbox);
        }

        private void CalculateSubtotalPrice(TextBox weightTextbox, TextBox unitPriceTextbox, TextBox subtotalPriceTextbox)
        {
            if (float.TryParse(weightTextbox.Text, out float weight) && float.TryParse(unitPriceTextbox.Text, out float unitPrice))
            {
                //float subtotalPrice = weight * unitPrice;
                double subtotalPrice = Math.Round(weight * unitPrice, 2, MidpointRounding.AwayFromZero);
                subtotalPriceTextbox.Text = subtotalPrice.ToString();
            }
            else
            {
                subtotalPriceTextbox.Text = "0";
            }

            // Toplam fiyatý yeniden hesapla
            CalculateTotalPrice();
        }

        private void CalculateTotalPrice()
        {
            float totalPrice = 0;

            // Tüm ara toplam TextBox'larýný kontrol ederek genel toplamý hesapla
            totalPrice += string.IsNullOrEmpty(TotalPrice1Textbox.Text) ? 0 : float.Parse(TotalPrice1Textbox.Text);
            totalPrice += string.IsNullOrEmpty(TotalPrice2Textbox.Text) ? 0 : float.Parse(TotalPrice2Textbox.Text);
            totalPrice += string.IsNullOrEmpty(TotalPrice3Textbox.Text) ? 0 : float.Parse(TotalPrice3Textbox.Text);
            totalPrice += string.IsNullOrEmpty(TotalPrice4Textbox.Text) ? 0 : float.Parse(TotalPrice4Textbox.Text);
            totalPrice += string.IsNullOrEmpty(TotalPrice5Textbox.Text) ? 0 : float.Parse(TotalPrice5Textbox.Text);

            TotalPriceTextbox.Text = totalPrice.ToString("0.00");
        }

        private void CalculateGeneralTotalPrice()
        {
            float generalTotalPrice = 0;
            if (dataGridView.Rows.Count == 0 || dataGridView.Rows.Count == 1 && dataGridView.Rows[0].IsNewRow)
            {
                GeneralTotalPriceTextbox.Text = "0";
                return;
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Cells[2].Value != null)
                    {
                        string subtotalPrice = row.Cells[6].Value?.ToString() ?? "";
                        generalTotalPrice += float.Parse(subtotalPrice);
                    }
                }
            }
            GeneralTotalPriceTextbox.Text = Convert.ToString(generalTotalPrice);
        }

        private void AddSaleToDatabase(string customerInfo, DateTime dateOfSale, float totalPrice)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // satis tablosuna veri ekleme
                string satisQuery = "INSERT INTO satis (musteri_bilgi, satis_tarih, toplam_fiyat) VALUES (@musteriBilgi, @satisTarih, @toplamFiyat)";
                MySqlCommand satisCmd = new MySqlCommand(satisQuery, conn);
                satisCmd.Parameters.AddWithValue("@musteriBilgi", customerInfo);
                satisCmd.Parameters.AddWithValue("@satisTarih", dateOfSale);
                satisCmd.Parameters.AddWithValue("@toplamFiyat", totalPrice);
                satisCmd.ExecuteNonQuery();

                // satis_id'yi almak için son eklenen ID'yi getiriyoruz
                int satisId = (int)satisCmd.LastInsertedId;


                // satisdetaylari tablosuna veri ekleme
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Cells[2].Value != null)
                    {
                        string detayQuery = "INSERT INTO satisdetaylari (satis_id, urun_adi, sandik_adeti, toplam_kilo, birim_fiyat, ara_toplam) VALUES (@satisId, @urunAdi, @sandikAdeti, @toplamKilo, @birimFiyat, @araToplam)";
                        MySqlCommand detayCmd = new MySqlCommand(detayQuery, conn);

                        string productName = row.Cells[2].Value.ToString();

                        string quantity = row.Cells[3].Value.ToString();
                        int quantityInt = int.Parse(quantity);

                        string weight = row.Cells[4].Value.ToString();
                        float weightFloat = float.Parse(weight);

                        string unitPrice = row.Cells[5].Value.ToString();
                        float unitPriceFloat = float.Parse(unitPrice);

                        string subtotalPrice = row.Cells[6].Value.ToString();
                        float subtotalPriceFloat = float.Parse(subtotalPrice);

                        detayCmd.Parameters.AddWithValue("@satisId", satisId);
                        detayCmd.Parameters.AddWithValue("@urunAdi", productName);
                        detayCmd.Parameters.AddWithValue("@sandikAdeti", quantityInt);
                        detayCmd.Parameters.AddWithValue("@toplamKilo", weightFloat);
                        detayCmd.Parameters.AddWithValue("@birimFiyat", unitPriceFloat);
                        detayCmd.Parameters.AddWithValue("@araToplam", subtotalPriceFloat);
                        detayCmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void ZReading(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string ZReadingQuery = "SELECT A.urun_adi AS \"Ürün Adý\", SUM(A.sandik_adeti) AS \"Toplam Sandýk Adeti\", " +
                                       "SUM(A.toplam_kilo) AS \"Toplam Kilo\", A.birim_fiyat AS \"Birim Fiyat\", " +
                                       "SUM(A.ara_toplam) AS \"Toplam Satýþ Fiyatý\", SUM(A.ara_toplam) AS \"Genel Toplam\" " +  // Toplam fiyat
                                       "FROM (SELECT satisdetaylari.*, satis.satis_tarih FROM satisdetaylari " +
                                       "INNER JOIN satis ON satisdetaylari.satis_id = satis.satis_id) AS A " +
                                       "WHERE DATE(A.satis_tarih) = CURDATE() " +
                                       "GROUP BY A.urun_adi, A.birim_fiyat ORDER BY A.urun_adi;";

                MySqlCommand cmd = new MySqlCommand(ZReadingQuery, conn);

                // ExecuteReader ile veri alýyoruz
                MySqlDataReader reader = cmd.ExecuteReader();

                // Fiþ yazdýrmaya baþlýyoruz
                PrintDocument printDocument = new PrintDocument();
                printDocument.DefaultPageSettings.PaperSize = new PaperSize("80mm", 300, 500);  // 80mm Termal kaðýt

                printDocument.PrintPage += (sender, e) =>
                {
                    Font font = new Font("Consolas", 9);  // Termal yazýcý için uygun font
                    float yPos = 10;
                    float leftMargin = 5;
                    int maxWidth = 280; // 80mm kaðýt için geniþlik

                    // Baþlýklar
                    e.Graphics.DrawString("=== GÜN SONU FÝÞÝ ===", font, Brushes.Black, leftMargin, yPos);
                    yPos += 20;

                    e.Graphics.DrawString($"Tarih: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", font, Brushes.Black, leftMargin, yPos);
                    yPos += 20;

                    e.Graphics.DrawString("---------------------------------", font, Brushes.Black, leftMargin, yPos);
                    yPos += 20;

                    // Sütun baþlýklarý
                    string header = "Ürün          Adet  Kilo  Fiyat  AraToplam";
                    e.Graphics.DrawString(header, font, Brushes.Black, leftMargin, yPos);
                    yPos += 20;

                    decimal totalSales = 0;  // Toplam satýþ fiyatý burada tutulacak

                    // Verileri yazdýr
                    while (reader.Read())
                    {
                        string productName = reader["Ürün Adý"].ToString();
                        string quantity = reader["Toplam Sandýk Adeti"].ToString();
                        string weight = reader["Toplam Kilo"].ToString();
                        string unitPrice = reader["Birim Fiyat"].ToString();
                        string subtotalPrice = reader["Toplam Satýþ Fiyatý"].ToString();

                        // Fiþe satýr ekleyelim
                        string line = $"{productName.PadRight(10)} {quantity.PadRight(4)} {weight.PadRight(4)} {unitPrice.PadRight(6)} {subtotalPrice.PadRight(8)}";
                        e.Graphics.DrawString(line, font, Brushes.Black, leftMargin, yPos);
                        yPos += 20;

                        // Toplam satýþ fiyatýný ekliyoruz
                        totalSales += Convert.ToDecimal(reader["Toplam Satýþ Fiyatý"]);
                    }

                    // Genel toplam satýþ fiyatý
                    e.Graphics.DrawString($"Toplam: {totalSales:C} TL", font, Brushes.Black, leftMargin, yPos);
                    yPos += 40;

                    e.Graphics.DrawString("---------------------------------", font, Brushes.Black, leftMargin, yPos);
                };

                // Yazdýrma iþlemi
                //printDocument.Print();

                // Önizleme penceresi
                PrintPreviewDialog previewDialog = new PrintPreviewDialog
                {
                    Document = printDocument
                };

                previewDialog.ShowDialog();
            }
        }

        private void PrintReceipt()
        {
            string printerName = "YazýcýDeneme"; // Yazýcýnýzýn adý

            StringBuilder receipt = new StringBuilder();

            // **1. Yazýcýyý sýfýrla**
            receipt.Append("\x1B\x40"); // ESC @ (Reset)

            // **2. Baþlýk Yazdýr (Ortalý)**
            receipt.Append("\x1B\x61\x01"); // Metni ortala
            receipt.Append("=== SATIÞ FÝÞÝ ===\n");
            receipt.Append("\x1B\x61\x00"); // Metni sola hizala
            receipt.Append("--------------------------------\n");

            // **3. Müþteri ve Tarih Bilgileri**
            string customerInfo = CustomerInfoTextbox.Text;
            string date = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            receipt.Append($"Müþteri: {customerInfo}\n");
            receipt.Append($"Tarih: {date}\n");
            receipt.Append("--------------------------------\n");

            // **4. Ürün Listesi Baþlýklarý**
            receipt.Append("Ürün        Adet  Kilo  BirimFiyat  AraToplam\n");
            receipt.Append("--------------------------------\n");

            // **5. Ürünleri Yazdýr**
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    string productName = row.Cells[2].Value?.ToString() ?? "";
                    string quantity = row.Cells[3].Value?.ToString() ?? "";
                    string weight = row.Cells[4].Value?.ToString() ?? "";
                    string unitPrice = row.Cells[5].Value?.ToString() ?? "";
                    string subtotalPrice = row.Cells[6].Value?.ToString() ?? "";

                    receipt.Append($"{productName.PadRight(10)} {quantity.PadRight(4)} {weight.PadRight(4)} {unitPrice.PadRight(10)} {subtotalPrice.PadRight(10)}\n");
                }
            }

            receipt.Append("--------------------------------\n");

            // **6. Toplam Fiyatý Yazdýr**
            receipt.Append($"Toplam: {GeneralTotalPriceTextbox.Text} TL\n");
            receipt.Append("--------------------------------\n");

            // **7. Teþekkür Mesajý**
            receipt.Append("\x1B\x61\x01"); // Metni ortala
            receipt.Append("Bizi tercih ettiðiniz için teþekkürler!\n");
            receipt.Append("\x1B\x61\x00"); // Metni sola hizala
            receipt.Append("--------------------------------\n");

            // **8. Kesme Komutu**
            receipt.Append("\x1D\x56\x41"); // Kaðýdý kes

            // **9. Yazýcýya Gönder**
            RawPrinterHelper.SendStringToPrinter(printerName, receipt.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZReading(sender, e);
        }
    }
    // **ESC/POS Komutlarýný Yazýcýya Gönderen Yardýmcý Sýnýf**
    public class RawPrinterHelper
    {
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA")]
        public static extern bool OpenPrinter(string pPrinterName, out IntPtr phPrinter, IntPtr pDefault);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter")]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter")]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, int dwCount, out int dwWritten);

        public static bool SendStringToPrinter(string printerName, string text)
        {
            IntPtr printerHandle;
            if (!OpenPrinter(printerName, out printerHandle, IntPtr.Zero)) return false;

            IntPtr pBytes = Marshal.StringToCoTaskMemAnsi(text);
            int dwWritten;
            bool success = WritePrinter(printerHandle, pBytes, text.Length, out dwWritten);
            Marshal.FreeCoTaskMem(pBytes);
            ClosePrinter(printerHandle);
            return success;
        }
    }
}