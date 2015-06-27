using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _008_DataConversion
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            // int i;    wont work
            // i = "3";

            int k = 2000000000; // upcasting does work
            long j = k; // implicit conversion

            //long a = 2000000000; Reverse doesn't work
            //int b = a;

            long c = 2000000000;
            int d = (int)c; // explicit conversion

            double f = 2.5;
            int g = (int) f; // explicit cast

           resultLabel.Text = g.ToString(); // 2.5 gets truncated to 2

            string m = TextBox1.Text; // assigns m to value in textbox
            int l = int.Parse(m); // takes string value and tries to convert
            int n = l + 1; // create new variable and set it to l plus 1
            resultLabel.Text = n.ToString(); // displays results


        }
    }
}