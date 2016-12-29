using RestSharp;

namespace pullgursharp
{
    class FetchImageURLs
    {
        public Images FetchImages(string gallery, string pageNumber)
        {
            RestClient client = new RestClient($"https://api.imgur.com/3/gallery/{gallery}/{pageNumber}");
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("authorization", "Client-ID b68d6fbd258b5ac");
            request.AddHeader("content-type", "application/json");
            IRestResponse<Images> response = client.Execute<Images>(request);
            return response.Data;
        }
    }
}
