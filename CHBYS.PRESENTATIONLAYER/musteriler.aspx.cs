using CHBYS.PRESENTATIONLAYER.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CHBYS.PRESENTATIONLAYER
{
    public partial class musteriler : System.Web.UI.Page
    {
        string id;

        protected void Page_Load(object sender, EventArgs e)
        {
            Service1Client db = new Service1Client();
            ddlcity.DataSource = db.city_Read().Select(x => x.SEHIR_ADI);
            ddlcountry.DataSource = db.country_Read().Select(x => x.ULKE_ADI);
            ddlcounty.DataSource = db.county_Read().Select(x => x.ILCE);
            ddleinvoicetype.DataSource = db.E_invoice_type_Read().Select(x => x.FATURA_TIPI);
            ddlpaymentplan.DataSource = db.payment_plan_Read().Select(x => x.ACIKLAMA);
            ddlsector.DataSource = db.sector_Read().Select(x => x.SECTOR_ADI);
            ddlsupptype.DataSource = db.suppliers_type_Read().Select(x => x.CARI_TIPI);
            ddltaxadmin.DataSource = db.Tax_Administration_Read().Select(x => x.VERGI_DAIRESI_ADI);

            ddlcity.DataBind();
            ddlcountry.DataBind();
            ddlcounty.DataBind();
            ddleinvoicetype.DataBind();
            ddlpaymentplan.DataBind();
            ddlsector.DataBind();
            ddlsupptype.DataBind();
            ddltaxadmin.DataBind();

            gridread();
        }

        private void gridread()
        {
            Service1Client db = new Service1Client();
            gv1.DataSource = db.supplier_Read();
            gv1.DataBind();
        }
        
        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            Service1Client db = new Service1Client();
            
            int city = db.city_Read().Where(x => x.SEHIR_ADI == ddlcity.Text).Select(x => x.KODU).FirstOrDefault();
            int country = db.country_Read().Where(x => x.ULKE_ADI == ddlcountry.Text).Select(x => x.SIRA_NO).FirstOrDefault();
            int county = db.county_Read().Where(x => x.ILCE == ddlcounty.Text).Select(x => x.NO).FirstOrDefault();
            int ekleyenkullanici = db.User_Read().Where(x => x.KULLANICI_ADI == Session["username"].ToString()).Select(x => x.SIRA_NO).FirstOrDefault();
            int einvoice = db.E_invoice_type_Read().Where(x => x.FATURA_TIPI == ddleinvoicetype.Text).Select(x => x.SIRA_NO).FirstOrDefault();
            int paymentplan = db.payment_plan_Read().Where(x => x.ACIKLAMA == ddlpaymentplan.Text).Select(x => x.SIRA_NO).FirstOrDefault();
            int sector = db.sector_Read().Where(x => x.SECTOR_ADI == ddlsector.Text).Select(x => x.KODU).FirstOrDefault();
            int supplierstype = db.suppliers_type_Read().Where(x => x.CARI_TIPI == ddlsupptype.Text).Select(x => x.SIRA_NO).FirstOrDefault();
            int taxadmin = db.Tax_Administration_Read().Where(x => x.VERGI_DAIRESI_ADI == ddltaxadmin.Text).Select(x => x.SIRA_NO).FirstOrDefault();

            db.supplier_insert(new c_supplier
            {
                adress = txtadress.Text,
                appellation = txtappellation.Text,
                city = city,
                country = country,
                county = county,
                Ekleyen_Kullanici = ekleyenkullanici,
                explanation = txtaciklama.Text,
                E_invoice_type = einvoice,
                E_mail = txtemail.Text,
                fax = txtfax.Text,
                mobilephone = txtmobilephone.Text,
                payment_plan = paymentplan,
                post_code = txtpostcode.Text,
                sector = sector,
                statu = true,
                suppliers_Code = txtsuppliers_Code.Text,
                suppliers_type = supplierstype,
                Tax_Administration = taxadmin,
                Tax_Administration_number = txttaxnumber.Text,
                telephone = txtphone.Text
            });
            db.natification_insert(new c_natification { explanation = "cari kayit islemi yapıldı",ekleyenkullanici = ekleyenkullanici });
            gridread();

        }

        protected void btnsil_Click(object sender, EventArgs e)
        {
            id = Label1.Text;
                Service1Client db = new Service1Client();
            int ekleyenkullanici = db.User_Read().Where(x => x.KULLANICI_ADI == Session["username"].ToString()).Select(x => x.SIRA_NO).FirstOrDefault();

            db.supplier_Delete(Convert.ToInt32(id));//delete işlemi yapılıyor
                gridread();
                 db.natification_insert(new c_natification { explanation = "cari silme islemi yapıldı", ekleyenkullanici = ekleyenkullanici });
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            Label1.Text = gv1.SelectedRow.Cells[17].Text;//sıra no alınıyor
            Service1Client db = new Service1Client();
            V_suppliers s = db.supplier_Read().Where(x => x.SIRA_NO == Convert.ToInt32(Label1.Text)).FirstOrDefault();
            txtaciklama.Text = s.ACIKLAMA.ToString();
            txtadress.Text = s.ADRES.ToString();
            txtappellation.Text = s.UNVAN.ToString();
            txtemail.Text = s.E_MAIL.ToString();
            txtfax.Text = s.FAX.ToString();
            txtmobilephone.Text = s.CEP_TELEFON.ToString();
            txtphone.Text = s.TELEFON_1.ToString();
            txtpostcode.Text = s.POSTA_KODU.ToString();
            txtsuppliers_Code.Text = s.CARI_KOD.ToString();
            txttaxnumber.Text = s.VERGI_KODU.ToString();

            ddlcity.Text = s.SEHIR.ToString();
            ddlcountry.Text = s.ULKE.ToString();
            ddlcounty.Text = s.ILCE.ToString();
            ddleinvoicetype.Text = s.E_FATURA_TIPI.ToString();
            ddlpaymentplan.Text = s.INDIRIM_PLANI.ToString();
            ddlsector.Text = s.SEKTOR.ToString();
            ddlsupptype.Text = s.CARI_TIPI.ToString();
            ddltaxadmin.Text = s.VERGI_DAIRESI.ToString();
            
        }
        
        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            Service1Client db = new Service1Client();
            int ID = Convert.ToInt32(Label1.Text);
            int city = db.city_Read().Where(x => x.SEHIR_ADI == ddlcity.Text).Select(x => x.KODU).FirstOrDefault();
            int country = db.country_Read().Where(x => x.ULKE_ADI == ddlcountry.Text).Select(x => x.SIRA_NO).FirstOrDefault();
            int county = db.county_Read().Where(x => x.ILCE == ddlcounty.Text).Select(x => x.NO).FirstOrDefault();
            int ekleyenkullanici = db.User_Read().Where(x => x.KULLANICI_ADI == Session["username"].ToString()).Select(x => x.SIRA_NO).FirstOrDefault();
            int einvoice = db.E_invoice_type_Read().Where(x => x.FATURA_TIPI == ddleinvoicetype.Text).Select(x => x.SIRA_NO).FirstOrDefault();
            int paymentplan = db.payment_plan_Read().Where(x => x.ACIKLAMA == ddlpaymentplan.Text).Select(x => x.SIRA_NO).FirstOrDefault();
            int sector = db.sector_Read().Where(x => x.SECTOR_ADI == ddlsector.Text).Select(x => x.KODU).FirstOrDefault();
            int supplierstype = db.suppliers_type_Read().Where(x => x.CARI_TIPI == ddlsupptype.Text).Select(x => x.SIRA_NO).FirstOrDefault();
            int taxadmin = db.Tax_Administration_Read().Where(x => x.VERGI_DAIRESI_ADI == ddltaxadmin.Text).Select(x => x.SIRA_NO).FirstOrDefault();

            db.supplier_update(new c_supplier {
                Id = ID ,
                adress = txtadress.Text,
                appellation = txtappellation.Text,
                city = city,
                country = country,
                county = county,
                Ekleyen_Kullanici = ekleyenkullanici,
                explanation = txtaciklama.Text,
                E_invoice_type = einvoice,
                E_mail = txtemail.Text,
                fax = txtfax.Text,
                mobilephone = txtmobilephone.Text,
                payment_plan = paymentplan,
                post_code =txtpostcode.Text,
                sector = sector,
                statu  = true,
                suppliers_Code = txtsuppliers_Code.Text,
                suppliers_type = supplierstype,
                Tax_Administration = taxadmin,
                Tax_Administration_number =txttaxnumber.Text,
                telephone = txtphone.Text
            });
            db.natification_insert(new c_natification { explanation = "cari guncelleme islemi yapıldı", ekleyenkullanici = ekleyenkullanici });
            gridread();
        }
    }
}


