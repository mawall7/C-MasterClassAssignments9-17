using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using UltimateCSharpMasterClass;

namespace StarWarsPlanetsStats
{
    public class PlanetsStatsReader
    {
        public IApiReader ApiReader { get;}
        private string _baseadress { get; }
        public string _requestUri { get; }
        public PlanetsStatsReader(IApiReader apiReader, string baseadress, string requestUri)
        {
            ApiReader = apiReader;
            _baseadress = baseadress;
            _requestUri = requestUri;

        }
        public async Task<string> ReadAll()
        {
            
            var data = await ApiReader.ReadAsync(_baseadress, _requestUri);
            return data;
        }
        public async Task<string> Read(int apiplanetindex)
        {
            var searchUri = _requestUri + "/" + apiplanetindex;
            var data = await ApiReader.ReadAsync(_baseadress,searchUri);
            return data;
        }

    }
}

           
        


