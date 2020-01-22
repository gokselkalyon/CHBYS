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
    public class Tax_Administration_business : IDataBaseWrite<c_Tax_Administration>, IDataBaseRead<V_Tax_Administration>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_Tax_Administration t)
        {
            DB.SP_Tax_Administration_INSERT(t.Tax_Administration_name,t.Tax_Administration_code,t.city);
        }

        public void Delete(int id)
        {
            DB.SP_Tax_Administration_DELETE(id);
        }

        public V_Tax_Administration FilterRead(Expression<Func<V_Tax_Administration, bool>> filtre)
        {
            return DB.V_Tax_Administration.FirstOrDefault(filtre);
        }

        public List<V_Tax_Administration> Read()
        {
            return DB.V_Tax_Administration.ToList();
        }

        public void Update(c_Tax_Administration t)
        {
            throw new NotImplementedException();
        }
    }
}
