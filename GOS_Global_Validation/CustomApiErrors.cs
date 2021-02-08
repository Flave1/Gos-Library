using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace GOSLibraries.GOS_Global_Validation
{
    public class InternalServerErrors : BaseApiError
    {
        public InternalServerErrors() : base(500, HttpStatusCode.InternalServerError.ToString()) { }
        public InternalServerErrors(string T_message) : base(500, HttpStatusCode.InternalServerError.ToString(), T_message) { }
        public InternalServerErrors(string F_message, string T_message) : base(500, HttpStatusCode.InternalServerError.ToString(), F_message, T_message) { }
    }
    
  
    public class UnauthorizedError : BaseApiError
    {
        public UnauthorizedError() : base(401, HttpStatusCode.Unauthorized.ToString()) { }
        public UnauthorizedError(string message) : base(401, HttpStatusCode.Unauthorized.ToString(), message) { }
    }

    public class HttpRequestExceptionError : BaseApiError
    {
        public HttpRequestExceptionError() : base(408, HttpStatusCode.RequestTimeout.ToString()) { }
        public HttpRequestExceptionError(string F_message) : base(408, HttpStatusCode.RequestTimeout.ToString(), F_message) { }
        public HttpRequestExceptionError(string F_message, string T_message) : base(408, HttpStatusCode.RequestTimeout.ToString(), F_message, T_message) { }
    }
}
