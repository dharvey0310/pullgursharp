using System;
using RestSharp;

namespace pullgursharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var gallery = "";
            var path = "";
            for (var i = 0; i < args.Length; i++)
            {
                gallery = args[i].IndexOf("--gallery") != -1 ? args[i + 1] : gallery;
                path = args[i].IndexOf("--output") != -1 ? args[i + 1] : path;
            }
            Console.WriteLine(gallery);
            Console.WriteLine(path);
            var Fetch = new FetchImageURLs();
            var response = Fetch.FetchImages(gallery);
            for (var i = 0; i < response.Data.Count; i++)
            {
                Console.WriteLine(response.Data[i].Link);
            }
        }
    }
}
