using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NinasCookieSource
{

    public partial class ThanksForOrderingForm : Form
    {
        public string LblCookiesType_Text { set { lblCookiesType.Text = value; } }
        public string LblCookiesAmount_Text { set { lblCookiesAmount.Text = value; } }
        public string LblPriceThnkxForm_Text { set { lblPrice.Text = value; } }
        public string LblArrivalDate_Text { set { lblArrivalDate.Text = value; } }
        public ThanksForOrderingForm()
        {
            InitializeComponent();
        }

        private void ThanksForOrderingForm_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
