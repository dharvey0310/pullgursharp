using System.Collections.Generic;

namespace pullgursharp
{
    public class Images
    {
        public List<Image> Data { get; set;}
    }

    public class Image
    {
        public string Title { get; set; }
        public string Link { get; set; }
    }
}
