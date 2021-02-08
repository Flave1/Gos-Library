using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GOSLibraries.URI
{
    public interface IUriService
    {
        Uri ReturnCompanyBaseDomain(string clientPath);

    }
    public class UriService : IUriService
    {
        private readonly string _baseUri;
        public UriService(string baseUri)
        {
            _baseUri = baseUri;
        }

        public string Live { get; set; }
        public string Localhost { get; set; }

        public Uri ReturnCompanyBaseDomain(string clientPath)
        {
            return new Uri(_baseUri + clientPath);
        }
    }

    public interface IBaseURIs
    {
        string LiveGateway { get; set; }
        string LocalGateway { get; set; } 
        string MainClient { get; set; }
        string SelfClient { get; set; }
        string FlutterWave { get; set; }
        string PayStack { get; set; }
        string Other { get; set; }
    }
    public class BaseURIs : IBaseURIs
    {
        public string LiveGateway { get ; set ; }
        public string LocalGateway { get ; set ; }
        public string MainClient { get ; set ; }
        public string SelfClient { get ; set ; }
        public string FlutterWave { get ; set ; }
        public string PayStack { get ; set ; }
        public string Other { get ; set ; }
    }

}
