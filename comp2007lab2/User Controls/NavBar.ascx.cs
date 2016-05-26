/** 
 * @Author Michael Meissner
 * @Date: May 26,2016
 * @Version 0.0.1 - added setActive method
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace comp2007lab2
{
    public partial class NavBar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            setActivePage();
        }

        /**
         * This methods adds an css class of "active" to list items when switching pages
         * 
         * @method setActivePage
         * @return void
         */
        private void setActivePage()
        {
            switch (Page.Title)
            {
                case "home":
                    home.Attributes.Add("class", "active");
                    break;
                case "contact":
                    contact.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}