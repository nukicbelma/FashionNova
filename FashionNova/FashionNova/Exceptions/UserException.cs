using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace FashionNova.WebAPI.Exceptions
{
    [Serializable]
    public class UserException : Exception
    {
        public HttpStatusCode StatusCode { get; set; }

        public UserException(string message, HttpStatusCode statusCode) : base(message)
        {
            this.StatusCode = statusCode;
        }

        protected UserException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public UserException(string message) : base(message)
        {
        }
    }
}