//public FileResult excel()
//{
//    IWorkbook workbook = new HSSFWorkbook(); //döküman
//    ISheet sheet1 = workbook.CreateSheet("product 12"); //sayfa

//    productmanager pm = new productmanager();//

//    var style = workbook.CreateCellStyle();//sitil dosyası
//    style.FillForegroundColor = HSSFColor.Blue.Index2; //renk
//    style.Alignment = HorizontalAlignment.Center;// metin hizalama
//    style.VerticalAlignment = VerticalAlignment.Center;//metin hzalama
//    style.FillPattern = FillPattern.SolidForeground;// renk doldurma

//    sheet1.AddMergedRegion(new CellRangeAddress(0, 1, 0, 9));//birleştirme
//    var rowIndex = 0;
//    var row = sheet1.CreateRow(rowIndex).CreateCell(0);
//    row.CellStyle = style;
//    row.SetCellValue("deneme son vol:3");

//    rowIndex += 2;
//    foreach (var item in pm.read())
//    {
//        var row1 = sheet1.CreateRow(rowIndex);
//        row1.CreateCell(0).SetCellValue(item.product_name);//hücre değerleri
//        sheet1.AutoSizeColumn(0);// hücre veriye göre boyutlandırma
//        row1.CreateCell(1).SetCellValue(item.cargo.cargo_company);
//        sheet1.AutoSizeColumn(1);
//        row1.CreateCell(2).SetCellValue(item.category.category_name);
//        sheet1.AutoSizeColumn(8);
//        row1.CreateCell(3).SetCellValue(item.cargo_type.cargo_type1);
//        sheet1.AutoSizeColumn(2);
//        row1.CreateCell(4).SetCellValue(item.product_content);
//        sheet1.AutoSizeColumn(3);
//        row1.CreateCell(5).SetCellValue(item.product_add_time.ToString());
//        sheet1.AutoSizeColumn(4);
//        row1.CreateCell(6).SetCellValue(item.product_price.ToString());
//        sheet1.AutoSizeColumn(5);
//        row1.CreateCell(7).SetCellValue(item.product_quantity.ToString());
//        sheet1.AutoSizeColumn(6);
//        row1.CreateCell(8).SetCellValue(item.prouct_image_path);
//        sheet1.AutoSizeColumn(7);
//        row1.CreateCell(9).SetCellValue(item.repository.repository_name);
//        sheet1.AutoSizeColumn(9);
//        rowIndex++;

//    }
//    var stream = new MemoryStream();
//    workbook.Write(stream);

//    return File(new MemoryStream(stream.GetBuffer()), "application/vdn.ms-excel", "producttable.xls");

//}