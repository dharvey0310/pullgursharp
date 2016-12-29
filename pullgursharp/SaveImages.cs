using System.IO;
using System.Net;

namespace pullgursharp
{
    class SaveImages
    {
        public void CheckPathExists(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public void SaveFile(string url, string path)
        {
            WebClient client = new WebClient();
            client.DownloadFile(url, path);
        }
    }
}
