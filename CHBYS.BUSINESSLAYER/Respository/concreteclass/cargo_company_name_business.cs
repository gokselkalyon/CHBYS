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
    public class cargo_company_name_business : IDataBaseWrite<c_cargo_company_name>, IDataBaseRead<V_cargo_company_name>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_cargo_company_name t)
        {
            DB.SP_cargo_company_name_INSERT(t.company_name,t.explanation);
        }

        public void Delete(int id)
        {
            DB.SP_cargo_company_name_DELETE(id);
        }

        public V_cargo_company_name FilterRead(Expression<Func<V_cargo_company_name, bool>> filtre)
        {
            return DB.V_cargo_company_name.FirstOrDefault(filtre);
        }

        public List<V_cargo_company_name> Read()
        {
            return DB.V_cargo_company_name.ToList();
        }

        public void Update(c_cargo_company_name t)
        {
            throw new NotImplementedException();
        }
    }
}
