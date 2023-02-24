using System.Windows.Forms;

namespace CotizadorExpress
{
    public partial class History : Form
    {
        public History()
        {
            CenterToScreen();
            InitializeComponent();
            labelHistory.Text = "";
        }
        public void SetHistory(string data)
        {
            labelHistory.Text = data;
        }
    }
}
