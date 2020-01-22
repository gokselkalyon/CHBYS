using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CHBYS.BUSINESSLAYER.Respository.abstractclass
{
    public interface IDataBaseRead<T> where T:class
    {
         T FilterRead(Expression<Func<T, bool>> filtre);
         List<T> Read();
    }
}
