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
    public class cargo_company_business : IDataBaseWrite<c_cargo_company>, IDataBaseRead<V_cargo_company>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_cargo_company t)
        {
            
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public V_cargo_company FilterRead(Expression<Func<V_cargo_company, bool>> filtre)
        {
            throw new NotImplementedException();
        }

        public List<V_cargo_company> Read()
        {
            throw new NotImplementedException();
        }

        public void Update(c_cargo_company t)
        {
            throw new NotImplementedException();
        }
    }
}
