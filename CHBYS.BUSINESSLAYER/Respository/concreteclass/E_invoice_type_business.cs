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
    public class E_invoice_type_business : IDataBaseWrite<c_E_invoice_type>, IDataBaseRead<V_E_invoice_type>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_E_invoice_type t)
        {
            DB.SP_E_invoice_type_INSERT(t.E_invoice_type_name);
        }

        public void Delete(int id)
        {
            DB.SP_E_invoice_type_DELETE(id);
        }

        public V_E_invoice_type FilterRead(Expression<Func<V_E_invoice_type, bool>> filtre)
        {
            return DB.V_E_invoice_type.FirstOrDefault(filtre);
        }

        public List<V_E_invoice_type> Read()
        {
            return DB.V_E_invoice_type.ToList();
        }

        public void Update(c_E_invoice_type t)
        {
            throw new NotImplementedException();
        }
    }
}
