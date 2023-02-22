using System.Windows.Forms;

namespace CotizadorExpress
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            labelHistory.Text = "";
        }
        public void SetHistory(string data)
        {
            if (labelHistory.Text == "")
            {
                labelHistory.Text += $"{data} \n----------";
            }
            else
            {
                labelHistory.Text += $"\n{data} \n----------";
            }
        }
    }
}
