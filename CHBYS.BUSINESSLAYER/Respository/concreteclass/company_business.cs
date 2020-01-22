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
    public class company_business : IDataBaseWrite<c_company>, IDataBaseRead<V_company>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_company t)
        {
            DB.SP_company_INSERT(t.company_name,t.company_type,t.city,t.county,t.country,t.Tax_Administration,t.Tax_number);
        }

        public void Delete(int id)
        {
            DB.SP_company_DELETE(id);
        }

        public V_company FilterRead(Expression<Func<V_company, bool>> filtre)
        {
            return DB.V_company.FirstOrDefault(filtre);
        }

        public List<V_company> Read()
        {
            return DB.V_company.ToList();
        }

        public void Update(c_company t)
        {
            throw new NotImplementedException();
        }
    }
}
