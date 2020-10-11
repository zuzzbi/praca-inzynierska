using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EduMath
{
    class ClassDeserialization
    {
        public static string Deserialize(string path)
        {
            if (File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path);
                string output = streamReader.ReadToEnd();
                streamReader.Close();
                return output;
            }
            else
            {
                return "Błąd wczytywania";
            }
        }
    }
}
