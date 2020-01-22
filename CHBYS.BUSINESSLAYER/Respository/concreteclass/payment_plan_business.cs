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
    public class payment_plan_business : IDataBaseWrite<c_payment_plan>, IDataBaseRead<V_payment_plan>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_payment_plan t)
        {
            DB.SP_payment_plan_INSERT(t.code,t.discount,t.explanation);
        }

        public void Delete(int id)
        {
            DB.SP_payment_plan_DELETE(id);
        }

        public V_payment_plan FilterRead(Expression<Func<V_payment_plan, bool>> filtre)
        {
            return DB.V_payment_plan.FirstOrDefault(filtre);
        }

        public List<V_payment_plan> Read()
        {
            return DB.V_payment_plan.ToList();
        }

        public void Update(c_payment_plan t)
        {
            throw new NotImplementedException();
        }
    }
}
