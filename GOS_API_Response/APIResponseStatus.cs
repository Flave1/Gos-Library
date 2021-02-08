using System;

namespace GOSLibraries.GOS_API_Response
{
    public class APIResponseStatus
    { 
        public Boolean IsSuccessful { get; set; } = false;
        public string CustomToken { get; set; }
        public string CustomSetting { get; set; }
        public APIResponseMessage Message { get; set; }
    }
} 
