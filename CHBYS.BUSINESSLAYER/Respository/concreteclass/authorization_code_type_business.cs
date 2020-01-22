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
    public class authorization_code_type_business : IDataBaseWrite<c_authorization_code_type>, IDataBaseRead<V_authorization_code_type>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_authorization_code_type t)
        {
            DB.SP_authorization_code_type_INSERT(t.type_name);
        }

        public void Delete(int id)
        {
            DB.SP_authorization_code_type_DELETE(id);
        }

        public V_authorization_code_type FilterRead(Expression<Func<V_authorization_code_type, bool>> filtre)
        {
           return DB.V_authorization_code_type.SingleOrDefault(filtre);
        }

        public List<V_authorization_code_type> Read()
        {
            return DB.V_authorization_code_type.ToList();
        }

        public void Update(c_authorization_code_type t)
        {
            throw new NotImplementedException();
        }
    }
}
