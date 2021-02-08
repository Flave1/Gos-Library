using GOSLibraries.GOS_API_Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks; 

namespace GOSLibraries
{
    public interface IInternetService
    {
        Task<bool> NetworkServiceAsync();
    }
    public partial class InternetService : IInternetService
    {
       
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        public Task<bool> NetworkServiceAsync()
        {
            int Desc;
            return Task.Run(() => InternetGetConnectedState(out Desc, 0));
        }
    }

    public class MiddlewareResponse : ActionResult, IActionResult, IStatusCodeActionResult
    {
        public APIResponseStatus Status { get; set; }
        public int? StatusCode { get; set; }
    }
   
}
