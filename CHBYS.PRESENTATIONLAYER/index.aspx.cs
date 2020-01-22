using CHBYS.PRESENTATIONLAYER.ServiceReference1;
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace CHBYS.PRESENTATIONLAYER
{
    public partial class index : System.Web.UI.Page
    {
        private Service1Client db = new Service1Client();
        private int sayac = 1;
        protected void Page_Load(object sender, EventArgs e)
        {

            decimal fiyattotal = (decimal)0;
            fiyattotal = iademiktari(fiyattotal);////////////////// iade mikatarı hesaplama 
            geriodemeler.Text = fiyattotal.ToString();

            decimal maliyet = 0;
            decimal satisfiyati = 0;//////////////////////////////  satiş fiyatı ve maliyet hesaplama
            maliyetvesatisfiyati(ref maliyet, ref satisfiyati);

            totalgelir.Text = Convert.ToString(satisfiyati - (maliyet + fiyattotal));  ///////gelir hesaplama




            if (!IsPostBack)
            {
                DataTable dt = this.GetData();
                StringBuilder html = new StringBuilder();
                foreach (DataRow row in dt.Rows)
                {
                    html.Append("<tr>");

                    foreach (DataColumn column in dt.Columns)
                    {

                        html.Append("<td>" + row[column.ColumnName] + "</td>");

                    }
                    html.Append("</tr>");
                    sayac++;
                }
                string strText = html.ToString();


                soldproductlist.Controls.Add(new Literal { Text = html.ToString() });
            }



            if (!IsPostBack)
            {
                DataTable dt1 = this.GetDatamarka();
                StringBuilder html1 = new StringBuilder();
                foreach (DataRow row in dt1.Rows)
                {
                    html1.Append("<tr>");

                    foreach (DataColumn column in dt1.Columns)
                    {

                        html1.Append("<span class=\"legend-item mr-3\">");
                        html1.Append(" <span class=\"fa-xs text-primary mr-1 legend-tile\">");
                        html1.Append("<span class=\"legend-item mr-3\"> <i class=\"fa fa-fw fa-square-full \"></i></span>");
                        html1.Append("<span class=\"legend-text\">" + row[column.ColumnName] + "</span></span>");

                    }
                    html1.Append("</tr>");
                    sayac++;
                }
                string strText1 = html1.ToString();
                markalist.Controls.Add(new Literal { Text = html1.ToString() });
            }



        }

        private void maliyetvesatisfiyati(ref decimal maliyet, ref decimal satisfiyati)
        {
            foreach (var item in db.sold_product_Read())
            {
                maliyet += item.MALIYET.Value;
                satisfiyati += item.TOPLAM.Value;
            }
        }

        private decimal iademiktari(decimal fiyattotal)
        {
            foreach (var item in db.product_refund_Read())
            {
                fiyattotal += db.barcode_Read().Where(x => x.YORUM == item.URUN).Select(f => f.fiyati).FirstOrDefault().Value;
                fiyattotal *= item.IADE_MIKTARI.Value;
            }

            return fiyattotal;
        }

        private DataTable GetData()
        {

            DataTable table = new DataTable();
            table.Columns.Add("sirano", typeof(string));
            table.Columns.Add("satilanurun", typeof(string));
            table.Columns.Add("maliye", typeof(string));
            table.Columns.Add("toplam", typeof(string));
            table.Columns.Add("birim", typeof(string));
            table.Columns.Add("tarih", typeof(DateTime));



            foreach (var item in db.sold_product_Read().Take(10).ToList())
            {
                table.Rows.Add(sayac,
                    db.barcode_Read().Where(x => x.YORUM == item.SATILAN_URUN).Select(y => y.YORUM).FirstOrDefault().ToString(),
                item.MALIYET/*db.User_Read().Where(d=> d.SIRA_NO == item.CALISAN).Select(x=>x.KULLANICI_ADI ).FirstOrDefault().ToString()*/,
                item.TOPLAM,
                item.BIRIM,
                item.TARIH);

            }

            return table;
        }



        private DataTable GetDatamarka()
        {

            DataTable table = new DataTable();
            table.Columns.Add("markaadi", typeof(string));

            foreach (var item in db.brand_Read().Take(10).ToList())
            {
                table.Rows.Add(item.MARKA_ADI);

            }

            return table;
        }
    }


}


