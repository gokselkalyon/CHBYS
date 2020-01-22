using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CHBYS.PRESENTATIONLAYER.ServiceReference1;

namespace CHBYS.PRESENTATIONLAYER
{
    public partial class katalog : System.Web.UI.Page
    {
        Service1Client db = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

            gv1.DataSource = db.barcode_Read();
            gv1.DataBind();
            selectedurun.DataSource = db.product_Read().Select(x => x.MARKA).ToList(); //urun adı 
            selectedurun.DataBind();
        }

        protected void btnKatalogekle_Click(object sender, EventArgs e)
        {
            id = (db.product_Read().Where(x => x.MARKA == selectedurun.SelectedValue.ToString()).FirstOrDefault());
            db.barcode_insert(new c_barcode
            {
                barcode1 = Convert.ToInt32(txtKatologadi.Text),
                comment = txtAciklama.Text,
                product =id.NO,
                Ekleyen_Kullanici = null
            });
        }
        V_product id;
        protected void selectedurun_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }

}
