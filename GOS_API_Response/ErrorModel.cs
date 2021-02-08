using System;
using System.Collections.Generic;
using System.Text;
namespace GOSLibraries.GOS_API_Response
{
    public class ErrorModel
    {
        public string FieldName { get; set; }
        public APIResponseStatus Status { get; set; }
    }

    public class ErrorResponse
    {
        public List<ErrorModel> Errors { get; set; } = new List<ErrorModel>();

    }
}
