using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        // readonly (get) olanlar, constructor'da set edilebilir !!!!!!
        // this demek, class'ın kendisi demek (yani burada Result)
        public Result(bool success, string message) : this(success) // burada denilmek istenen şey, Result'ın tek parametreli constructor'una success'i yolla. Yani alttaki constructor'a bi bağlantı yolladık.
        {
         // Success = success;                  iptal ettik, çünkü aşağıda tekrar ettik kodumuzu (DRY prensibine aykırı)   12. satırı çalıştıran birisi aslında aynı zamanda 18. satırı da çalıştıracaktır, ondan dolayı mesajı yukarda bıraktık, success kısmını aşağı aldık, iki constructor da çalışmış olacak.
            Message = message;             //   yani bu constructor aslında alttakini de kapsıyor.
        }

        public Result(bool success)                  // mesaj vermeden sadece işlem sonucu başarılı-başarısız.
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
