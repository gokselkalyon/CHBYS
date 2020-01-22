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
    public class main_unit_business : IDataBaseWrite<c_main_unit>, IDataBaseRead<V_main_unit>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_main_unit t)
        {
            DB.SP_main_unit_INSERT(t.Unit_name,t.comment);
        }

        public void Delete(int id)
        {
            DB.SP_main_unit_DELETE(id);
        }

        public V_main_unit FilterRead(Expression<Func<V_main_unit, bool>> filtre)
        {
            return DB.V_main_unit.FirstOrDefault(filtre);
        }

        public List<V_main_unit> Read()
        {
            return DB.V_main_unit.ToList();
        }

        public void Update(c_main_unit t)
        {
            throw new NotImplementedException();
        }
    }
}
