using System;
using System.Collections.Generic;
using System.Text;

namespace GOSLibraries
{
    //public async Task<TResult> GetAsync<TResult>(string uriString) where TResult : class
    //{
    //    var uri = new Uri(uriString);
    //    using (var gosGatewayClient = _httpClientFactory.CreateClient("GOSDEFAULTGATEWAY"))
    //    {
    //        string authorization = _accessor.HttpContext.Request.Headers["Authorization"];
    //        gosGatewayClient.DefaultRequestHeaders.Add("Authorization", authorization);
    //        HttpResponseMessage response = await gosGatewayClient.GetAsync(uri);
    //        if (response.StatusCode != HttpStatusCode.OK)
    //        {
    //            return default(TResult);
    //        }
    //        var json = await response.Content.ReadAsStringAsync();
    //        return JsonConvert.DeserializeObject<TResult>(json, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
    //    }
    //}

    public static class StaticRoles
    {
        public const string GODP = "Godp Admin";
    }

    public static class GenericMiddlwareMessages
    {
        public const string NO_PRIVILEGE = "You don't have privilege to perform this action";
        public const string DUPLICATE_LOGIN = "Duplicate Login Detected";
    }

}
