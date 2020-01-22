using CHBYS.PRESENTATIONLAYER.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CHBYS.PRESENTATIONLAYER
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            Service1Client db = new Service1Client();
            
            if(db.login(txtusername.Value.ToString(), txtpassword.Value.ToString()))
            {
               V_Users d = db.User_Read().Where(x=>x.KULLANICI_ADI == txtusername.Value && x.SIFRE == txtpassword.Value).FirstOrDefault();
                Session["username"] = d.KULLANICI_ADI;
                Session["SIRANO"] = d.SIRA_NO;
                Session["YETKI"] = d.YETKI;
                
                Response.Redirect("musteriler.aspx");
            }
            
        }
    }
}