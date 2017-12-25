using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Serialize_pract
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            using (FileStream stream = new FileStream(@"C:\name_of_folder\test.csv", FileMode.Open))
            {
                SoapFormatter formatter = new SoapFormatter();
                formatter.Serialize(stream, person);
            }
            using (FileStream stream = new FileStream(@"C:\name_of_folder\test.json", FileMode.OpenOrCreate))
            {
                //JsonSerializer serializer = new JsonSerializer();
                //serializer.Serialize(stream, person);
                var jsonserilizer = JsonConvert.SerializeObject(person);
            }
        }
    }
}
