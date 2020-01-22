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
    public class sold_product_business : IDataBaseWrite<c_sold_product>, IDataBaseRead<V_sold_product>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();

        public void Create(c_sold_product t)
        {
            DB.SP_sold_product_INSERT(t.document_no,t.date,t.cost,t.total,t.sold_product1,t.currency,t.payment_plan);
        }

        public void Delete(int id)
        {
            DB.SP_sold_product_DELETE(id);
        }

        public V_sold_product FilterRead(Expression<Func<V_sold_product, bool>> filtre)
        {
            return DB.V_sold_product.FirstOrDefault(filtre);
        }

        public List<V_sold_product> Read()
        {
            return DB.V_sold_product.ToList();
        }

        public void Update(c_sold_product t)
        {
            DB.SP_sold_product_UPDATE(t.document_no,t.cost,t.total,t.sold_product1,t.currency,t.payment_plan,t.vehicle,t.id);
        }
    }
}
