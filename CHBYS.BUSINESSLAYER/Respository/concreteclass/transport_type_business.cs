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
    public class transport_type_business : IDataBaseWrite<c_transport_type>, IDataBaseRead<V_transport_type>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_transport_type t)
        {
            DB.SP_transport_type_INSERT(t.type,t.explanation);
        }

        public void Delete(int id)
        {
            DB.SP_transport_type_DELETE(id);
        }

        public V_transport_type FilterRead(Expression<Func<V_transport_type, bool>> filtre)
        {
            return DB.V_transport_type.FirstOrDefault(filtre);
        }

        public List<V_transport_type> Read()
        {
            return DB.V_transport_type.ToList();
        }

        public void Update(c_transport_type t)
        {
            throw new NotImplementedException();
        }
    }
}
