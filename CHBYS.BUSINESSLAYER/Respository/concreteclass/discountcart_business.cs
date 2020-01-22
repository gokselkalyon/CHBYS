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
    public class discountcart_business : IDataBaseWrite<c_discountcart>, IDataBaseRead<V_discountcart>
    {
        CARIHESAPBILGIYONETIMSISTEMIEntities DB = new CARIHESAPBILGIYONETIMSISTEMIEntities();
        public void Create(c_discountcart t)
        {
            DB.SP_discountcart_INSERT(t.type_name,t.code,t.statu,t.figure,t.value,t.Formula);
        }

        public void Delete(int id)
        {
            DB.SP_discountcart_DELETE(id);
        }

        public V_discountcart FilterRead(Expression<Func<V_discountcart, bool>> filtre)
        {
            return DB.V_discountcart.FirstOrDefault(filtre);
        }

        public List<V_discountcart> Read()
        {
            return DB.V_discountcart.ToList();
        }

        public void Update(c_discountcart t)
        {
            throw new NotImplementedException();
        }
    }
}
