using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DatabaseConnection();
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

        // Belirtilen satýrdaki toplam fiyatý güncelleyen fonksiyon
        private void UpdateRowTotal(int rowIndex)
        {
            var row = dataGridView.Rows[rowIndex];

            // Hücrelerdeki deðerleri alýp kontrol ediyoruz, boþsa 0 varsayýyoruz
            decimal unitPrice = Convert.ToDecimal(row.Cells["BirimFiyatKolon"].Value ?? 0);
            decimal totalWeight = Convert.ToDecimal(row.Cells["KiloKolon"].Value ?? 0);

            // Toplam fiyatý hesapla ve ilgili hücreye yaz
            decimal totalPrice = unitPrice * totalWeight;
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
            DateTime now = DateTime.Now;
            string formattedDate = now.ToString("dd/MM/yyyy");
            DateTextBox.Text = formattedDate;

            //Fiþ çýktýsýný kontrl için oluþturulmuþ ve initilaze edilmiþ dummy veriler
            CustomerInfoTextbox.Text = "Buðra Özcan";

            Product1Textbox.Text = "Domates";
            NumberofCrates1Textbox.Text = "2";
            TotalWeight1Textbox.Text = "20";
            UnitPrice1Textbox.Text = "25,36";

            Product2Textbox.Text = "Salatalýk";
            NumberofCrates2Textbox.Text = "3";
            TotalWeight2Textbox.Text = "45";
            UnitPrice2Textbox.Text = "28,95";

            Product3Textbox.Text = "KývýrcýkMarulKaraman";
            NumberofCrates3Textbox.Text = "4";
            TotalWeight3Textbox.Text = "32";
            UnitPrice3Textbox.Text = "36,57";
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
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", 580, 1000); // Kaðýt geniþliði 58 mm ve uzunluðu 100 mm (örnektir)
            printPreviewDialog1.ShowDialog();
        }

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

            // Müþteri ismini ve datei çek ve yazdýr
            string customerInfo = CustomerInfoTextbox.Text;
            string date = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            e.Graphics.DrawString($"Müþteri: {customerInfo}", titleFont, Brushes.Black, x, currentY);
            currentY += 20;

            e.Graphics.DrawString($"Tarih: {date}", titleFont, Brushes.Black, x, currentY);
            currentY += 20;

            // "Satýþ Fiþi" baþlýðý
            e.Graphics.DrawString("Satýþ Fiþi", titleFont, Brushes.Black, x, currentY);
            currentY += 20;

            // Baþlýklar
            string[] headers = { "Ürün", "Adet", "Kilo", "Birim Fiyat", "Ara Toplam" };
            int[] columnWidths = new int[headers.Length];

            // Ürün sütun geniþliði hesaplama
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

            // Kalan alaný diðer sütunlara daðýt
            int restWidth = totalWidth - productColumnWidth;
            int otherColumnWidth = restWidth / (headers.Length - 1);
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

        // Ara toplam hesaplama fonksiyonu
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

            // Toplam fiyatý yeniden hesapla
            CalculateTotalPrice();
        }

        // Genel toplam fiyatý hesaplayacak fonksiyon
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

        private void DatabaseConnection()
        {
            // Baðlantý dizesini ayarlayýn (kendi veritabaný bilgilerinize göre güncelleyin)
            string connectionString = "Server=localhost;Database=deneme;User ID=root;Password=12345;";

            // Baðlantý nesnesi oluþturma
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Baðlantýyý açma
                    connection.Open();
                    Console.WriteLine("Baðlantý baþarýlý!");

                    // SQL sorgusu oluþturma
                    string query = "SELECT * FROM satis";

                    // Sorguyu çalýþtýrmak için komut nesnesi oluþturma
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Veri okumak için MySqlDataReader kullanma
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Örneðin ilk sütunu okuma
                                MessageBox.Show("Veritabanýna Baðlanýldý.");
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Baðlantý hatasý: " + ex.Message);
                }
                finally
                {
                    // Baðlantýyý kapatma
                    connection.Close();
                    Console.WriteLine("Baðlantý kapandý.");
                }
            }
        }
    }
}
