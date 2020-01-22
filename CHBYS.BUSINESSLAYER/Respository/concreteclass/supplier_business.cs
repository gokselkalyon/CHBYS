using CHBYS.BUSINESSLAYER.Respository.abstractclass;
using CHBYS.ENTITIES;
using CHBYS.ENTITIES.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.BUSINESSLAYER.Respository.concreteclass
{
    public class supplier_business : IDataBaseWrite<c_supplier>, IDataBaseRead<V_suppliers>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_supplier t)
        {
            DB.SP_suppliers_INSERT(
                t.suppliers_type,t.suppliers_Code,t.appellation,t.statu,
                t.explanation,t.Tax_Administration,t.Tax_Administration_number,
                t.E_mail,t.E_invoice_type,t.adress,t.post_code,t.city,t.county,
                t.country,t.mobilephone,t.telephone,t.fax,t.sector,t.payment_plan,
                t.Ekleyen_Kullanici,DateTime.Now);
        }

        public void Delete(int id)
        {
            DB.SP_suppliers_DELETE(id);
        }

        public V_suppliers FilterRead(Expression<Func<V_suppliers, bool>> filtre)
        {
           return DB.V_suppliers.FirstOrDefault(filtre);
        }

        public List<V_suppliers> Read()
        {
            return DB.V_suppliers.ToList();
        }

        public void Update(c_supplier t)
        {
            DB.SP_c_UPDATE(
                t.Id,
                t.suppliers_type, t.suppliers_Code, t.appellation, t.statu,
                t.explanation, t.Tax_Administration, t.Tax_Administration_number,
                t.E_mail, t.E_invoice_type, t.adress, t.post_code, t.city, t.county,
                t.country, t.mobilephone, t.telephone, t.fax, t.sector, t.payment_plan,
                t.Ekleyen_Kullanici, DateTime.Now);
        }
    }
}
