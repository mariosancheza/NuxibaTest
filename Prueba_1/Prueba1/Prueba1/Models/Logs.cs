using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1.Models
{
    public class Logs
    {
        public static String PathAndName()
        {
            String pathAndName;
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            pathAndName = builder.Build().GetSection("DefaultPath").GetSection("pathAndName").Value;
            return pathAndName;
        }//end PathAndName
        public static void WriteLog(String logString)
        {
            try
            {
                String fic = PathAndName();
                StreamWriter fileP = new StreamWriter(fic, true, Encoding.UTF8);
                fileP.Write(logString + "\r\n");
                fileP.Close();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }//end getPath
    }
}
