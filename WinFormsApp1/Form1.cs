using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
                MessageBox.Show("M��teri ad� ve soyad� giriniz.");
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

                    // DataGridView'e eklemek i�in
                    dataGridView.Rows.Add(date, customerInfo, productName, numberOfCrates, totalWeight, unitPrice, subtotalPrice);

                    // TextBox'lar� temizle
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

                    // DataGridView'e eklemek i�in
                    dataGridView.Rows.Add(date, customerInfo, productName, numberOfCrates, totalWeight, unitPrice, subtotalPrice);

                    // TextBox'lar� temizle
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

                    // DataGridView'e eklemek i�in
                    dataGridView.Rows.Add(date, customerInfo, productName, numberOfCrates, totalWeight, unitPrice, subtotalPrice);

                    // TextBox'lar� temizle
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

                    // DataGridView'e eklemek i�in
                    dataGridView.Rows.Add(date, customerInfo, productName, numberOfCrates, totalWeight, unitPrice, subtotalPrice);
                }
            }
            CalculateGeneralTotalPrice();
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // E�er ToplamKilo veya BirimFiyat h�cresi de�i�tiyse toplam fiyat� hesapla
            if (dataGridView.Columns[e.ColumnIndex].Name == "KiloKolon" ||
                dataGridView.Columns[e.ColumnIndex].Name == "BirimFiyatKolon")
            {
                UpdateRowTotal(e.RowIndex);
            }// Her de�i�iklikte t�m sat�rlar�n toplam fiyat�n� yeniden hesapla
            CalculateGeneralTotalPrice();
        }

        private void UpdateRowTotal(int rowIndex)
        {
            var row = dataGridView.Rows[rowIndex];

            // H�crelerdeki de�erleri al�p kontrol ediyoruz, bo�sa 0 varsay�yoruz
            decimal unitPrice = Convert.ToDecimal(row.Cells["BirimFiyatKolon"].Value ?? 0);
            decimal totalWeight = Convert.ToDecimal(row.Cells["KiloKolon"].Value ?? 0);

            // Toplam fiyat� hesapla ve ilgili h�creye yaz
            decimal totalPrice = unitPrice * totalWeight;
            row.Cells["AraToplamKolon"].Value = totalPrice;

            // Di�er t�m sat�rlardaki toplam fiyatlar�n genel toplam�n� hesapla
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

            //Fi� ��kt�s�n� kontrl i�in olu�turulmu� ve initilaze edilmi� dummy veriler
            CustomerInfoTextbox.Text = "Bu�ra �zcan";

            Product1Textbox.Text = "Domates";
            NumberofCrates1Textbox.Text = "2";
            TotalWeight1Textbox.Text = "20";
            UnitPrice1Textbox.Text = "25,36";

            Product2Textbox.Text = "Salatal�k";
            NumberofCrates2Textbox.Text = "3";
            TotalWeight2Textbox.Text = "45";
            UnitPrice2Textbox.Text = "28,95";

            Product3Textbox.Text = "K�v�rc�kMarulKaraman";
            NumberofCrates3Textbox.Text = "4";
            TotalWeight3Textbox.Text = "32";
            UnitPrice3Textbox.Text = "36,57";

            ZReading(sender, e);
        }

        private void Clear1Button_Click(object sender, EventArgs e)
        {
            // TextBox'lar� temizle
            Product1Textbox.Clear();
            NumberofCrates1Textbox.Clear();
            TotalWeight1Textbox.Clear();
            UnitPrice1Textbox.Clear();
            TotalPrice1Textbox.Clear();
            TotalPrice1Textbox.Text = "0";
        }

        private void Clear2Button_Click(object sender, EventArgs e)
        {
            // TextBox'lar� temizle
            Product2Textbox.Clear();
            NumberofCrates2Textbox.Clear();
            TotalWeight2Textbox.Clear();
            UnitPrice2Textbox.Clear();
            TotalPrice2Textbox.Clear();
            TotalPrice2Textbox.Text = "0";
        }

        private void Clear3Button_Click(object sender, EventArgs e)
        {
            // TextBox'lar� temizle
            Product3Textbox.Clear();
            NumberofCrates3Textbox.Clear();
            TotalWeight3Textbox.Clear();
            UnitPrice3Textbox.Clear();
            TotalPrice3Textbox.Clear();
            TotalPrice3Textbox.Text = "0";
        }

        private void Clear4Button_Click(object sender, EventArgs e)
        {
            // TextBox'lar� temizle
            Product4Textbox.Clear();
            NumberofCrates4Textbox.Clear();
            TotalWeight4Textbox.Clear();
            UnitPrice4Textbox.Clear();
            TotalPrice4Textbox.Clear();
            TotalPrice4Textbox.Text = "0";
        }

        private void Clear5Button_Click(object sender, EventArgs e)
        {
            // TextBox'lar� temizle
            Product5Textbox.Clear();
            NumberofCrates5Textbox.Clear();
            TotalWeight5Textbox.Clear();
            UnitPrice5Textbox.Clear();
            TotalPrice5Textbox.Clear();
            TotalPrice5Textbox.Text = "0";
        }

        private void T�m�n�TemizleButton_Click(object sender, EventArgs e)
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
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", 580, 1000); // Ka��t geni�li�i 58 mm ve uzunlu�u 100 mm (�rnektir)
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Genel ayarlar
            int x = 5; // Sol kenardan ba�lang��
            int y = 5; // �st kenardan ba�lang��
            int totalWidth = e.PageBounds.Width - 10; // Ka��d�n geni�li�i
            int currentY = y;

            Font titleFont = new Font("Arial", 10, FontStyle.Bold);
            Font regularFont = new Font("Arial", 8);
            Pen blackPen = new Pen(Color.Black);

            // M��teri ismini ve datei �ek ve yazd�r
            string customerInfo = CustomerInfoTextbox.Text;
            DateTime date = DateTime.Now;
            float generalTotalPrice = float.Parse(GeneralTotalPriceTextbox.Text);

            e.Graphics.DrawString($"M��teri: {customerInfo}", titleFont, Brushes.Black, x, currentY);
            currentY += 20;

            e.Graphics.DrawString($"Tarih: {date.ToString("dd/MM/yyyy HH:mm:ss")}", titleFont, Brushes.Black, x, currentY);
            currentY += 20;

            // "Sat�� Fi�i" ba�l���
            e.Graphics.DrawString("Sat�� Fi�i", titleFont, Brushes.Black, x, currentY);
            currentY += 20;

            // Ba�l�klar
            string[] headers = { "�r�n", "Adet", "Kilo", "Birim Fiyat", "Ara Toplam" };
            int[] columnWidths = new int[headers.Length];

            // �r�n s�tun geni�li�i hesaplama
            int productColumnWidth = totalWidth / 2;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    string productName = row.Cells[2].Value.ToString();
                    int productNameWidth = (int)e.Graphics.MeasureString(productName, regularFont).Width;
                    if (productNameWidth > productColumnWidth)
                    {
                        productColumnWidth = productNameWidth + 10;
                    }
                }
            }
            columnWidths[0] = productColumnWidth;

            // Kalan alan� di�er s�tunlara da��t
            int restWidth = totalWidth - productColumnWidth;
            int otherColumnWidth = restWidth / (headers.Length - 1);
            for (int i = 1; i < headers.Length; i++)
            {
                columnWidths[i] = otherColumnWidth;
            }

            // Ba�l�k sat�r�n� yazd�r ve �izgiler ekle
            int headerX = x;
            for (int i = 0; i < headers.Length; i++)
            {
                e.Graphics.DrawString(headers[i], titleFont, Brushes.Black, headerX, currentY);
                e.Graphics.DrawRectangle(blackPen, headerX, currentY, columnWidths[i], 20); // Ba�l�k i�in �izgi
                headerX += columnWidths[i];
            }
            currentY += 20;
            x = 5;

            // Sat�� bilgilerini yazd�r ve her h�crenin etraf�na �izgi ekle
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    string productName = row.Cells[2].Value?.ToString() ?? "";
                    string quantity = row.Cells[3].Value?.ToString() ?? "";
                    string weight = row.Cells[4].Value?.ToString() ?? "";
                    string unitPrice = row.Cells[5].Value?.ToString() ?? "";
                    string subtotalPrice = row.Cells[6].Value?.ToString() ?? "";

                    int cellX = x;
                    e.Graphics.DrawString(productName, regularFont, Brushes.Black, cellX, currentY);
                    e.Graphics.DrawRectangle(blackPen, cellX, currentY, columnWidths[0], 20);
                    cellX += columnWidths[0];

                    e.Graphics.DrawString(quantity, regularFont, Brushes.Black, cellX, currentY);
                    e.Graphics.DrawRectangle(blackPen, cellX, currentY, columnWidths[1], 20);
                    cellX += columnWidths[1];

                    e.Graphics.DrawString(weight, regularFont, Brushes.Black, cellX, currentY);
                    e.Graphics.DrawRectangle(blackPen, cellX, currentY, columnWidths[2], 20);
                    cellX += columnWidths[2];

                    e.Graphics.DrawString(unitPrice, regularFont, Brushes.Black, cellX, currentY);
                    e.Graphics.DrawRectangle(blackPen, cellX, currentY, columnWidths[3], 20);
                    cellX += columnWidths[3];

                    e.Graphics.DrawString(subtotalPrice, regularFont, Brushes.Black, cellX, currentY);
                    e.Graphics.DrawRectangle(blackPen, cellX, currentY, columnWidths[4], 20);

                    currentY += 20;
                }
            }

            // Toplam Fiyat
            currentY += 10;
            e.Graphics.DrawString($"Toplam: {GeneralTotalPriceTextbox.Text} TL", titleFont, Brushes.Black, x, currentY);

        }

        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            if (e.Cancel == false && e.PrintAction == PrintAction.PrintToPrinter)
            {
                string customerInfo = CustomerInfoTextbox.Text;
                DateTime date = DateTime.Now;
                float generalTotalPrice = float.Parse(GeneralTotalPriceTextbox.Text);

                AddSaleToDatabase(customerInfo, date, generalTotalPrice);

            }
        }

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
                float subtotalPrice = weight * unitPrice;
                subtotalPriceTextbox.Text = subtotalPrice.ToString();
            }
            else
            {
                subtotalPriceTextbox.Text = "0";
            }

            // Toplam fiyat� yeniden hesapla
            CalculateTotalPrice();
        }

        private void CalculateTotalPrice()
        {
            float totalPrice = 0;

            // T�m ara toplam TextBox'lar�n� kontrol ederek genel toplam� hesapla
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

                // satis_id'yi almak i�in son eklenen ID'yi getiriyoruz
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

                string ZReadingQuery = "SELECT Sum(A.ara_toplam) FROM (SELECT satis_tarih, satisdetaylari.urun_adi, satisdetaylari.sandik_adeti, satisdetaylari.toplam_kilo, satisdetaylari.birim_fiyat, satisdetaylari.ara_toplam FROM satis INNER JOIN satisdetaylari ON satis.satis_id = satisdetaylari.satis_id WHERE DATE(satis.satis_tarih) = curdate()) AS A;";
                MySqlCommand detayCmd = new MySqlCommand(ZReadingQuery, conn);

                // Sonucu ExecuteScalar ile oku
                object result = detayCmd.ExecuteScalar();

                // Null kontrol� yap ve sonucu g�ster
                if (result != null && result != DBNull.Value)
                {
                    decimal totalSales = Convert.ToDecimal(result);
                    MessageBox.Show("G�n Sonu Toplam Sat�� Tutar�: " + totalSales.ToString("C2"));
                }
                else
                {
                    MessageBox.Show("Bug�n i�in sat�� kayd� bulunamad�.");
                }
            }
        }
    }
}