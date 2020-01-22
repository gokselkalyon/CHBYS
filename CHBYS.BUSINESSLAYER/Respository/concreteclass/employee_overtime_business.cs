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
    public class employee_overtime_business : IDataBaseWrite<c_employee_overtime>, IDataBaseRead<V_employee_overtime>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_employee_overtime t)
        {
            DB.SP_employee_overtime_INSERT(t.employee,t.business_start,t.business_finish);
        }

        public void Delete(int id)
        {
            DB.SP_employee_overtime_DELETE(id);
        }

        public V_employee_overtime FilterRead(Expression<Func<V_employee_overtime, bool>> filtre)
        {
            return DB.V_employee_overtime.FirstOrDefault(filtre);
        }

        public List<V_employee_overtime> Read()
        {
            return DB.V_employee_overtime.ToList();
        }

        public void Update(c_employee_overtime t)
        {
            throw new NotImplementedException();
        }
    }
}
