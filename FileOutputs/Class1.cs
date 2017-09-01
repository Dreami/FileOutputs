using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOutputs
{
    public class Class1
    {
        public static void output_print(String output_path, String output)
        {
            try
            {
                if (!File.Exists(output_path))
                {
                    using (var stream = File.Create(output_path)) ;
                    TextWriter tw = new StreamWriter(output_path, false);
                    tw.WriteLine(output);
                    tw.Close();
                }
                else if (File.Exists(output_path))
                {
                    using (var tw = new StreamWriter(output_path, true))
                    {
                        tw.WriteLine(output);
                        tw.Close();
                    }
                }
            }
            catch (DirectoryNotFoundException directoryExc)
            {
                Console.WriteLine(directoryExc.StackTrace);
            }
            catch (IOException ioExc)
            {
                Console.WriteLine(ioExc.StackTrace);
            }
            catch (UnauthorizedAccessException unauthorizedExc)
            {
                Console.WriteLine(unauthorizedExc.StackTrace);
            }
        }
    }
}
