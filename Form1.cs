using System;
using System.Windows.Forms;
using CotizadorExpress.Views;
using CotizadorExpress.Presenters;

namespace CotizadorExpress
{
    public partial class Form1 : Form, IView
    {
        private readonly Presenter _presenter;

        private readonly History _form = new History();

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
        public string Price => numericUpDownPrice.Text;
        public string Quantity => numericUpDownQuantity.Text;
        public int Quality { get; set; }
        public int ShirtSleeve { get; set; }
        public int ShirtNeck { get; set; }
        public int PantType { get; set; }
        #endregion

        public Form1()
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
            else
            {
                panelPantType.Enabled = true;
                panelSleeve.Enabled = false;
                panelNeck.Enabled = false;

                radioButtonSleeveShort.Checked = false;
                radioButtonSleeveLong.Checked = false;

                radioButtonNeckNormal.Checked = false;
                radioButtonNeckMao.Checked = false;
            }

            radioButtonQualityStandard.Checked = false;
            radioButtonQualityPremium.Checked = false;
        }

        // Check if a sleeve option is selected
        private void radioButtonSleeveShort_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSleeveShort.Checked)
            {
                panelNeck.Enabled = true;
            }
        }
        private void radioButtonSleeveLong_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSleeveLong.Checked)
            {
                panelNeck.Enabled = true;
            }
        }

        // Check if a neck option is selected
        private void radioButtonNeckNormal_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxQuality.Enabled = radioButtonNeckNormal.Checked;
        }
        private void radioButtonNeckMao_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxQuality.Enabled = radioButtonNeckMao.Checked;
        }

        // If pant check the type selected
        private void radioButtonTypeNormal_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxQuality.Enabled = radioButtonTypeNormal.Checked;
        }
        private void radioButtonTypeSkinny_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxQuality.Enabled = radioButtonTypeSkinny.Checked;
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

        private void SellerPicture_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Nombre: {SellerName} \nApellido: {SellerLastName} \nID: {SellerId}", "Información Vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void numericUpDownPrice_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownPrice.Text = numericUpDownPrice.Text.Replace('.', ',');
        }
        private void btn_Quote_Click(object sender, EventArgs e)
        {
            float.TryParse(numericUpDownPrice.Text, out float price);
            int.TryParse(numericUpDownQuantity.Text, out int quantity);

            Quality = radioButtonQualityStandard.Checked ? 0 : 1;

            if (radioButtonShirt.Checked)
            {
                ShirtSleeve = radioButtonSleeveShort.Checked ? 0 : 1;
                ShirtNeck = radioButtonNeckNormal.Checked ? 0 : 1;

                MessageBox.Show($"{_presenter.QuoteShirt(ShirtSleeve, ShirtNeck, Quality, quantity, price)}");
            }
            else if (radioButtonPant.Checked)
            {
                PantType = radioButtonTypeSkinny.Checked ? 1 : 0;
                MessageBox.Show($"{_presenter.QuotePant(PantType, Quality, quantity, price)}");
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            numericUpDownPrice.Text = "0";
            numericUpDownQuantity.Text = "0";
        }

        private void buttonQuotesHistory_Click(object sender, EventArgs e)
        {
            foreach (var quotes in _presenter.GetQuotes())
            {
                _form.SetHistory(quotes.PrintData());
            }

            _form.Show();
        }
    }
}
