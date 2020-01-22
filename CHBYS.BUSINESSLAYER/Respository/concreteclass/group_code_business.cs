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
    public class group_code_business : IDataBaseWrite<c_group_code>, IDataBaseRead<V_group_code>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_group_code t)
        {
            DB.SP_group_code_INSERT(t.code,t.explanation,t.group_type);
        }

        public void Delete(int id)
        {
            DB.SP_group_code_DELETE(id);
        }

        public V_group_code FilterRead(Expression<Func<V_group_code, bool>> filtre)
        {
            return DB.V_group_code.FirstOrDefault(filtre);
        }

        public List<V_group_code> Read()
        {
            return DB.V_group_code.ToList();
        }

        public void Update(c_group_code t)
        {
            throw new NotImplementedException();
        }
    }
}
