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
    public class suppliers_type_business : IDataBaseWrite<c_suppliers_type>, IDataBaseRead<V_suppliers_type>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_suppliers_type t)
        {
            DB.SP_suppliers_type_INSERT(t.suppliers_type1);
        }

        public void Delete(int id)
        {
            DB.SP_suppliers_type_DELETE(id);
        }

        public V_suppliers_type FilterRead(Expression<Func<V_suppliers_type, bool>> filtre)
        {
          return  DB.V_suppliers_type.FirstOrDefault(filtre);
        }

        public List<V_suppliers_type> Read()
        {
            return DB.V_suppliers_type.ToList();
        }

        public void Update(c_suppliers_type t)
        {
            throw new NotImplementedException();
        }
    }
}
