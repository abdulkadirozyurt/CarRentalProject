using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {                                                    // (bu işlemin sonucu data'dır, işlem sonucu true'dur, mesaj da budur   demek)
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }

        public SuccessDataResult(T data) : base(data, true)                 // mesaj vermek istemiyor
        {

        }

        public SuccessDataResult(string message): base(default,true,message)   // datanın default halini döndürmek istiyoruz
        {

        }

        public SuccessDataResult(): base(default,true)                         // mesaj vermek istemiyoruz, işlemin sonucunda datam defaulttur, sonucu true'dur
        {

        }



    }
}

// farklı versiyonlar yazmış olduk

/*
    istersen data ve mesaj ver
    istersen sadece data ver
    istersen sadece mesaj ver
    istersen hiçbir şey verme


 */