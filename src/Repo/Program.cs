using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http; //for HttpClient
using static System.Console; //Allows me to directly call static methods on the Console class, without the classname qualifier.

namespace Repo
{
    class Program
    {
        const string API_BASE = "https://gitignore.io/api/";
        const string API_LINE = API_BASE + "list?format=lines";

        static void Main(string[] args)
        {
            // Use the HttpClient to grab content form a website
            var client = new HttpClient();
            var templatename = client.GetAsync(API_LINE, HttpCompletionOption.ResponseContentRead).GetAwaiter().GetResult();

            WriteLine(templatename);
            ReadKey();
        }
    }
}
