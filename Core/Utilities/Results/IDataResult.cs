using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    // hangi tipi döndüreceğini bana söyle (T)
    public interface IDataResult<T> : IResult   // IResult ekleyince mesajı ve işlem sonucunu da içermiş oluyor.
    {

        // senin işlem sonucun ve mesajın dışında bir de yukarda belirttiğim T türünde bir Data olacak.


        T Data { get; }
    }
}
