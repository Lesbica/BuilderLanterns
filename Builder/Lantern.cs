using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Lantern
    {
        private List<string> _parts = new List<string>();

        public void AddPart(string part)
        {
            _parts.Add(part);
        }

        public string GetConfiguration()
        {
            return "Lantern configuration: " + string.Join(", ", _parts) + "\n";
        }
    }
}
