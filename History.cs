using System.Windows.Forms;

namespace CotizadorExpress
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            label1.Text = "";
        }
        public void SetHistory(string data)
        {
            if (label1.Text == "")
            {
                label1.Text += $"{data} \n----------";
            }
            else
            {
                label1.Text += $"\n{data} \n----------";
            }
        }
    }
}
