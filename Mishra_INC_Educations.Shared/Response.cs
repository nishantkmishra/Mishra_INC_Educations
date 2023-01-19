using System;
using System.Collections.Generic;
using System.Text;

namespace Mishra_INC_Educations.Shared
{
    public class Response<T>
    {
        public bool Status { get; set; }
        public string SuccessMessage { get; set; }
        public string ErrorMessage { get; set; }
        public T Data { get; set; }
    }
}
