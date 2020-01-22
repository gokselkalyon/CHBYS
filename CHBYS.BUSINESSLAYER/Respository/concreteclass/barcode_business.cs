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
    public class barcode_business : IDataBaseWrite<c_barcode>, IDataBaseRead<V_barcode>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_barcode t)
        {
            DB.SP_barcode_INSERT(t.barcode1,t.fiyati,t.comment);
        }

        public void Delete(int id)
        {
            DB.SP_barcode_DELETE(id);
        }

        public V_barcode FilterRead(Expression<Func<V_barcode, bool>> filtre)
        {
           return DB.V_barcode.FirstOrDefault(filtre);
        }

        public List<V_barcode> Read()
        {
            return DB.V_barcode.ToList();
        }

        public void Update(c_barcode t)
        {
            throw new NotImplementedException();
        }
    }
}
