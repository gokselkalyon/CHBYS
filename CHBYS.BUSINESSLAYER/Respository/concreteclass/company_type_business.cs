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
    public class company_type_business : IDataBaseWrite<c_company_type>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_company_type t)
        {
            DB.SP_company_type_INSERT(t.type_name);
        }

        public void Delete(int id)
        {
            DB.SP_company_type_DELETE(id);
        }

        public void Update(c_company_type t)
        {
            throw new NotImplementedException();
        }
    }
}
