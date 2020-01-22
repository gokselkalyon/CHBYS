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
    public class Users_authority_business : IDataBaseWrite<c_Users_authority>, IDataBaseRead<V_Users_authority>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_Users_authority t)
        {
            DB.SP_Users_authority_INSERT(t.authority);
        }

        public void Delete(int id)
        {
            DB.SP_Users_authority_DELETE(id);
        }

        public V_Users_authority FilterRead(Expression<Func<V_Users_authority, bool>> filtre)
        {
            return DB.V_Users_authority.FirstOrDefault(filtre);
        }

        public List<V_Users_authority> Read()
        {
            return DB.V_Users_authority.ToList();
        }

        public void Update(c_Users_authority t)
        {
            throw new NotImplementedException();
        }
    }
}
