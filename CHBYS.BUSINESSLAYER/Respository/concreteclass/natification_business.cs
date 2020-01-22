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
    public class natification_business : IDataBaseWrite<c_natification>, IDataBaseRead<V_natification>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_natification t)
        {
            DB.SP_natification_INSERT(t.explanation,t.ekleyenkullanici);
        }

        public void Delete(int id)
        {
            DB.SP_natification_DELETE(id);
        }

        public V_natification FilterRead(Expression<Func<V_natification, bool>> filtre)
        {
           return DB.V_natification.FirstOrDefault(filtre);
        }

        public List<V_natification> Read()
        {
            return DB.V_natification.ToList();
        }

        public void Update(c_natification t)
        {
            throw new NotImplementedException();
        }
    }
}
