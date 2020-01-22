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
    public class shipment_slip_business : IDataBaseWrite<c_shipment_slip>, IDataBaseRead<V_shipment_slip>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_shipment_slip t)
        {
            DB.SP_shipment_slip_INSERT(t.type,t.voucher_no,t.date,t.delivery,t.explanation,t.pakaging,t.cargo_delivery_date,t.cargo_invoice_no,t.total);
        }

        public void Delete(int id)
        {
            DB.SP_shipment_slip_DELETE(id);
        }

        public V_shipment_slip FilterRead(Expression<Func<V_shipment_slip, bool>> filtre)
        {
            return DB.V_shipment_slip.FirstOrDefault(filtre);
        }

        public List<V_shipment_slip> Read()
        {
            return DB.V_shipment_slip.ToList();
        }

        public void Update(c_shipment_slip t)
        {
            throw new NotImplementedException();
        }
    }
}
