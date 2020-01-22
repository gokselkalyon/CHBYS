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
    public class e_waybill_business : IDataBaseWrite<c_e_waybill>, IDataBaseRead<V_e_waybill>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_e_waybill t)
        {
            DB.SP_e_waybill_INSERT(t.substation,t.receipt_no,t.documnet_no,t.waybill_no,t.Date,t.currency,t.delivery_address,t.explanation,t.barcode,t.cargo_shipping_date,t.receipt_no,t.subtotal,t.cost,t.discount,t.total,t.KDV,t.Grand_total);
        }

        public void Delete(int id)
        {
            DB.SP_e_waybill_DELETE(id);
        }

        public V_e_waybill FilterRead(Expression<Func<V_e_waybill, bool>> filtre)
        {
            return DB.V_e_waybill.FirstOrDefault(filtre);
        }

        public List<V_e_waybill> Read()
        {
            return DB.V_e_waybill.ToList();
        }

        public void Update(c_e_waybill t)
        {
            throw new NotImplementedException();
        }
    }
}
