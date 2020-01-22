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
    public class User_business : IDataBaseWrite<c_User>, IDataBaseRead<V_Users>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_User t)
        {
            DB.SP_Users_INSERT(t.user_name, t.password, t.employee, t.company, t.authority);
        }

        public void Delete(int id)
        {
            DB.SP_Users_DELETE(id);
        }

        public V_Users FilterRead(Expression<Func<V_Users, bool>> filtre)
        {
            return DB.V_Users.FirstOrDefault(filtre);
        }

        public List<V_Users> Read()
        {
            return DB.V_Users.ToList();
        }

        public void Update(c_User t)
        {
            throw new NotImplementedException();
        }
    }
}
