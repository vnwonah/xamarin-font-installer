using System.Collections.Generic;

namespace XFI.Models
{
    public class Font
    {
        public string Name { get; set; }
        public string Url { get; set; }

        static public List<string> GetData()
        {
            List<string> data = new List<string>();

            data.Add("Afzaal");
            data.Add("Ahmad");
            data.Add("Zeeshan");
            data.Add("Daniyal");
            data.Add("Rizwan");
            data.Add("John");
            data.Add("Doe");
            data.Add("Johanna Doe");
            data.Add("Pakistan");
            data.Add("Microsoft");
            data.Add("Programming");
            data.Add("Visual Studio");
            data.Add("Sofiya");
            data.Add("Rihanna");
            data.Add("Eminem");

            return data;
        }
    }
}
