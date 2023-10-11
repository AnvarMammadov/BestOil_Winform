using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil_Winform
{
    public static  class FileManage
    {
        private const string ErrorLogFileName = "error.log";

        /// <summary>
        /// Logs an error message, including the error date, message, and stack trace, to an error log file.
        /// </summary>
        /// <param name="ex">The exception to be logged</param>
        public static void LogError(Exception ex)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(ErrorLogFileName, true))
                {
                    writer.WriteLine($"[Error Date: {DateTime.Now}]");
                    writer.WriteLine($"Message: {ex.Message}");
                    writer.WriteLine($"StackTrace: {ex.StackTrace}");
                    writer.WriteLine();
                }
            }
            catch (Exception logEx)
            {
                Console.WriteLine($"Incurred an error while writing to the error log : {logEx.Message}");
            }
        }


        
    }
}
