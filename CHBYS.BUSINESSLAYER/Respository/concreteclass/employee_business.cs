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
    public class employee_business : IDataBaseWrite<c_employee>, IDataBaseRead<V_employees>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_employee t)
        {
            DB.SP_employees_INSERT(t.employee_name,t.employee_lastname,t.employee_position,t.employee_TC,t.performans,t.salary);
        }

        public void Delete(int id)
        {
            DB.SP_employees_DELETE(id);
        }

        public V_employees FilterRead(Expression<Func<V_employees, bool>> filtre)
        {
            return DB.V_employees.FirstOrDefault(filtre);
        }

        public List<V_employees> Read()
        {
            return DB.V_employees.ToList();
        }

        public void Update(c_employee t)
        {
            throw new NotImplementedException();
        }
    }
}
