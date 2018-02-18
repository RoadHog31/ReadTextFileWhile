using System;
using System.IO;

namespace ReadTextFileWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            ReadTextFiles();
        }


        private static void ReadTextfiles()
        {
            StreamReader sr = null;

            try
            {
                sr = File.OpenText("Values.txt");
                string line = string.Empty;

                while (line != null)
                {
                    line = sr.ReadToEnd();
                    if (line != null)
                        Console.WriteLine(line);

                    sr.Close();
                    Console.ReadLine();
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                    Console.ReadLine();
                }
            }
        }
    }
}
