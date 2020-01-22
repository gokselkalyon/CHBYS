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
    public class brand_business : IDataBaseWrite<c_brand>, IDataBaseRead<V_brand>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_brand t)
        {
            DB.SP_brand_INSERT(t.Code,t.brand_name);
        }

        public void Delete(int id)
        {
            DB.SP_brand_DELETE(id);
        }

        public V_brand FilterRead(Expression<Func<V_brand, bool>> filtre)
        {
            return DB.V_brand.FirstOrDefault(filtre);
        }

        public List<V_brand> Read()
        {
            return DB.V_brand.ToList();
        }

        public void Update(c_brand t)
        {
            throw new NotImplementedException();
        }
    }
}
