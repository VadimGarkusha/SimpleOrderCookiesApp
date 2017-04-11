using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NinasCookieSource
{
    public partial class Form1 : Form
    {
        public Dictionary<string, double> TypesWithPrices { get; private set; }
        public Dictionary<string, double> Amounts { get; private set; }
        public Form1()
        {
            InitializeComponent();
            TypesWithPrices = new Dictionary<string, double>()
            {{"Pie Crust Cookies",11 },
            {"Brown Butter Bourbon",14 },
            {"Pub Cookies",12 },
            {"Kitsilano Cookies",16 }};

            Amounts = new Dictionary<string, double>()
            {{"One half dozen",0.5 },
            {"One dozen",1 },
            {"Two dozen",2 },
            {"Threee Dozen",3 }};
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsbTypeOfCookies.Items.AddRange(TypesWithPrices.Keys.ToArray());
            lsbAmountOfCookies.Items.AddRange(Amounts.Keys.ToArray());
            btnOrder.Enabled = false;
        }

        private void lsbTypeOfCookies_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidationForLists();
        }

        private void lsbAmountOfCookies_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidationForLists();
        }

        private void mnthcalSelectedDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            mnthcalSelectedDate.MaxSelectionCount = 1;
            if (mnthcalSelectedDate.SelectionRange.Start >= mnthcalSelectedDate.TodayDate)
                lblArrivalDate.Text = mnthcalSelectedDate.SelectionRange.Start.AddDays(3).ToShortDateString();
            else
                lblArrivalDate.Text = "Chosen date cannot be earlier than today's";

            ValidationForButton();
        }

        private void ValidationForLists()
        {
            if (lsbTypeOfCookies.SelectedItem != null && lsbAmountOfCookies.SelectedItem != null)
                lblPriceValue.Text = "$ " + TypesWithPrices[lsbTypeOfCookies.SelectedItem.ToString()] * Amounts[lsbAmountOfCookies.SelectedItem.ToString()];
            else
                lblPriceValue.Text = "You should choose both options!";

            ValidationForButton();
        }

        private void ValidationForButton()
        {
            if (mnthcalSelectedDate.SelectionRange.Start >= mnthcalSelectedDate.TodayDate && lsbTypeOfCookies.SelectedItem != null && lsbAmountOfCookies.SelectedItem != null)
                btnOrder.Enabled = true;
            else
                btnOrder.Enabled = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ThanksForOrderingForm thnxForOrderFrm = new ThanksForOrderingForm();
            thnxForOrderFrm.LblCookiesType_Text = lsbTypeOfCookies.SelectedItem.ToString();
            thnxForOrderFrm.LblCookiesAmount_Text = lsbAmountOfCookies.SelectedItem.ToString();
            thnxForOrderFrm.LblPriceThnkxForm_Text = lblPriceValue.Text;
            thnxForOrderFrm.LblArrivalDate_Text = mnthcalSelectedDate.SelectionRange.Start.AddDays(3).ToShortDateString();

            thnxForOrderFrm.ShowDialog(this);
        }
    }
}
