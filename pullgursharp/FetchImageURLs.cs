using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace pullgursharp
{
    class FetchImageURLs
    {
        public Images FetchImages(string gallery)
        {
            var client = new RestClient($"https://api.imgur.com/3/gallery/{gallery}");
            var request = new RestRequest(Method.GET);
            request.AddHeader("authorization", "Client-ID b68d6fbd258b5ac");
            request.AddHeader("content-type", "application/json");
            var response = client.Execute<Images>(request);
            return response.Data;
        }
    }
}
