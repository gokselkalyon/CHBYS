using CHBYS.PRESENTATIONLAYER.ServiceReference1;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.UI.WebControls;

namespace CHBYS.PRESENTATIONLAYER
{
    public partial class satis : System.Web.UI.Page
    {
        private string id;

        protected void Page_Load(object sender, EventArgs e)
        {
            ddlpaymentplan.DataSource= db.payment_plan_Read().Select(x => x.ACIKLAMA).ToList();
            ddlpaymentplan.DataBind();
            ddlcurrency.DataSource = db.currency_Read().Select(x => x.BIRIM).ToList();
            ddlcurrency.DataBind();
            ddlsoldproduct1.DataSource = db.barcode_Read().Select(x => x.YORUM).ToList();
            ddlsoldproduct1.DataBind();
            gridread();
        }

        private Service1Client db = new Service1Client();

        private void gridread()
        {
            gvsoldproduct.DataSource = db.sold_product_Read();
            gvsoldproduct.DataBind();
        }

        protected void gvsoldproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataid.Text = gvsoldproduct.SelectedRow.Cells[8].Text;//sıra no alınıyor
            V_sold_product p = db.sold_product_Read().Where(x => x.SIRA_NO == Convert.ToInt32(dataid.Text)).FirstOrDefault();

            txtBelgeno.Text = p.DOKUMAN_NO.ToString();
            txtcost.Text = p.MALIYET.Value.ToString();
            txtTarih.Text = p.TARIH.Value.ToString();
            txttotalfiyat.Text = p.TOPLAM.ToString();

            ddlcurrency.SelectedValue = p.BIRIM.ToString();
            ddlvechile.Text = p.ARAC.ToString();
            ddlpaymentplan.Text = p.ODEME_PLANI.ToString();
            ddlsoldproduct1.Text = p.SATILAN_URUN.ToString();
        }

        protected void btnsil_Click(object sender, EventArgs e)
        {

            id = dataid.Text;
            db.sold_product_Delete(Convert.ToInt32(id));//delete işlemi yapılıyor
            gridread();
        }


        public void excel()
        {
            IWorkbook workbook = new HSSFWorkbook(); //döküman
            ISheet sheet1 = workbook.CreateSheet("product 12"); //sayfa

            List<V_sold_product> pm = db.sold_product_Read().ToList();

            var style = workbook.CreateCellStyle();//sitil dosyası
            style.FillForegroundColor = HSSFColor.Blue.Index2; //renk
            style.Alignment = HorizontalAlignment.Center;// metin hizalama
            style.VerticalAlignment = VerticalAlignment.Center;//metin hzalama
            style.FillPattern = FillPattern.LessDots;// renk doldurma

            sheet1.AddMergedRegion(new CellRangeAddress(0, 1, 0, 8));//birleştirme
            var rowIndex = 0;
            var row = sheet1.CreateRow(rowIndex).CreateCell(0);
            row.CellStyle = style;
            row.SetCellValue("deneme son vol:3");

            rowIndex += 2;

            var row2 = sheet1.CreateRow(rowIndex);
            row2.CreateCell(0).SetCellValue("SIRA NO");//hücre değerleri
            sheet1.AutoSizeColumn(0);// hücre veriye göre boyutlandırma
            row2.CreateCell(1).SetCellValue("ARAC");
            sheet1.AutoSizeColumn(1);
            row2.CreateCell(2).SetCellValue("DOKUMAN NO");
            sheet1.AutoSizeColumn(8);
            row2.CreateCell(3).SetCellValue("BIRIM");
            sheet1.AutoSizeColumn(2);
            row2.CreateCell(4).SetCellValue("ODEME PLANI");
            sheet1.AutoSizeColumn(3);
            row2.CreateCell(5).SetCellValue("SATILAN URUN");
            sheet1.AutoSizeColumn(4);
            row2.CreateCell(6).SetCellValue("MALIYET");
            sheet1.AutoSizeColumn(5);
            row2.CreateCell(7).SetCellValue("TOPLAM");
            sheet1.AutoSizeColumn(6);
            row2.CreateCell(8).SetCellValue("EKLEME TARIHI");
            sheet1.AutoSizeColumn(7);
            rowIndex++;

            foreach (var item in pm)
            {
                var row1 = sheet1.CreateRow(rowIndex);
                row1.CreateCell(0).SetCellValue(item.SIRA_NO);//hücre değerleri
                sheet1.AutoSizeColumn(0);// hücre veriye göre boyutlandırma
                row1.CreateCell(1).SetCellValue(item.ARAC);
                sheet1.AutoSizeColumn(1);
                row1.CreateCell(2).SetCellValue(item.DOKUMAN_NO);
                sheet1.AutoSizeColumn(8);
                row1.CreateCell(3).SetCellValue(item.BIRIM);
                sheet1.AutoSizeColumn(2);
                row1.CreateCell(4).SetCellValue(item.ODEME_PLANI);
                sheet1.AutoSizeColumn(3);
                row1.CreateCell(5).SetCellValue(item.SATILAN_URUN.ToString());
                sheet1.AutoSizeColumn(4);
                row1.CreateCell(6).SetCellValue(item.MALIYET.ToString());
                sheet1.AutoSizeColumn(5);
                row1.CreateCell(7).SetCellValue(item.TOPLAM.ToString());
                sheet1.AutoSizeColumn(6);
                row1.CreateCell(8).SetCellValue(item.EKLEME_TARIHI.Value);
                sheet1.AutoSizeColumn(7);
                rowIndex++;

            }
            MemoryStream stream = new MemoryStream();
            workbook.Write(stream);


            Response.Clear();
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("content-disposition", "attachment; producttable.xls");
            Response.AddHeader("content-length", stream.Length.ToString());
            Response.BinaryWrite(stream.ToArray());
            Response.End();
        }

