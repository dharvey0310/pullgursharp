using System;

namespace pullgursharp
{
    class Help
    {
        public void HelpInfo()
        {
            Console.WriteLine("");
            Console.WriteLine("Argument        | Description");
            Console.WriteLine("");
            Console.WriteLine("--gallery        | Sets the imgur gallery to pull images from e.g. r/funny");
            Console.WriteLine("");
            Console.WriteLine("--output         | Sets the directory to save the images to e.g. C:\\Pictures\\");
            Console.WriteLine("");
            Console.WriteLine("--pageNumber     | Sets the gallery page number to pull images from");
            Console.WriteLine("");
            Console.WriteLine("--help           | Displays this help menu");
        }
    }
}
