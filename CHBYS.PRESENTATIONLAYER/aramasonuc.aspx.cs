using CHBYS.PRESENTATIONLAYER.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CHBYS.PRESENTATIONLAYER
{
    public partial class aramasonuc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["veri"] == null) return;

            string sonuc = Request.QueryString["veri"];

            IService1 db = new Service1Client();

            List<V_suppliers> s = db.supplier_Read().Where(x => x.ACIKLAMA.Contains(sonuc)).Take(10).ToList();

            StringBuilder sb = new StringBuilder();

            //sb.Append("")
        }
    }
}