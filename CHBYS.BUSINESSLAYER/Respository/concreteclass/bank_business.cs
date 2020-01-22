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
    public class bank_business : IDataBaseWrite<c_bank>, IDataBaseRead<V_bank>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_bank t)
        {
            DB.SP_bank_INSERT(t.bank_name,t.explanation);
        }

        public void Delete(int id)
        {
            DB.SP_bank_DELETE(id);
        }

        public V_bank FilterRead(Expression<Func<V_bank, bool>> filtre)
        {
            return DB.V_bank.SingleOrDefault(filtre);
        }

        public List<V_bank> Read()
        {
            return DB.V_bank.ToList();
        }

        public void Update(c_bank t)
        {
            throw new NotImplementedException();
        }
    }
}
