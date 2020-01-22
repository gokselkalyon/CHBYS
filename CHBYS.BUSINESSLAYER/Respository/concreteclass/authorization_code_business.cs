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
    public class authorization_code_business : IDataBaseWrite<c_authorization_code>,IDataBaseRead<V_authorization_code>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();

        public void Create(c_authorization_code t)
        {
            DB.SP_authorization_code_INSERT(t.YETKI_KODU, t.ACIKLAMA, t.YETKI_TIPI);
        }

        public void Delete(int id)
        {
            DB.SP_authorization_code_DELETE(id);
        }

        public V_authorization_code FilterRead(Expression<Func<V_authorization_code, bool>> filtre)
        {
            return DB.V_authorization_code.FirstOrDefault(filtre);
        }

        public List<V_authorization_code> Read()
        {
            return DB.V_authorization_code.ToList();
        }

        public void Update(c_authorization_code t)
        {
           
        }
    }
}
