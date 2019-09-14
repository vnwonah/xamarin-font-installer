using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XFI.Models;

namespace XFI.Services
{
    public class FontSearchService
    {
       public async Task<List<Font>> FetchFontListAsync(string prefix)
        {
            if (string.IsNullOrEmpty(prefix))
                return null;
            var fonts =  new List<Font>
            {
                new Font
                {
                    Name = "Vincent Nwonah"
                },
                new Font
                {
                    Name = "Richard Nwonah"
                },
                new Font
                {
                    Name = "Visual Studio"
                }
            };

            await Task.Delay(1);
            return fonts.Where(f => f.Name.ToLower().StartsWith(prefix.ToLower())).ToList();
        }
    }
}
