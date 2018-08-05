using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder.Food_Menu
{
    public class Menu
    {
        Dictionary<string, string> _part = new Dictionary<string, string>();

        public void Add(string prop)
        {
            _part.Add(prop, prop);
        }
        public override string ToString()
        {
            return String.Join(", ", _part.Values);
        }
    }
}
