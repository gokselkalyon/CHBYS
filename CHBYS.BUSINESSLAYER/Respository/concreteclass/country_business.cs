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
    public class country_business : IDataBaseWrite<c_country>, IDataBaseRead<V_country>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_country t)
        {
            DB.SP_country_INSERT(t.country_name,t.country_plate_sign,t.Country_name_EN,t.E_declaration);
        }

        public void Delete(int id)
        {
            DB.SP_country_DELETE(id);
        }

        public V_country FilterRead(Expression<Func<V_country, bool>> filtre)
        {
            return DB.V_country.FirstOrDefault(filtre);
        }

        public List<V_country> Read()
        {
            return DB.V_country.ToList();
        }

        public void Update(c_country t)
        {
            throw new NotImplementedException();
        }
    }
}
