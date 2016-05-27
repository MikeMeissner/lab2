using comp2007lab2.User_Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace comp2007lab2.User_Controls
{
    public partial class jumbotron : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            jumbotronH1.InnerText = "Welcome!";
        }
    }
}