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
    public class group_type_business : IDataBaseWrite<c_group_type>, IDataBaseRead<V_group_type>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_group_type t)
        {
            DB.SP_group_type_INSERT(t.type_name);
        }

        public void Delete(int id)
        {
            DB.SP_group_type_DELETE(id);
        }

        public V_group_type FilterRead(Expression<Func<V_group_type, bool>> filtre)
        {
            return DB.V_group_type.FirstOrDefault(filtre);
        }

        public List<V_group_type> Read()
        {
            return DB.V_group_type.ToList();
        }

        public void Update(c_group_type t)
        {
            throw new NotImplementedException();
        }
    }
}
