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
    public class county_business : IDataBaseWrite<c_county>, IDataBaseRead<V_county>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_county t)
        {
            DB.SP_county_INSERT(t.plate_code,t.county_name);
        }

        public void Delete(int id)
        {
            DB.SP_county_DELETE(id);
        }

        public V_county FilterRead(Expression<Func<V_county, bool>> filtre)
        {
            return DB.V_county.FirstOrDefault(filtre);
        }

        public List<V_county> Read()
        {
            return DB.V_county.ToList();
        }

        public void Update(c_county t)
        {
            throw new NotImplementedException();
        }
    }
}
