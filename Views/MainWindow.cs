using System;
using System.Globalization;
using System.Windows.Forms;
using CotizadorExpress.Views;
using CotizadorExpress.Presenters;

namespace CotizadorExpress
{
    public partial class MainWindow : Form, IView
    {
        private readonly Presenter _presenter;

        #region Interface Properties
        // Store
        public string StoreName
        {
            get => labelStoreName.Text;
            set => labelStoreName.Text = value;
        }
        public string StoreAddress
        {
            get => labelStoreAddress.Text;
            set => labelStoreAddress.Text = value;
        }

        // Seller
        public string SellerName { get; set; }
        public string SellerLastName { get; set; }
        public string SellerId { get; set; }

        // Quote
        public string Price => textBoxPrice.Text;
        public string Quantity => textBoxQuantity.Text;
        public int Quality { get; set; }
        public int GarmentType { get; set; }
        public int ShirtSleeve { get; set; }
        public int ShirtNeck { get; set; }
        public int PantType { get; set; }
        public string Message { get; set; }
        public int Stock { get; set; }
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            _presenter = new Presenter(this);
        }

        #region Garment Options
        // Check which option (shirt, pant) is selected
        private void radioButtonShirt_CheckedChanged(object sender, EventArgs e)
        {
            CheckSelected();
        }
        private void radioButtonPant_CheckedChanged(object sender, EventArgs e)
        {
            CheckSelected();
        }
        private void CheckSelected()
        {
            if (radioButtonShirt.Checked)
            {
                panelSleeve.Enabled = true;
                panelPantType.Enabled = false;
                radioButtonTypeNormal.Checked = false;
                radioButtonTypeSkinny.Checked = false;
            }
            else if (radioButtonPant.Checked)
            {
                panelSleeve.Enabled = false;
                panelNeck.Enabled = false;
                radioButtonSleeveShort.Checked = false;
                radioButtonSleeveLong.Checked = false;
                radioButtonNeckNormal.Checked = false;
                radioButtonNeckMao.Checked = false;
                panelPantType.Enabled = true;
            }

            radioButtonQualityStandard.Checked = false;
            radioButtonQualityPremium.Checked = false;
            labelStockQuantity.Text = "";
            //textBoxPrice.Text = "";
            //textBoxQuantity.Text = "";
            labelTotalAmount.Text = "";
            UpdateGarmentElement();
        }

        // Check if a sleeve option is selected
        private void radioButtonSleeveShort_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSleeveShort.Checked)
            {
                panelNeck.Enabled = true;
            }
            UpdateGarmentElement();
        }
        private void radioButtonSleeveLong_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSleeveLong.Checked)
            {
                panelNeck.Enabled = true;
            }
            UpdateGarmentElement();
        }

        // Check if a neck option is selected
        private void radioButtonNeckNormal_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxQuality.Enabled = radioButtonNeckNormal.Checked;
            UpdateGarmentElement();
        }
        private void radioButtonNeckMao_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxQuality.Enabled = radioButtonNeckMao.Checked;
            UpdateGarmentElement();
        }

        // If pant check the type selected
        private void radioButtonTypeNormal_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxQuality.Enabled = radioButtonTypeNormal.Checked;
            UpdateGarmentElement();
        }
        private void radioButtonTypeSkinny_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxQuality.Enabled = radioButtonTypeSkinny.Checked;
            UpdateGarmentElement();
        }

        // Check the selected quality and set the stock
        private void radioButtonQualityStandard_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGarmentElement();
        }
        private void radioButtonQualityPremium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGarmentElement();
        }
        #endregion

        #region Tooltips
        private void radioButtonSleeveShort_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Descuento del 10%", radioButtonSleeveShort);
        }
        private void radioButtonNeckMao_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Incremento del 3%", radioButtonNeckMao);
        }
        private void radioButtonTypeSkinny_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Descuento del 12%", radioButtonTypeSkinny);
        }
        private void radioButtonQualityPremium_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Incremento del 30%", radioButtonQualityPremium);
        }
        #endregion

        public void UpdateGarmentElement()
        {
            if (((radioButtonShirt.Checked && (radioButtonSleeveShort.Checked || radioButtonSleeveLong.Checked) && (radioButtonNeckNormal.Checked || radioButtonNeckMao.Checked))
                || radioButtonPant.Checked && (radioButtonTypeNormal.Checked || radioButtonTypeSkinny.Checked))
                                             && (radioButtonQualityStandard.Checked || radioButtonQualityPremium.Checked))
            {
                GarmentType = radioButtonShirt.Checked ? 0 : 1;

                ShirtSleeve = radioButtonSleeveShort.Checked ? 0 : 1;
                ShirtNeck = radioButtonNeckNormal.Checked ? 0 : 1;

                PantType = radioButtonTypeSkinny.Checked ? 1 : 0;

                Quality = radioButtonQualityStandard.Checked ? 0 : 1;

                _presenter.SetElementToQuote();

                labelStockQuantity.Text = Stock.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void SellerPicture_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Nombre: {SellerName} \nApellido: {SellerLastName} \nID: {SellerId}", "Información Vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonQuotesHistory_Click(object sender, EventArgs e)
        {
            if (_presenter.PrintQuotes())
            {
                History form = new History();
                form.SetHistory(Message);
                form.Show();
            }
            else
            {
                MessageBox.Show($"{Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Quote_Click(object sender, EventArgs e)
        {
            if (((!radioButtonShirt.Checked && !radioButtonSleeveShort.Checked && !radioButtonSleeveLong.Checked && !radioButtonNeckNormal.Checked && !radioButtonNeckMao.Checked)
                 || !radioButtonPant.Checked && !radioButtonTypeNormal.Checked && !radioButtonTypeSkinny.Checked)
                && (!radioButtonQualityStandard.Checked && !radioButtonQualityPremium.Checked))
            {
                MessageBox.Show("Faltan datos por diligenciar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    float price = float.Parse(textBoxPrice.Text.Replace('.', ','));
                    int quantity = int.Parse(textBoxQuantity.Text);

                    if (_presenter.Quote(quantity, price))
                    {
                        labelTotalAmount.Text = Message;
                    }
                    else
                    {
                        MessageBox.Show($"{Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Formato invalido para el precio o cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //float.TryParse(numericUpDownPrice.Text, out float price);
            //int.TryParse(numericUpDownQuantity.Text, out int quantity);
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxPrice.Text = "";
            textBoxQuantity.Text = "";
            labelTotalAmount.Text = "";

            radioButtonShirt.Checked = false;
            radioButtonPant.Checked = false;

            panelSleeve.Enabled = false;
            panelNeck.Enabled = false;
            panelPantType.Enabled = false;

            radioButtonTypeNormal.Checked = false;
            radioButtonTypeSkinny.Checked = false;
            radioButtonSleeveShort.Checked = false;
            radioButtonSleeveLong.Checked = false;
            radioButtonNeckNormal.Checked = false;
            radioButtonNeckMao.Checked = false;

            radioButtonQualityStandard.Checked = false;
            radioButtonQualityPremium.Checked = false;
            groupBoxQuality.Enabled = false;

            labelStockQuantity.Text = "";
        }
    }
}
