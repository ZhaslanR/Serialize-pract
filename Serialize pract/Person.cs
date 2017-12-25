using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize_pract
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public string DateOfBith { get; set; }
        public string Number { get; set; }
    }
}
