using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIApplication
{
    public static class RestApiHelper
    {
        public static RestClient client;
        public static RestRequest restRequest;
        public static string baseUrl = "http://mydomain.com";

            public static RestClient SetUrl(string endpoint)
        {
            var url = baseUrl + endpoint;
            return client = new RestClient(url);
        }

        public static RestRequest CreateRequest()
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public static IRestResponse GetResponse()
        {
            return client.Execute(restRequest);

        }
    }
    
}
