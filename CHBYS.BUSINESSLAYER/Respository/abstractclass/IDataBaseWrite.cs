using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.BUSINESSLAYER.Respository.abstractclass
{
    public interface IDataBaseWrite<T> where T:class
    {
        void Create(T t);
        void Update(T t);
        void Delete(int id);
    }
}
