using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1Asp
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                string[] val = new string[] { "Select", "Mercedes", "BMW" };

                for (int i = 0; i < val.Length; i++)
                {
                    DropDownList1.Items.Add(val[i]);
                }

            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string val = DropDownList1.Text;
            Image1.ImageUrl = "~/pics/" + val + ".jpg";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string val = DropDownList1.Text;

            if (DropDownList1.SelectedValue == "BMW")
            {
                Label1.Text = "35,00,000";
            }
            else if (DropDownList1.SelectedValue == "Mercedes")
            {
                Label1.Text = "20,00,000";
            }
            else
            {
                Label1.Text = "--";
            }
        }
    }
}