        protected void btnexcel_Click(object sender, EventArgs e)
        {
            excel();
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
                id = dataid.Text;

            int soldp = Convert.ToInt32(db.barcode_Read().Where(x => x.YORUM == ddlsoldproduct1.Text).Select(x => x.BARKOD).FirstOrDefault());
            int curr = Convert.ToInt32(db.currency_Read().Where(x => x.BIRIM == ddlcurrency.Text).Select(x => x.SIRA_NO).FirstOrDefault());
            int paymentp = Convert.ToInt32(db.payment_plan_Read().Where(x => x.ACIKLAMA == ddlpaymentplan.Text).Select(x => x.SIRA_NO).FirstOrDefault());
            db.sold_product_update(new c_sold_product
            {
                id = Convert.ToInt32(this.id),
                document_no = txtBelgeno.Text.ToString(),
                total = Convert.ToDecimal(txttotalfiyat.Text),
                cost = Convert.ToDecimal(txtcost.Text),
                date = DateTime.Now,
                sold_product1 = soldp,
                currency = curr,
                vehicle = 1,
                payment_plan = paymentp
            });
            gridread();
        }

        protected void btnFaturakaydet_Click(object sender, EventArgs e)
        {
            id = dataid.Text;
            int soldp = Convert.ToInt32(db.barcode_Read().Where(x => x.YORUM == ddlsoldproduct1.Text).Select(x => x.BARKOD).FirstOrDefault());
            int curr = Convert.ToInt32(db.currency_Read().Where(x => x.BIRIM == ddlcurrency.Text).Select(x => x.SIRA_NO).FirstOrDefault());
            int paymentp = Convert.ToInt32(db.payment_plan_Read().Where(x => x.ACIKLAMA == ddlpaymentplan.Text).Select(x => x.SIRA_NO).FirstOrDefault());
            db.sold_product_insert(new c_sold_product
            {
                document_no = txtBelgeno.Text.ToString(),
                total = Convert.ToDecimal(txttotalfiyat.Text),
                cost = Convert.ToDecimal(txtcost.Text),
                date = DateTime.Now,
                sold_product1 = soldp,
                currency = curr,
                vehicle = 1,
                payment_plan = paymentp
            });
            gridread();
        }
    }
}







