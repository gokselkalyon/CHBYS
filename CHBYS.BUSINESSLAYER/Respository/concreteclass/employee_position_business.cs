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
    public class employee_position_business : IDataBaseWrite<c_employee_position>, IDataBaseRead<V_employee_position>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_employee_position t)
        {
            DB.SP_employee_position_INSERT(t.position);
        }

        public void Delete(int id)
        {
            DB.SP_employee_position_DELETE(id);
        }

        public V_employee_position FilterRead(Expression<Func<V_employee_position, bool>> filtre)
        {
            return DB.V_employee_position.FirstOrDefault(filtre);
        }

        public List<V_employee_position> Read()
        {
            return DB.V_employee_position.ToList();
        }

        public void Update(c_employee_position t)
        {
            throw new NotImplementedException();
        }
    }
}
