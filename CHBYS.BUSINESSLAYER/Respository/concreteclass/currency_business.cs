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
    public class currency_business : IDataBaseWrite<c_currency>, IDataBaseRead<V_currency>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_currency t)
        {
            DB.SP_currency_INSERT(t.unit);
        }

        public void Delete(int id)
        {
            DB.SP_currency_DELETE(id);
        }

        public V_currency FilterRead(Expression<Func<V_currency, bool>> filtre)
        {
            return DB.V_currency.FirstOrDefault(filtre);
        }

        public List<V_currency> Read()
        {
            return DB.V_currency.ToList();
        }

        public void Update(c_currency t)
        {
            throw new NotImplementedException();
        }
    }
}
