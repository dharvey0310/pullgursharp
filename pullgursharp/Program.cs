using System;

namespace pullgursharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string gallery = "";
            string path = "";
            string pageNumber = "1";
            string help = "";
            for (int i = 0; i < args.Length; i++)
            {
                gallery = args[i].IndexOf("--gallery") != -1 ? args[i + 1] : gallery;
                path = args[i].IndexOf("--output") != -1 ? args[i + 1] : path;
                pageNumber = args[i].IndexOf("--pageNumber") != -1 ? args[i + 1] : pageNumber;
                help = args[i].IndexOf("--help") != -1 ? "true" : help;
            }
            if (gallery.Length > 0)
            {
                FetchImageURLs Fetch = new FetchImageURLs();
                SaveImages Save = new SaveImages();
                Save.CheckPathExists(path);
                Images response = Fetch.FetchImages(gallery, pageNumber);
                for (int i = 0; i < response.Data.Count; i++)
                {
                    string[] nameArr = response.Data[i].Link.Split('/');
                    if (nameArr.Length < 5)
                    {
                        Save.SaveFile(response.Data[i].Link, path + nameArr[3]);
                    }
                }
                Console.WriteLine("Images saved to " + path);
            } else if (help.Length > 0)
            {
                Help display = new Help();
                display.HelpInfo();
            } else
            {
                Console.WriteLine("Please specify a gallery to pull images from.");
            }
        }
    }
}
