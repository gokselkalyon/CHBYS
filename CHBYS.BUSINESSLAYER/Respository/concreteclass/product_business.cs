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
    public class product_business : IDataBaseWrite<c_product>, IDataBaseRead<V_product>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_product t)
        {
            DB.SP_product_INSERT(t.product_type,t.group_code,t.brand);
        }

        public void Delete(int id)
        {
            DB.SP_product_DELETE(id);
        }

        public V_product FilterRead(Expression<Func<V_product, bool>> filtre)
        {
            return DB.V_product.FirstOrDefault(filtre);
        }

        public List<V_product> Read()
        {
            return DB.V_product.ToList();
        }

        public void Update(c_product t)
        {
            throw new NotImplementedException();
        }
    }
}
