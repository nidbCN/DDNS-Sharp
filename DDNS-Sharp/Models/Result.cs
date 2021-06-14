using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDNS_Sharp.Models
{
    public class Result
    {
        public Result(bool isSuccess, int httpStatusCode, string message)
        {
            IsSuccess = isSuccess;
            HttpStatusCode = httpStatusCode;
            Message = message;
        }

        public bool IsSuccess { get; }
        public int HttpStatusCode { get; }
        public string Message { get; }


    }
}
