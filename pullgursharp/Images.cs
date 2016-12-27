using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
