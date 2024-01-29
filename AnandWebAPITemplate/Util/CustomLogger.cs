using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Littera.Data.Util
{
    public class CustomLogger
    {

        public void CustomeLog(string message)
        {
            // append to the existing stream
            StreamWriter sw = new StreamWriter(System.IO.Directory.GetCurrentDirectory() + "\\Log\\chanegnyname.txt", true);
                
            sw.WriteLine(message);
            sw.WriteLine("-----------------------------------------------------------------");

            // Close the handle
            sw.Flush();
            sw.Close();
        }
       
    }
}
