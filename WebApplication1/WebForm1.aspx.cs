using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {

            Label label=new Label();    
            this.Controls.Add(label);

            label.Text = "Hello";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Label label = new Label();
            this.Controls.Add(label);

            label.Text = string.Format(TextBox1.Text);
        }
        
        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}