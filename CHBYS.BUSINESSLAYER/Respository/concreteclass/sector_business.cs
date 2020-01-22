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
    public class sector_business : IDataBaseWrite<c_sector>, IDataBaseRead<V_sector>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_sector t)
        {
            DB.SP_sector_INSERT(t.Kodu,t.sector_name,t.explanation);
        }

        public void Delete(int id)
        {
            DB.SP_sector_DELETE(id);
        }

        public V_sector FilterRead(Expression<Func<V_sector, bool>> filtre)
        {
            return DB.V_sector.FirstOrDefault(filtre);
        }

        public List<V_sector> Read()
        {
            return DB.V_sector.ToList();
        }

        public void Update(c_sector t)
        {
            throw new NotImplementedException();
        }
    }
}
