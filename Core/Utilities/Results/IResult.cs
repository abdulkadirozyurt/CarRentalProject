using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IResult    // temel voidler için başlangıç. 
    {
        bool Success { get; }           // başarılı başarısız
        string Message { get; }         // verilen mesaj (araç sisteme eklendi mesajı gibi)
    }
}



// işlem sonucu ve mesaj olsun. uygulamayı kullanacak kişileri doğru yönlendirmek.