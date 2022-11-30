using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _30_11_2022
{

    class math
    {


        public double sum(double x, double y)
        {
            double result = x + y;
            return result;
        }

        public double sub(double x, double y)
        {
            double result = x - y;
            return result;
        }

        public double multi(double x, double y)
        {
            double result = x * y;
            return result;
        }
        public double div(double x, double y)
        {
            double result = x / y;
            return result;
        }
    }
    public partial class calculater : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(TextBox1.Text);
            double txt2 = Convert.ToDouble(TextBox2.Text);
            math sum = new math();

            double result1 = sum.sum(txt1, txt2);
            TextBox3.Text = Convert.ToString(result1);

        }

        protected void sub_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(TextBox1.Text);
            double txt2 = Convert.ToDouble(TextBox2.Text);
            math sub = new math();
            double result2 = sub.sub(txt1, txt2);
            TextBox3.Text = Convert.ToString(result2);
        }

        protected void multi_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(TextBox1.Text);
            double txt2 = Convert.ToDouble(TextBox2.Text);
            math mul = new math();
            double result3 = mul.multi(txt1, txt2);
            TextBox3.Text = Convert.ToString(result3);
        }

        protected void divid_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(TextBox1.Text);
            double txt2 = Convert.ToDouble(TextBox2.Text);
            math div = new math();
            double result4 = div.div(txt1, txt2);
            TextBox3.Text = Convert.ToString(result4);
        }
    }
}