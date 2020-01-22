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
    public class payment_method_business : IDataBaseWrite<c_payment_method>, IDataBaseRead<V_payment_method>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_payment_method t)
        {
            DB.SP_payment_method_INSERT(t.Method,t.explanation);
        }

        public void Delete(int id)
        {
            DB.SP_payment_method_DELETE(id);
        }

        public V_payment_method FilterRead(Expression<Func<V_payment_method, bool>> filtre)
        {
            return DB.V_payment_method.FirstOrDefault(filtre);
        }

        public List<V_payment_method> Read()
        {
            return DB.V_payment_method.ToList();
        }

        public void Update(c_payment_method t)
        {
            throw new NotImplementedException();
        }
    }
}
