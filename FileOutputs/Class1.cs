using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOutputs
{
    public static class Outputs
    {
        private static string allfiles = @"C:\Users\maple\Documents\9° Semester\CS13309_Archivos_HTML\Files";
        private static string allOutputFiles = @"C:\Users\maple\Documents\9° Semester\CS13309_Archivos_HTML";

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

        public static String getAllFiles()
        {
            return allfiles;
        }

        public static String getOutputFiles()
        {
            return allOutputFiles;
        }
    }
}
