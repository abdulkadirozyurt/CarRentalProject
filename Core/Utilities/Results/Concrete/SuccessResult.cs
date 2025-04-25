using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true,message)    // SuccessResult için base'ine yani Result'a true ve mesajı yolladık.
        {

        }

        public SuccessResult(): base(true)
        {

        }
    }
}
