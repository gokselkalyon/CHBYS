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
    public class product_refund_business : IDataBaseWrite<c_product_refund>, IDataBaseRead<V_product_refund>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_product_refund t)
        {
            DB.SP_product_refund_INSERT(t.reason_for_return,t.return_quantity,t.returned_date);
        }

        public void Delete(int id)
        {
            DB.SP_product_refund_DELETE(id);
        }

        public V_product_refund FilterRead(Expression<Func<V_product_refund, bool>> filtre)
        {
            return DB.V_product_refund.FirstOrDefault(filtre);
        }

        public List<V_product_refund> Read()
        {
            return DB.V_product_refund.ToList();
        }

        public void Update(c_product_refund t)
        {
            throw new NotImplementedException();
        }
    }
}
