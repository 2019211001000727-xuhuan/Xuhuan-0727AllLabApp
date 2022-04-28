using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabAss6
{
    public partial class CurrencyConverter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtNumber.Text);
            double result = n1 * 0.15;
            lblResult.Text = n1.ToString() + "Chinese Yuan =" + result.ToString() + "Dollars.";
        }
    }
}