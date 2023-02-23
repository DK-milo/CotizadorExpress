namespace CotizadorExpress
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Quote = new System.Windows.Forms.Button();
            this.labelStoreName = new System.Windows.Forms.Label();
            this.labelStoreAddress = new System.Windows.Forms.Label();
            this.sellerPicture = new System.Windows.Forms.PictureBox();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.buttonClear = new System.Windows.Forms.Button();
            this.radioButtonShirt = new System.Windows.Forms.RadioButton();
            this.radioButtonPant = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelStockQuantity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxQuality = new System.Windows.Forms.GroupBox();
            this.radioButtonQualityPremium = new System.Windows.Forms.RadioButton();
            this.radioButtonQualityStandard = new System.Windows.Forms.RadioButton();
            this.panelPantType = new System.Windows.Forms.Panel();
            this.radioButtonTypeSkinny = new System.Windows.Forms.RadioButton();
            this.radioButtonTypeNormal = new System.Windows.Forms.RadioButton();
            this.panelNeck = new System.Windows.Forms.Panel();
            this.radioButtonNeckMao = new System.Windows.Forms.RadioButton();
            this.radioButtonNeckNormal = new System.Windows.Forms.RadioButton();
            this.panelSleeve = new System.Windows.Forms.Panel();
            this.radioButtonSleeveLong = new System.Windows.Forms.RadioButton();
            this.radioButtonSleeveShort = new System.Windows.Forms.RadioButton();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelSeller = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonQuotesHistory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sellerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxQuality.SuspendLayout();
            this.panelPantType.SuspendLayout();
            this.panelNeck.SuspendLayout();
            this.panelSleeve.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Quote
            // 
            this.btn_Quote.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Quote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Quote.Enabled = false;
            this.btn_Quote.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Quote.Location = new System.Drawing.Point(333, 276);
            this.btn_Quote.Name = "btn_Quote";
            this.btn_Quote.Size = new System.Drawing.Size(75, 23);
            this.btn_Quote.TabIndex = 0;
            this.btn_Quote.Text = "Cotizar";
            this.btn_Quote.UseVisualStyleBackColor = true;
            this.btn_Quote.Click += new System.EventHandler(this.btn_Quote_Click);
            // 
            // labelStoreName
            // 
            this.labelStoreName.AutoSize = true;
            this.labelStoreName.Location = new System.Drawing.Point(71, 12);
            this.labelStoreName.Name = "labelStoreName";
            this.labelStoreName.Size = new System.Drawing.Size(77, 13);
            this.labelStoreName.TabIndex = 1;
            this.labelStoreName.Text = "NombreTienda";
            // 
            // labelStoreAddress
            // 
            this.labelStoreAddress.AutoSize = true;
            this.labelStoreAddress.Location = new System.Drawing.Point(71, 49);
            this.labelStoreAddress.Name = "labelStoreAddress";
            this.labelStoreAddress.Size = new System.Drawing.Size(85, 13);
            this.labelStoreAddress.TabIndex = 2;
            this.labelStoreAddress.Text = "DireccionTienda";
            // 
            // sellerPicture
            // 
            this.sellerPicture.Image = global::CotizadorExpress.Properties.Resources.iconDefault;
            this.sellerPicture.Location = new System.Drawing.Point(276, 33);
            this.sellerPicture.Name = "sellerPicture";
            this.sellerPicture.Size = new System.Drawing.Size(50, 50);
            this.sellerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sellerPicture.TabIndex = 3;
            this.sellerPicture.TabStop = false;
            this.sellerPicture.Click += new System.EventHandler(this.SellerPicture_Click);
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DecimalPlaces = 1;
            this.numericUpDownPrice.Location = new System.Drawing.Point(13, 276);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPrice.TabIndex = 6;
            this.numericUpDownPrice.ValueChanged += new System.EventHandler(this.numericUpDownPrice_ValueChanged);
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(139, 276);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownQuantity.TabIndex = 7;
            this.numericUpDownQuantity.ValueChanged += new System.EventHandler(this.numericUpDownQuantity_ValueChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(414, 276);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Limpiar";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // radioButtonShirt
            // 
            this.radioButtonShirt.AutoSize = true;
            this.radioButtonShirt.Location = new System.Drawing.Point(6, 19);
            this.radioButtonShirt.Name = "radioButtonShirt";
            this.radioButtonShirt.Size = new System.Drawing.Size(59, 17);
            this.radioButtonShirt.TabIndex = 9;
            this.radioButtonShirt.TabStop = true;
            this.radioButtonShirt.Text = "Camisa";
            this.radioButtonShirt.UseVisualStyleBackColor = true;
            this.radioButtonShirt.CheckedChanged += new System.EventHandler(this.radioButtonShirt_CheckedChanged);
            // 
            // radioButtonPant
            // 
            this.radioButtonPant.AutoSize = true;
            this.radioButtonPant.Location = new System.Drawing.Point(6, 104);
            this.radioButtonPant.Name = "radioButtonPant";
            this.radioButtonPant.Size = new System.Drawing.Size(67, 17);
            this.radioButtonPant.TabIndex = 10;
            this.radioButtonPant.TabStop = true;
            this.radioButtonPant.Text = "Pantalón";
            this.radioButtonPant.UseVisualStyleBackColor = true;
            this.radioButtonPant.CheckedChanged += new System.EventHandler(this.radioButtonPant_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelStockQuantity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBoxQuality);
            this.groupBox1.Controls.Add(this.panelPantType);
            this.groupBox1.Controls.Add(this.panelNeck);
            this.groupBox1.Controls.Add(this.panelSleeve);
            this.groupBox1.Controls.Add(this.radioButtonShirt);
            this.groupBox1.Controls.Add(this.radioButtonPant);
            this.groupBox1.Location = new System.Drawing.Point(13, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 168);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de prenda";
            // 
            // labelStockQuantity
            // 
            this.labelStockQuantity.AutoSize = true;
            this.labelStockQuantity.Location = new System.Drawing.Point(354, 108);
            this.labelStockQuantity.Name = "labelStockQuantity";
            this.labelStockQuantity.Size = new System.Drawing.Size(13, 13);
            this.labelStockQuantity.TabIndex = 16;
            this.labelStockQuantity.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Stock disponible:";
            // 
            // groupBoxQuality
            // 
            this.groupBoxQuality.Controls.Add(this.radioButtonQualityPremium);
            this.groupBoxQuality.Controls.Add(this.radioButtonQualityStandard);
            this.groupBoxQuality.Enabled = false;
            this.groupBoxQuality.Location = new System.Drawing.Point(263, 19);
            this.groupBoxQuality.Name = "groupBoxQuality";
            this.groupBoxQuality.Size = new System.Drawing.Size(200, 48);
            this.groupBoxQuality.TabIndex = 14;
            this.groupBoxQuality.TabStop = false;
            this.groupBoxQuality.Text = "Calidad prenda";
            // 
            // radioButtonQualityPremium
            // 
            this.radioButtonQualityPremium.AutoSize = true;
            this.radioButtonQualityPremium.Location = new System.Drawing.Point(112, 19);
            this.radioButtonQualityPremium.Name = "radioButtonQualityPremium";
            this.radioButtonQualityPremium.Size = new System.Drawing.Size(65, 17);
            this.radioButtonQualityPremium.TabIndex = 13;
            this.radioButtonQualityPremium.TabStop = true;
            this.radioButtonQualityPremium.Text = "Premium";
            this.radioButtonQualityPremium.UseVisualStyleBackColor = true;
            this.radioButtonQualityPremium.CheckedChanged += new System.EventHandler(this.radioButtonQualityPremium_CheckedChanged);
            this.radioButtonQualityPremium.MouseHover += new System.EventHandler(this.radioButtonQualityPremium_MouseHover);
            // 
            // radioButtonQualityStandard
            // 
            this.radioButtonQualityStandard.AutoSize = true;
            this.radioButtonQualityStandard.Location = new System.Drawing.Point(3, 19);
            this.radioButtonQualityStandard.Name = "radioButtonQualityStandard";
            this.radioButtonQualityStandard.Size = new System.Drawing.Size(68, 17);
            this.radioButtonQualityStandard.TabIndex = 12;
            this.radioButtonQualityStandard.TabStop = true;
            this.radioButtonQualityStandard.Text = "Standard";
            this.radioButtonQualityStandard.UseVisualStyleBackColor = true;
            this.radioButtonQualityStandard.CheckedChanged += new System.EventHandler(this.radioButtonQualityStandard_CheckedChanged);
            // 
            // panelPantType
            // 
            this.panelPantType.Controls.Add(this.radioButtonTypeSkinny);
            this.panelPantType.Controls.Add(this.radioButtonTypeNormal);
            this.panelPantType.Enabled = false;
            this.panelPantType.Location = new System.Drawing.Point(25, 127);
            this.panelPantType.Name = "panelPantType";
            this.panelPantType.Size = new System.Drawing.Size(200, 25);
            this.panelPantType.TabIndex = 13;
            // 
            // radioButtonTypeSkinny
            // 
            this.radioButtonTypeSkinny.AutoSize = true;
            this.radioButtonTypeSkinny.Location = new System.Drawing.Point(112, 3);
            this.radioButtonTypeSkinny.Name = "radioButtonTypeSkinny";
            this.radioButtonTypeSkinny.Size = new System.Drawing.Size(60, 17);
            this.radioButtonTypeSkinny.TabIndex = 13;
            this.radioButtonTypeSkinny.TabStop = true;
            this.radioButtonTypeSkinny.Text = "Chupín";
            this.radioButtonTypeSkinny.UseVisualStyleBackColor = true;
            this.radioButtonTypeSkinny.CheckedChanged += new System.EventHandler(this.radioButtonTypeSkinny_CheckedChanged);
            this.radioButtonTypeSkinny.MouseHover += new System.EventHandler(this.radioButtonTypeSkinny_MouseHover);
            // 
            // radioButtonTypeNormal
            // 
            this.radioButtonTypeNormal.AutoSize = true;
            this.radioButtonTypeNormal.Location = new System.Drawing.Point(3, 3);
            this.radioButtonTypeNormal.Name = "radioButtonTypeNormal";
            this.radioButtonTypeNormal.Size = new System.Drawing.Size(58, 17);
            this.radioButtonTypeNormal.TabIndex = 12;
            this.radioButtonTypeNormal.TabStop = true;
            this.radioButtonTypeNormal.Text = "Normal";
            this.radioButtonTypeNormal.UseVisualStyleBackColor = true;
            this.radioButtonTypeNormal.CheckedChanged += new System.EventHandler(this.radioButtonTypeNormal_CheckedChanged);
            // 
            // panelNeck
            // 
            this.panelNeck.Controls.Add(this.radioButtonNeckMao);
            this.panelNeck.Controls.Add(this.radioButtonNeckNormal);
            this.panelNeck.Enabled = false;
            this.panelNeck.Location = new System.Drawing.Point(25, 73);
            this.panelNeck.Name = "panelNeck";
            this.panelNeck.Size = new System.Drawing.Size(200, 25);
            this.panelNeck.TabIndex = 12;
            // 
            // radioButtonNeckMao
            // 
            this.radioButtonNeckMao.AutoSize = true;
            this.radioButtonNeckMao.Location = new System.Drawing.Point(112, 3);
            this.radioButtonNeckMao.Name = "radioButtonNeckMao";
            this.radioButtonNeckMao.Size = new System.Drawing.Size(78, 17);
            this.radioButtonNeckMao.TabIndex = 13;
            this.radioButtonNeckMao.TabStop = true;
            this.radioButtonNeckMao.Text = "Cuello Mao";
            this.radioButtonNeckMao.UseVisualStyleBackColor = true;
            this.radioButtonNeckMao.CheckedChanged += new System.EventHandler(this.radioButtonNeckMao_CheckedChanged);
            this.radioButtonNeckMao.MouseHover += new System.EventHandler(this.radioButtonNeckMao_MouseHover);
            // 
            // radioButtonNeckNormal
            // 
            this.radioButtonNeckNormal.AutoSize = true;
            this.radioButtonNeckNormal.Location = new System.Drawing.Point(3, 3);
            this.radioButtonNeckNormal.Name = "radioButtonNeckNormal";
            this.radioButtonNeckNormal.Size = new System.Drawing.Size(88, 17);
            this.radioButtonNeckNormal.TabIndex = 12;
            this.radioButtonNeckNormal.TabStop = true;
            this.radioButtonNeckNormal.Text = "Cuello normal";
            this.radioButtonNeckNormal.UseVisualStyleBackColor = true;
            this.radioButtonNeckNormal.CheckedChanged += new System.EventHandler(this.radioButtonNeckNormal_CheckedChanged);
            // 
            // panelSleeve
            // 
            this.panelSleeve.Controls.Add(this.radioButtonSleeveLong);
            this.panelSleeve.Controls.Add(this.radioButtonSleeveShort);
            this.panelSleeve.Enabled = false;
            this.panelSleeve.Location = new System.Drawing.Point(25, 42);
            this.panelSleeve.Name = "panelSleeve";
            this.panelSleeve.Size = new System.Drawing.Size(200, 25);
            this.panelSleeve.TabIndex = 11;
            // 
            // radioButtonSleeveLong
            // 
            this.radioButtonSleeveLong.AutoSize = true;
            this.radioButtonSleeveLong.Location = new System.Drawing.Point(112, 3);
            this.radioButtonSleeveLong.Name = "radioButtonSleeveLong";
            this.radioButtonSleeveLong.Size = new System.Drawing.Size(84, 17);
            this.radioButtonSleeveLong.TabIndex = 13;
            this.radioButtonSleeveLong.TabStop = true;
            this.radioButtonSleeveLong.Text = "Manga larga";
            this.radioButtonSleeveLong.UseVisualStyleBackColor = true;
            this.radioButtonSleeveLong.CheckedChanged += new System.EventHandler(this.radioButtonSleeveLong_CheckedChanged);
            // 
            // radioButtonSleeveShort
            // 
            this.radioButtonSleeveShort.AutoSize = true;
            this.radioButtonSleeveShort.Location = new System.Drawing.Point(3, 3);
            this.radioButtonSleeveShort.Name = "radioButtonSleeveShort";
            this.radioButtonSleeveShort.Size = new System.Drawing.Size(85, 17);
            this.radioButtonSleeveShort.TabIndex = 12;
            this.radioButtonSleeveShort.TabStop = true;
            this.radioButtonSleeveShort.Text = "Manga corta";
            this.radioButtonSleeveShort.UseVisualStyleBackColor = true;
            this.radioButtonSleeveShort.CheckedChanged += new System.EventHandler(this.radioButtonSleeveShort_CheckedChanged);
            this.radioButtonSleeveShort.MouseHover += new System.EventHandler(this.radioButtonSleeveShort_MouseHover);
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAmount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTotalAmount.Location = new System.Drawing.Point(71, 315);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(0, 13);
            this.labelTotalAmount.TabIndex = 19;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTotal.Location = new System.Drawing.Point(10, 315);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(55, 13);
            this.labelTotal.TabIndex = 18;
            this.labelTotal.Text = "TOTAL :";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(10, 260);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(74, 13);
            this.labelPrice.TabIndex = 12;
            this.labelPrice.Text = "Precio unitario";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(136, 260);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(49, 13);
            this.labelQuantity.TabIndex = 13;
            this.labelQuantity.Text = "Cantidad";
            // 
            // labelSeller
            // 
            this.labelSeller.AutoSize = true;
            this.labelSeller.Location = new System.Drawing.Point(10, 12);
            this.labelSeller.Name = "labelSeller";
            this.labelSeller.Size = new System.Drawing.Size(43, 13);
            this.labelSeller.TabIndex = 14;
            this.labelSeller.Text = "Tienda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dirección:";
            // 
            // buttonQuotesHistory
            // 
            this.buttonQuotesHistory.BackColor = System.Drawing.SystemColors.Control;
            this.buttonQuotesHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuotesHistory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonQuotesHistory.Location = new System.Drawing.Point(341, 44);
            this.buttonQuotesHistory.Name = "buttonQuotesHistory";
            this.buttonQuotesHistory.Size = new System.Drawing.Size(135, 23);
            this.buttonQuotesHistory.TabIndex = 17;
            this.buttonQuotesHistory.Text = "Historial de cotizaciones";
            this.buttonQuotesHistory.UseVisualStyleBackColor = true;
            this.buttonQuotesHistory.Click += new System.EventHandler(this.buttonQuotesHistory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Vendedor";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 348);
            this.Controls.Add(this.labelTotalAmount);
            this.Controls.Add(this.buttonQuotesHistory);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSeller);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.sellerPicture);
            this.Controls.Add(this.labelStoreAddress);
            this.Controls.Add(this.labelStoreName);
            this.Controls.Add(this.btn_Quote);
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Cotizador Express";
            ((System.ComponentModel.ISupportInitialize)(this.sellerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxQuality.ResumeLayout(false);
            this.groupBoxQuality.PerformLayout();
            this.panelPantType.ResumeLayout(false);
            this.panelPantType.PerformLayout();
            this.panelNeck.ResumeLayout(false);
            this.panelNeck.PerformLayout();
            this.panelSleeve.ResumeLayout(false);
            this.panelSleeve.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Quote;
        private System.Windows.Forms.Label labelStoreName;
        private System.Windows.Forms.Label labelStoreAddress;
        private System.Windows.Forms.PictureBox sellerPicture;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RadioButton radioButtonShirt;
        private System.Windows.Forms.RadioButton radioButtonPant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelSleeve;
        private System.Windows.Forms.RadioButton radioButtonSleeveLong;
        private System.Windows.Forms.RadioButton radioButtonSleeveShort;
        private System.Windows.Forms.Panel panelNeck;
        private System.Windows.Forms.RadioButton radioButtonNeckMao;
        private System.Windows.Forms.RadioButton radioButtonNeckNormal;
        private System.Windows.Forms.Panel panelPantType;
        private System.Windows.Forms.RadioButton radioButtonTypeSkinny;
        private System.Windows.Forms.RadioButton radioButtonTypeNormal;
        private System.Windows.Forms.GroupBox groupBoxQuality;
        private System.Windows.Forms.RadioButton radioButtonQualityPremium;
        private System.Windows.Forms.RadioButton radioButtonQualityStandard;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelSeller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonQuotesHistory;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelStockQuantity;
    }
}

