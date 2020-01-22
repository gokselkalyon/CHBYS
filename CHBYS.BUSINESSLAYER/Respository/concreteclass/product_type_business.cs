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
    public class product_type_business : IDataBaseWrite<c_product_type>, IDataBaseRead<V_product_type>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_product_type t)
        {
            DB.SP_product_type_INSERT(t.Ekleyen_Kullanici,t.Explanation);
        }

        public void Delete(int id)
        {
            DB.SP_product_type_DELETE(id);
        }

        public V_product_type FilterRead(Expression<Func<V_product_type, bool>> filtre)
        {
            return DB.V_product_type.FirstOrDefault(filtre);
        }

        public List<V_product_type> Read()
        {
            return DB.V_product_type.ToList();
        }

        public void Update(c_product_type t)
        {
            throw new NotImplementedException();
        }
    }
}
