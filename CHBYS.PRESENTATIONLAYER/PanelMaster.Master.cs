using CHBYS.PRESENTATIONLAYER.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CHBYS.PRESENTATIONLAYER
{
    public partial class PanelMaster : System.Web.UI.MasterPage
    {
        IService1 db = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
             Response.Redirect("login.aspx");

            lblusername.Text = Session["username"].ToString(); // db.User_Read().Where(y=>y.SIRA_NO == 5).Select(x => x.KULLANICI_ADI).FirstOrDefault();

            if (!IsPostBack)
            {
                DataTable dt = this.GetData();
                StringBuilder html = new StringBuilder();
                foreach (DataRow row in dt.Rows)
                {
                    
                    foreach (DataColumn column in dt.Columns)
                    {
                        if (column.ColumnName == "href")
                        html.Append("<a href=\"" + row[column.ColumnName] +"\" class=\"list-group-item list-group-item-action\" runat=\"server\" id=\"deneme\"><div class=\"notification-info\">");
                        else if (column.ColumnName == "resim")
                        html.Append("<div class=\"notification-list-user-img\"><img src=\""+row[column.ColumnName]+".jpg\" alt=\"\" class=\"user-avatar-md rounded-circle\"></div>");
                        else if(column.ColumnName == "islem")
                        html.Append("<div class=\"notification-list-user-block\"><span class=\"notification-list-user-name\">"+ row[column.ColumnName] + " </span></div>");
                        else if(column.ColumnName == "sure")
                        html.Append("<div class=\"notification-date\">"+row[column.ColumnName]+"</div>");
                       
                    }
                    html.Append("</div></a>");
                }
                string strText = html.ToString();


                notificationlist.Controls.Add(new Literal { Text = html.ToString() });
            }
        }
        private DataTable GetData()
        {
            
            DataTable table = new DataTable();
            table.Columns.Add("href", typeof(string));
            table.Columns.Add("resim", typeof(string));
            table.Columns.Add("islem", typeof(string));
            table.Columns.Add("sure",typeof(DateTime));
            
            
            
            foreach (var item in db.natification_Read().Reverse().ToList())
            {
                table.Rows.Add(item.ACIKLAMA,
                item.CALISAN/*db.User_Read().Where(d=> d.SIRA_NO == item.CALISAN).Select(x=>x.KULLANICI_ADI ).FirstOrDefault().ToString()*/,
                item.ACIKLAMA,
                item.TARIH);

            }
            
            return table;
        }
    }
}