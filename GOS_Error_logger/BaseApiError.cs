using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GOSLibraries.GOS_Error_logger
{
    public class BaseApiError
    {
        public int StatusCode { get; private set; }
        public string StatusDescription { get; private set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Friendly_Message { get; private set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Technical_Message { get; set; }

        public BaseApiError(int statusCode, string statusCodeDescripton)
        {
            StatusCode = statusCode;
            StatusDescription = statusCodeDescripton;
        }

        public BaseApiError(int statusCode, string statusCodeDescripton, string F_message) : this(statusCode, statusCodeDescripton)
        {
            Friendly_Message = F_message;
        }
        public BaseApiError(int statusCode, string statusCodeDescripton, string F_message, string T_message) : this(statusCode, statusCodeDescripton)
        {
            Friendly_Message = F_message;
            Technical_Message = T_message;
        }
    }

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

    public class eUnauthorizedError : BaseApiError, IActionResult
    {
        public eUnauthorizedError() : base(401, HttpStatusCode.Unauthorized.ToString()) { }
        public eUnauthorizedError(string message) : base(401, HttpStatusCode.Unauthorized.ToString(), message) { }

        public Task ExecuteResultAsync(ActionContext context)
        {
             context.HttpContext.Response.StatusCode = 1001;
             return Task.Run(() => context);
        }
    }

    public class InternalServerErrorObjectResult : ActionResult, IActionResult, IStatusCodeActionResult
    {
        public MiddlewareResponse response { get; set; }

        public int? StatusCode => throw new NotImplementedException();

        public InternalServerErrorObjectResult(MiddlewareResponse contentResult)
        {
            response = contentResult;
        }
    }

    public class HttpRequestExceptionError : BaseApiError
    {
        public HttpRequestExceptionError() : base(408, HttpStatusCode.RequestTimeout.ToString()) { }
        public HttpRequestExceptionError(string F_message) : base(408, HttpStatusCode.RequestTimeout.ToString(), F_message) { }
        public HttpRequestExceptionError(string F_message, string T_message) : base(408, HttpStatusCode.RequestTimeout.ToString(), F_message, T_message) { }
    }
}
