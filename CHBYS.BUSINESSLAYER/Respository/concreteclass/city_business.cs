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
    public class city_business : IDataBaseWrite<c_city>, IDataBaseRead<V_city>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_city t)
        {
            DB.SP_city_INSERT(t.plate_code,t.city_name);
        }

        public void Delete(int id)
        {
            DB.SP_city_DELETE(id);
        }

        public V_city FilterRead(Expression<Func<V_city, bool>> filtre)
        {
            return DB.V_city.FirstOrDefault(filtre);
        }

        public List<V_city> Read()
        {
            return DB.V_city.ToList();
        }

        public void Update(c_city t)
        {
            throw new NotImplementedException();
        }
    }
}
