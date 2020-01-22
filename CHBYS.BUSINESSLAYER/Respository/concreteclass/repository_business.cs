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
    public class repository_business : IDataBaseWrite<c_repository>, IDataBaseRead<V_repository>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_repository t)
        {
            DB.SP_repository_INSERT(t.city,t.county,t.country,t.repository_name);
        }

        public void Delete(int id)
        {
            DB.SP_repository_DELETE(id);
        }

        public V_repository FilterRead(Expression<Func<V_repository, bool>> filtre)
        {
            return DB.V_repository.FirstOrDefault(filtre);
        }

        public List<V_repository> Read()
        {
            return DB.V_repository.ToList();
        }

        public void Update(c_repository t)
        {
            throw new NotImplementedException();
        }
    }
}
