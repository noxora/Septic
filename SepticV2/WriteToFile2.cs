using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepticV2
{
    class WriteToFile2
    {
        public static void write(string toWrite, string pathtofile)
        {
            var filepath = Environment.ExpandEnvironmentVariables(pathtofile);
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(filepath))
            {
                file.WriteLine(toWrite);
            }
        }
    }
}
