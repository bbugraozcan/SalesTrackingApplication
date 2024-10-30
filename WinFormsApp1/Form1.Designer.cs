namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Product1Textbox = new TextBox();
            NumberofCrates1Textbox = new TextBox();
            TotalWeight1Textbox = new TextBox();
            UnitPrice1Textbox = new TextBox();
            TotalPrice1Textbox = new TextBox();
            ÜrünLabel = new Label();
            SandıkAdetLabel = new Label();
            KiloLabel = new Label();
            BirimFiyatLabel = new Label();
            ToplamFiyatLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TotalPrice2Textbox = new TextBox();
            UnitPrice2Textbox = new TextBox();
            TotalWeight2Textbox = new TextBox();
            NumberofCrates2Textbox = new TextBox();
            Product2Textbox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            TotalPrice3Textbox = new TextBox();
            UnitPrice3Textbox = new TextBox();
            TotalWeight3Textbox = new TextBox();
            NumberofCrates3Textbox = new TextBox();
            Product3Textbox = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            TotalPrice4Textbox = new TextBox();
            UnitPrice4Textbox = new TextBox();
            TotalWeight4Textbox = new TextBox();
            NumberofCrates4Textbox = new TextBox();
            Product4Textbox = new TextBox();
            CustomerInfoTextbox = new TextBox();
            MüşteriLabel = new Label();
            TarihLabel = new Label();
            DateTextBox = new TextBox();
            dataGridView = new DataGridView();
            TarihKolon = new DataGridViewTextBoxColumn();
            MüşteriKolon = new DataGridViewTextBoxColumn();
            ÜrünKolon = new DataGridViewTextBoxColumn();
            SandıkAdetKolon = new DataGridViewTextBoxColumn();
            KiloKolon = new DataGridViewTextBoxColumn();
            BirimFiyatKolon = new DataGridViewTextBoxColumn();
            AraToplamKolon = new DataGridViewTextBoxColumn();
            AddSaleButton = new Button();
            label16 = new Label();
            TotalPriceTextbox = new TextBox();
            Clear1Button = new Button();
            Clear2Button = new Button();
            Clear3Button = new Button();
            Clear4Button = new Button();
            Clear5Button = new Button();
            ClearAllButton = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            PrintButton = new Button();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            TotalPrice5Textbox = new TextBox();
            UnitPrice5Textbox = new TextBox();
            TotalWeight5Textbox = new TextBox();
            NumberofCrates5Textbox = new TextBox();
            Product5Textbox = new TextBox();
            GeneralTotalPriceTextbox = new TextBox();
            label22 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // Product1Textbox
            // 
            Product1Textbox.Location = new Point(13, 103);
            Product1Textbox.Name = "Product1Textbox";
            Product1Textbox.Size = new Size(125, 27);
            Product1Textbox.TabIndex = 0;
            // 
            // NumberofCrates1Textbox
            // 
            NumberofCrates1Textbox.Location = new Point(144, 103);
            NumberofCrates1Textbox.Name = "NumberofCrates1Textbox";
            NumberofCrates1Textbox.Size = new Size(125, 27);
            NumberofCrates1Textbox.TabIndex = 1;
            // 
            // TotalWeight1Textbox
            // 
            TotalWeight1Textbox.Location = new Point(275, 103);
            TotalWeight1Textbox.Name = "TotalWeight1Textbox";
            TotalWeight1Textbox.Size = new Size(125, 27);
            TotalWeight1Textbox.TabIndex = 2;
            TotalWeight1Textbox.TextChanged += TotalWeight1Textbox_TextChanged;
            // 
            // UnitPrice1Textbox
            // 
            UnitPrice1Textbox.Location = new Point(406, 103);
            UnitPrice1Textbox.Name = "UnitPrice1Textbox";
            UnitPrice1Textbox.Size = new Size(125, 27);
            UnitPrice1Textbox.TabIndex = 3;
            UnitPrice1Textbox.TextChanged += UnitPrice1Textbox_TextChanged;
            // 
            // TotalPrice1Textbox
            // 
            TotalPrice1Textbox.Location = new Point(537, 103);
            TotalPrice1Textbox.Name = "TotalPrice1Textbox";
            TotalPrice1Textbox.ReadOnly = true;
            TotalPrice1Textbox.Size = new Size(125, 27);
            TotalPrice1Textbox.TabIndex = 4;
            TotalPrice1Textbox.Text = "0";
            // 
            // ÜrünLabel
            // 
            ÜrünLabel.AutoSize = true;
            ÜrünLabel.Location = new Point(13, 80);
            ÜrünLabel.Name = "ÜrünLabel";
            ÜrünLabel.Size = new Size(40, 20);
            ÜrünLabel.TabIndex = 5;
            ÜrünLabel.Text = "Ürün";
            // 
            // SandıkAdetLabel
            // 
            SandıkAdetLabel.AutoSize = true;
            SandıkAdetLabel.Location = new Point(144, 80);
            SandıkAdetLabel.Name = "SandıkAdetLabel";
            SandıkAdetLabel.Size = new Size(93, 20);
            SandıkAdetLabel.TabIndex = 6;
            SandıkAdetLabel.Text = "Sandık Adeti";
            // 
            // KiloLabel
            // 
            KiloLabel.AutoSize = true;
            KiloLabel.Location = new Point(275, 80);
            KiloLabel.Name = "KiloLabel";
            KiloLabel.Size = new Size(89, 20);
            KiloLabel.TabIndex = 7;
            KiloLabel.Text = "Toplam Kilo";
            // 
            // BirimFiyatLabel
            // 
            BirimFiyatLabel.AutoSize = true;
            BirimFiyatLabel.Location = new Point(406, 80);
            BirimFiyatLabel.Name = "BirimFiyatLabel";
            BirimFiyatLabel.Size = new Size(79, 20);
            BirimFiyatLabel.TabIndex = 8;
            BirimFiyatLabel.Text = "Birim Fiyat";
            // 
            // ToplamFiyatLabel
            // 
            ToplamFiyatLabel.AutoSize = true;
            ToplamFiyatLabel.Location = new Point(537, 80);
            ToplamFiyatLabel.Name = "ToplamFiyatLabel";
            ToplamFiyatLabel.Size = new Size(94, 20);
            ToplamFiyatLabel.TabIndex = 9;
            ToplamFiyatLabel.Text = "Toplam Fiyat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(537, 144);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 19;
            label1.Text = "Toplam Fiyat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(406, 144);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 18;
            label2.Text = "Birim Fiyat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 144);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 17;
            label3.Text = "Toplam Kilo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 144);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 16;
            label4.Text = "Sandık Adeti";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 144);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 15;
            label5.Text = "Ürün";
            // 
            // TotalPrice2Textbox
            // 
            TotalPrice2Textbox.Location = new Point(537, 167);
            TotalPrice2Textbox.Name = "TotalPrice2Textbox";
            TotalPrice2Textbox.ReadOnly = true;
            TotalPrice2Textbox.Size = new Size(125, 27);
            TotalPrice2Textbox.TabIndex = 14;
            TotalPrice2Textbox.Text = "0";
            // 
            // UnitPrice2Textbox
            // 
            UnitPrice2Textbox.Location = new Point(406, 167);
            UnitPrice2Textbox.Name = "UnitPrice2Textbox";
            UnitPrice2Textbox.Size = new Size(125, 27);
            UnitPrice2Textbox.TabIndex = 13;
            UnitPrice2Textbox.TextChanged += UnitPrice2Textbox_TextChanged;
            // 
            // TotalWeight2Textbox
            // 
            TotalWeight2Textbox.Location = new Point(275, 167);
            TotalWeight2Textbox.Name = "TotalWeight2Textbox";
            TotalWeight2Textbox.Size = new Size(125, 27);
            TotalWeight2Textbox.TabIndex = 12;
            TotalWeight2Textbox.TextChanged += TotalWeight2Textbox_TextChanged;
            // 
            // NumberofCrates2Textbox
            // 
            NumberofCrates2Textbox.Location = new Point(144, 167);
            NumberofCrates2Textbox.Name = "NumberofCrates2Textbox";
            NumberofCrates2Textbox.Size = new Size(125, 27);
            NumberofCrates2Textbox.TabIndex = 11;
            // 
            // Product2Textbox
            // 
            Product2Textbox.Location = new Point(13, 167);
            Product2Textbox.Name = "Product2Textbox";
            Product2Textbox.Size = new Size(125, 27);
            Product2Textbox.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(537, 208);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 29;
            label6.Text = "Toplam Fiyat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(406, 208);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 28;
            label7.Text = "Birim Fiyat";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(275, 208);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 27;
            label8.Text = "Toplam Kilo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(144, 208);
            label9.Name = "label9";
            label9.Size = new Size(93, 20);
            label9.TabIndex = 26;
            label9.Text = "Sandık Adeti";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 208);
            label10.Name = "label10";
            label10.Size = new Size(40, 20);
            label10.TabIndex = 25;
            label10.Text = "Ürün";
            // 
            // TotalPrice3Textbox
            // 
            TotalPrice3Textbox.Location = new Point(537, 231);
            TotalPrice3Textbox.Name = "TotalPrice3Textbox";
            TotalPrice3Textbox.ReadOnly = true;
            TotalPrice3Textbox.Size = new Size(125, 27);
            TotalPrice3Textbox.TabIndex = 24;
            TotalPrice3Textbox.Text = "0";
            // 
            // UnitPrice3Textbox
            // 
            UnitPrice3Textbox.Location = new Point(406, 231);
            UnitPrice3Textbox.Name = "UnitPrice3Textbox";
            UnitPrice3Textbox.Size = new Size(125, 27);
            UnitPrice3Textbox.TabIndex = 23;
            UnitPrice3Textbox.TextChanged += UnitPrice3Textbox_TextChanged;
            // 
            // TotalWeight3Textbox
            // 
            TotalWeight3Textbox.Location = new Point(275, 231);
            TotalWeight3Textbox.Name = "TotalWeight3Textbox";
            TotalWeight3Textbox.Size = new Size(125, 27);
            TotalWeight3Textbox.TabIndex = 22;
            TotalWeight3Textbox.TextChanged += TotalWeight3Textbox_TextChanged;
            // 
            // NumberofCrates3Textbox
            // 
            NumberofCrates3Textbox.Location = new Point(144, 231);
            NumberofCrates3Textbox.Name = "NumberofCrates3Textbox";
            NumberofCrates3Textbox.Size = new Size(125, 27);
            NumberofCrates3Textbox.TabIndex = 21;
            // 
            // Product3Textbox
            // 
            Product3Textbox.Location = new Point(13, 231);
            Product3Textbox.Name = "Product3Textbox";
            Product3Textbox.Size = new Size(125, 27);
            Product3Textbox.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(537, 271);
            label11.Name = "label11";
            label11.Size = new Size(94, 20);
            label11.TabIndex = 39;
            label11.Text = "Toplam Fiyat";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(406, 271);
            label12.Name = "label12";
            label12.Size = new Size(79, 20);
            label12.TabIndex = 38;
            label12.Text = "Birim Fiyat";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(275, 271);
            label13.Name = "label13";
            label13.Size = new Size(89, 20);
            label13.TabIndex = 37;
            label13.Text = "Toplam Kilo";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(144, 271);
            label14.Name = "label14";
            label14.Size = new Size(93, 20);
            label14.TabIndex = 36;
            label14.Text = "Sandık Adeti";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(13, 271);
            label15.Name = "label15";
            label15.Size = new Size(40, 20);
            label15.TabIndex = 35;
            label15.Text = "Ürün";
            // 
            // TotalPrice4Textbox
            // 
            TotalPrice4Textbox.Location = new Point(537, 294);
            TotalPrice4Textbox.Name = "TotalPrice4Textbox";
            TotalPrice4Textbox.ReadOnly = true;
            TotalPrice4Textbox.Size = new Size(125, 27);
            TotalPrice4Textbox.TabIndex = 34;
            TotalPrice4Textbox.Text = "0";
            // 
            // UnitPrice4Textbox
            // 
            UnitPrice4Textbox.Location = new Point(406, 294);
            UnitPrice4Textbox.Name = "UnitPrice4Textbox";
            UnitPrice4Textbox.Size = new Size(125, 27);
            UnitPrice4Textbox.TabIndex = 33;
            UnitPrice4Textbox.TextChanged += UnitPrice4Textbox_TextChanged;
            // 
            // TotalWeight4Textbox
            // 
            TotalWeight4Textbox.Location = new Point(275, 294);
            TotalWeight4Textbox.Name = "TotalWeight4Textbox";
            TotalWeight4Textbox.Size = new Size(125, 27);
            TotalWeight4Textbox.TabIndex = 32;
            TotalWeight4Textbox.TextChanged += TotalWeight4Textbox_TextChanged;
            // 
            // NumberofCrates4Textbox
            // 
            NumberofCrates4Textbox.Location = new Point(144, 294);
            NumberofCrates4Textbox.Name = "NumberofCrates4Textbox";
            NumberofCrates4Textbox.Size = new Size(125, 27);
            NumberofCrates4Textbox.TabIndex = 31;
            // 
            // Product4Textbox
            // 
            Product4Textbox.Location = new Point(13, 294);
            Product4Textbox.Name = "Product4Textbox";
            Product4Textbox.Size = new Size(125, 27);
            Product4Textbox.TabIndex = 30;
            // 
            // CustomerInfoTextbox
            // 
            CustomerInfoTextbox.Location = new Point(154, 28);
            CustomerInfoTextbox.Name = "CustomerInfoTextbox";
            CustomerInfoTextbox.Size = new Size(247, 27);
            CustomerInfoTextbox.TabIndex = 40;
            // 
            // MüşteriLabel
            // 
            MüşteriLabel.AutoSize = true;
            MüşteriLabel.Location = new Point(14, 31);
            MüşteriLabel.Name = "MüşteriLabel";
            MüşteriLabel.Size = new Size(134, 20);
            MüşteriLabel.TabIndex = 41;
            MüşteriLabel.Text = "Müşteri Adı Soyadı";
            // 
            // TarihLabel
            // 
            TarihLabel.AutoSize = true;
            TarihLabel.Location = new Point(469, 31);
            TarihLabel.Name = "TarihLabel";
            TarihLabel.Size = new Size(40, 20);
            TarihLabel.TabIndex = 43;
            TarihLabel.Text = "Tarih";
            // 
            // DateTextBox
            // 
            DateTextBox.Location = new Point(515, 28);
            DateTextBox.Name = "DateTextBox";
            DateTextBox.Size = new Size(147, 27);
            DateTextBox.TabIndex = 42;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { TarihKolon, MüşteriKolon, ÜrünKolon, SandıkAdetKolon, KiloKolon, BirimFiyatKolon, AraToplamKolon });
            dataGridView.Location = new Point(14, 403);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(929, 400);
            dataGridView.TabIndex = 44;
            dataGridView.CellValueChanged += dataGridView_CellValueChanged;
            dataGridView.RowsRemoved += dataGridView_RowsRemoved;
            // 
            // TarihKolon
            // 
            TarihKolon.HeaderText = "Tarih";
            TarihKolon.MinimumWidth = 6;
            TarihKolon.Name = "TarihKolon";
            TarihKolon.Width = 125;
            // 
            // MüşteriKolon
            // 
            MüşteriKolon.HeaderText = "Müşteri";
            MüşteriKolon.MinimumWidth = 6;
            MüşteriKolon.Name = "MüşteriKolon";
            MüşteriKolon.Width = 125;
            // 
            // ÜrünKolon
            // 
            ÜrünKolon.HeaderText = "Ürün";
            ÜrünKolon.MinimumWidth = 6;
            ÜrünKolon.Name = "ÜrünKolon";
            ÜrünKolon.Width = 125;
            // 
            // SandıkAdetKolon
            // 
            SandıkAdetKolon.HeaderText = "Sandık Adeti";
            SandıkAdetKolon.MinimumWidth = 6;
            SandıkAdetKolon.Name = "SandıkAdetKolon";
            SandıkAdetKolon.Width = 125;
            // 
            // KiloKolon
            // 
            KiloKolon.HeaderText = "Kilo";
            KiloKolon.MinimumWidth = 6;
            KiloKolon.Name = "KiloKolon";
            KiloKolon.Width = 125;
            // 
            // BirimFiyatKolon
            // 
            BirimFiyatKolon.HeaderText = "Birim Fiyat";
            BirimFiyatKolon.MinimumWidth = 6;
            BirimFiyatKolon.Name = "BirimFiyatKolon";
            BirimFiyatKolon.Width = 125;
            // 
            // AraToplamKolon
            // 
            AraToplamKolon.HeaderText = "Ara Toplam";
            AraToplamKolon.MinimumWidth = 6;
            AraToplamKolon.Name = "AraToplamKolon";
            AraToplamKolon.Width = 125;
            // 
            // AddSaleButton
            // 
            AddSaleButton.Location = new Point(818, 354);
            AddSaleButton.Name = "AddSaleButton";
            AddSaleButton.Size = new Size(125, 39);
            AddSaleButton.TabIndex = 45;
            AddSaleButton.Text = "SATIŞ EKLE";
            AddSaleButton.UseVisualStyleBackColor = true;
            AddSaleButton.Click += AddSaleButton_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(818, 286);
            label16.Name = "label16";
            label16.Size = new Size(86, 20);
            label16.TabIndex = 47;
            label16.Text = "Ara Toplam";
            // 
            // TotalPriceTextbox
            // 
            TotalPriceTextbox.Location = new Point(818, 309);
            TotalPriceTextbox.Name = "TotalPriceTextbox";
            TotalPriceTextbox.ReadOnly = true;
            TotalPriceTextbox.Size = new Size(125, 27);
            TotalPriceTextbox.TabIndex = 48;
            TotalPriceTextbox.Text = "0";
            // 
            // Clear1Button
            // 
            Clear1Button.Location = new Point(668, 103);
            Clear1Button.Name = "Clear1Button";
            Clear1Button.Size = new Size(94, 27);
            Clear1Button.TabIndex = 49;
            Clear1Button.Text = "Temizle";
            Clear1Button.UseVisualStyleBackColor = true;
            Clear1Button.Click += Clear1Button_Click;
            // 
            // Clear2Button
            // 
            Clear2Button.Location = new Point(668, 167);
            Clear2Button.Name = "Clear2Button";
            Clear2Button.Size = new Size(94, 27);
            Clear2Button.TabIndex = 50;
            Clear2Button.Text = "Temizle";
            Clear2Button.UseVisualStyleBackColor = true;
            Clear2Button.Click += Clear2Button_Click;
            // 
            // Clear3Button
            // 
            Clear3Button.Location = new Point(668, 231);
            Clear3Button.Name = "Clear3Button";
            Clear3Button.Size = new Size(94, 27);
            Clear3Button.TabIndex = 51;
            Clear3Button.Text = "Temizle";
            Clear3Button.UseVisualStyleBackColor = true;
            Clear3Button.Click += Clear3Button_Click;
            // 
            // Clear4Button
            // 
            Clear4Button.Location = new Point(668, 294);
            Clear4Button.Name = "Clear4Button";
            Clear4Button.Size = new Size(94, 27);
            Clear4Button.TabIndex = 52;
            Clear4Button.Text = "Temizle";
            Clear4Button.UseVisualStyleBackColor = true;
            Clear4Button.Click += Clear4Button_Click;
            // 
            // Clear5Button
            // 
            Clear5Button.Location = new Point(668, 359);
            Clear5Button.Name = "Clear5Button";
            Clear5Button.Size = new Size(94, 27);
            Clear5Button.TabIndex = 52;
            Clear5Button.Text = "Temizle";
            Clear5Button.UseVisualStyleBackColor = true;
            Clear5Button.Click += Clear5Button_Click;
            // 
            // ClearAllButton
            // 
            ClearAllButton.Location = new Point(785, 22);
            ClearAllButton.Name = "ClearAllButton";
            ClearAllButton.Size = new Size(158, 39);
            ClearAllButton.TabIndex = 53;
            ClearAllButton.Text = "TÜMÜNÜ TEMİZLE";
            ClearAllButton.UseVisualStyleBackColor = true;
            ClearAllButton.Click += TümünüTemizleButton_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // PrintButton
            // 
            PrintButton.Location = new Point(820, 820);
            PrintButton.Name = "PrintButton";
            PrintButton.Size = new Size(125, 39);
            PrintButton.TabIndex = 54;
            PrintButton.Text = "YAZDIR";
            PrintButton.UseVisualStyleBackColor = true;
            PrintButton.Click += PrintButton_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(537, 337);
            label17.Name = "label17";
            label17.Size = new Size(94, 20);
            label17.TabIndex = 64;
            label17.Text = "Toplam Fiyat";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(406, 337);
            label18.Name = "label18";
            label18.Size = new Size(79, 20);
            label18.TabIndex = 63;
            label18.Text = "Birim Fiyat";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(275, 337);
            label19.Name = "label19";
            label19.Size = new Size(89, 20);
            label19.TabIndex = 62;
            label19.Text = "Toplam Kilo";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(144, 337);
            label20.Name = "label20";
            label20.Size = new Size(93, 20);
            label20.TabIndex = 61;
            label20.Text = "Sandık Adeti";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(13, 337);
            label21.Name = "label21";
            label21.Size = new Size(40, 20);
            label21.TabIndex = 60;
            label21.Text = "Ürün";
            // 
            // TotalPrice5Textbox
            // 
            TotalPrice5Textbox.Location = new Point(537, 360);
            TotalPrice5Textbox.Name = "TotalPrice5Textbox";
            TotalPrice5Textbox.ReadOnly = true;
            TotalPrice5Textbox.Size = new Size(125, 27);
            TotalPrice5Textbox.TabIndex = 59;
            TotalPrice5Textbox.Text = "0";
            // 
            // UnitPrice5Textbox
            // 
            UnitPrice5Textbox.Location = new Point(406, 360);
            UnitPrice5Textbox.Name = "UnitPrice5Textbox";
            UnitPrice5Textbox.Size = new Size(125, 27);
            UnitPrice5Textbox.TabIndex = 58;
            UnitPrice5Textbox.TextChanged += UnitPrice5Textbox_TextChanged;
            // 
            // TotalWeight5Textbox
            // 
            TotalWeight5Textbox.Location = new Point(275, 360);
            TotalWeight5Textbox.Name = "TotalWeight5Textbox";
            TotalWeight5Textbox.Size = new Size(125, 27);
            TotalWeight5Textbox.TabIndex = 57;
            TotalWeight5Textbox.TextChanged += TotalWeight5Textbox_TextChanged;
            // 
            // NumberofCrates5Textbox
            // 
            NumberofCrates5Textbox.Location = new Point(144, 360);
            NumberofCrates5Textbox.Name = "NumberofCrates5Textbox";
            NumberofCrates5Textbox.Size = new Size(125, 27);
            NumberofCrates5Textbox.TabIndex = 56;
            // 
            // Product5Textbox
            // 
            Product5Textbox.Location = new Point(13, 360);
            Product5Textbox.Name = "Product5Textbox";
            Product5Textbox.Size = new Size(125, 27);
            Product5Textbox.TabIndex = 55;
            // 
            // GeneralTotalPriceTextbox
            // 
            GeneralTotalPriceTextbox.Location = new Point(132, 827);
            GeneralTotalPriceTextbox.Name = "GeneralTotalPriceTextbox";
            GeneralTotalPriceTextbox.ReadOnly = true;
            GeneralTotalPriceTextbox.Size = new Size(125, 27);
            GeneralTotalPriceTextbox.TabIndex = 67;
            GeneralTotalPriceTextbox.Text = "0";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(25, 830);
            label22.Name = "label22";
            label22.Size = new Size(101, 20);
            label22.TabIndex = 66;
            label22.Text = "Genel Toplam";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(957, 882);
            Controls.Add(GeneralTotalPriceTextbox);
            Controls.Add(label22);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(TotalPrice5Textbox);
            Controls.Add(UnitPrice5Textbox);
            Controls.Add(TotalWeight5Textbox);
            Controls.Add(NumberofCrates5Textbox);
            Controls.Add(Product5Textbox);
            Controls.Add(PrintButton);
            Controls.Add(ClearAllButton);
            Controls.Add(Clear5Button);
            Controls.Add(Clear4Button);
            Controls.Add(Clear3Button);
            Controls.Add(Clear2Button);
            Controls.Add(Clear1Button);
            Controls.Add(TotalPriceTextbox);
            Controls.Add(label16);
            Controls.Add(AddSaleButton);
            Controls.Add(dataGridView);
            Controls.Add(TarihLabel);
            Controls.Add(DateTextBox);
            Controls.Add(MüşteriLabel);
            Controls.Add(CustomerInfoTextbox);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(TotalPrice4Textbox);
            Controls.Add(UnitPrice4Textbox);
            Controls.Add(TotalWeight4Textbox);
            Controls.Add(NumberofCrates4Textbox);
            Controls.Add(Product4Textbox);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(TotalPrice3Textbox);
            Controls.Add(UnitPrice3Textbox);
            Controls.Add(TotalWeight3Textbox);
            Controls.Add(NumberofCrates3Textbox);
            Controls.Add(Product3Textbox);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(TotalPrice2Textbox);
            Controls.Add(UnitPrice2Textbox);
            Controls.Add(TotalWeight2Textbox);
            Controls.Add(NumberofCrates2Textbox);
            Controls.Add(Product2Textbox);
            Controls.Add(ToplamFiyatLabel);
            Controls.Add(BirimFiyatLabel);
            Controls.Add(KiloLabel);
            Controls.Add(SandıkAdetLabel);
            Controls.Add(ÜrünLabel);
            Controls.Add(TotalPrice1Textbox);
            Controls.Add(UnitPrice1Textbox);
            Controls.Add(TotalWeight1Textbox);
            Controls.Add(NumberofCrates1Textbox);
            Controls.Add(Product1Textbox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Product1Textbox;
        private TextBox NumberofCrates1Textbox;
        private TextBox TotalWeight1Textbox;
        private TextBox UnitPrice1Textbox;
        private TextBox TotalPrice1Textbox;
        private Label ÜrünLabel;
        private Label SandıkAdetLabel;
        private Label KiloLabel;
        private Label BirimFiyatLabel;
        private Label ToplamFiyatLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TotalPrice2Textbox;
        private TextBox UnitPrice2Textbox;
        private TextBox TotalWeight2Textbox;
        private TextBox NumberofCrates2Textbox;
        private TextBox Product2Textbox;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox TotalPrice3Textbox;
        private TextBox UnitPrice3Textbox;
        private TextBox TotalWeight3Textbox;
        private TextBox NumberofCrates3Textbox;
        private TextBox Product3Textbox;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox TotalPrice4Textbox;
        private TextBox UnitPrice4Textbox;
        private TextBox TotalWeight4Textbox;
        private TextBox NumberofCrates4Textbox;
        private TextBox Product4Textbox;
        private TextBox CustomerInfoTextbox;
        private Label MüşteriLabel;
        private Label TarihLabel;
        private TextBox DateTextBox;
        private DataGridView dataGridView;
        private Button AddSaleButton;
        private Label label16;
        private TextBox TotalPriceTextbox;
        private DataGridViewTextBoxColumn TarihKolon;
        private DataGridViewTextBoxColumn MüşteriKolon;
        private DataGridViewTextBoxColumn ÜrünKolon;
        private DataGridViewTextBoxColumn SandıkAdetKolon;
        private DataGridViewTextBoxColumn KiloKolon;
        private DataGridViewTextBoxColumn BirimFiyatKolon;
        private DataGridViewTextBoxColumn AraToplamKolon;
        private Button Clear1Button;
        private Button Clear2Button;
        private Button Clear3Button;
        private Button Clear4Button;
        private Button Clear5Button;
        private Button ClearAllButton;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button PrintButton;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private TextBox TotalPrice5Textbox;
        private TextBox UnitPrice5Textbox;
        private TextBox TotalWeight5Textbox;
        private TextBox NumberofCrates5Textbox;
        private TextBox Product5Textbox;
        private TextBox GeneralTotalPriceTextbox;
        private Label label22;
    }
}
