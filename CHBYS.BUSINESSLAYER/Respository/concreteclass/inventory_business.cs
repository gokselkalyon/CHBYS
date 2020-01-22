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
    public class inventory_business : IDataBaseWrite<c_inventory>, IDataBaseRead<V_inventory>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_inventory t)
        {
            DB.SP_inventory_INSERT(t.shelf_life,t.warranty_period,t.quantity,t.note,t.authorization_code,t.payment_plan,t.product_name_1,t.suppliers);
        }

        public void Delete(int id)
        {
            DB.SP_inventory_DELETE(id);
        }

        public V_inventory FilterRead(Expression<Func<V_inventory, bool>> filtre)
        {
            return DB.V_inventory.FirstOrDefault(filtre);
        }

        public List<V_inventory> Read()
        {
            return DB.V_inventory.ToList();
        }

        public void Update(c_inventory t)
        {
            throw new NotImplementedException();
        }
    }
}
