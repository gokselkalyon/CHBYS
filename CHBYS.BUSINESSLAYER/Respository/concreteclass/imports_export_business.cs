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
    public class imports_export_business : IDataBaseWrite<c_imports_export>, IDataBaseRead<V_imports_export>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_imports_export t)
        {
            DB.SP_imports_export_INSERT(t.type,t.code,t.document_no,t.currency,t.cargo_no,t.city,t.county,t.country,t.intermediary_bank,t.payment_method,t.suppliers,t.transport_type);
        }

        public void Delete(int id)
        {
            DB.SP_imports_export_DELETE(id);
        }

        public V_imports_export FilterRead(Expression<Func<V_imports_export, bool>> filtre)
        {
            return DB.V_imports_export.FirstOrDefault(filtre);
        }

        public List<V_imports_export> Read()
        {
            return DB.V_imports_export.ToList();
        }

        public void Update(c_imports_export t)
        {
            throw new NotImplementedException();
        }
    }
}
