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
    public class order_business : IDataBaseWrite<c_order>, IDataBaseRead<V_orders>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_order t)
        {
            DB.SP_orders_INSERT(t.order_name,t.slip_no,t.statu,t.document_no,t.date,t.cost,t.total,t.ordered_goods,t.explanation);
        }

        public void Delete(int id)
        {
            DB.SP_orders_DELETE(id);
        }

        public V_orders FilterRead(Expression<Func<V_orders, bool>> filtre)
        {
           return DB.V_orders.FirstOrDefault(filtre);
        }

        public List<V_orders> Read()
        {
            return DB.V_orders.ToList();
        }

        public void Update(c_order t)
        {
            throw new NotImplementedException();
        }
    }
}
