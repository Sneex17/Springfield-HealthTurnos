using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades
{
    public class Class1
    {
    }

    public class Character
    {
        public int id { get; set; }
        public int age { get; set; }
        public string birthdate { get; set; }
        public string gender { get; set; }
        public string name { get; set; }
        public string occupation { get; set; }
        public string portrait_path { get; set; }
        public IList<string> phrases { get; set; }
        public string status { get; set; }

    }
}
