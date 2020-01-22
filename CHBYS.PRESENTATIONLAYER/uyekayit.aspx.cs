using CHBYS.PRESENTATIONLAYER.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CHBYS.PRESENTATIONLAYER
{
    public partial class uyekayit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void kayitol_Click(object sender, EventArgs e)
        {
            Service1Client db = new Service1Client();

            db.User_insert(new c_User {
                user_name = txtusername.Value.ToString(),
                password = txtpassword.Value.ToString(),
                company = (int)2,
                employee = (int)1,
                authority = (int)1
                
            });
        }
    }
}