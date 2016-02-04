using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepticV2
{
    class WriteToFile
    {
        public static void write(string toWrite) {
            using (System.IO.StreamWriter file =
           new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\WriteLines2.txt"))
            {
               file.WriteLine("Anything");
            }
      }
   }
}
