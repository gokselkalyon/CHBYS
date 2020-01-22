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
    public class employee_permission_business : IDataBaseWrite<c_employee_permission>, IDataBaseRead<V_employee_permission>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_employee_permission t)
        {
            DB.SP_employee_permission_INSERT(t.permission_reason,t.permission_date);
        }

        public void Delete(int id)
        {
            DB.SP_employee_permission_DELETE(id);
        }

        public V_employee_permission FilterRead(Expression<Func<V_employee_permission, bool>> filtre)
        {
            return DB.V_employee_permission.FirstOrDefault(filtre);
        }

        public List<V_employee_permission> Read()
        {
            return DB.V_employee_permission.ToList();
        }

        public void Update(c_employee_permission t)
        {
            throw new NotImplementedException();
        }
    }
}
