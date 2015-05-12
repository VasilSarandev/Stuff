namespace ConcatenateTextFiles
{
    using System;
    using System.IO;
    using System.Text;
    class ConcatenateTextFiles
    {
        static void Main(string[] args)
        {
            string firstPath = @"..\..\..\txt\First.txt";
            string secondPath = @"..\..\..\txt\Second.txt";
            string concatenatedPath = @"..\..\..\txt\Result.txt";
            try
            {
                string firstString = File.ReadAllText(firstPath);
                string secondString = File.ReadAllText(secondPath);

                File.WriteAllText(concatenatedPath, firstString + secondString);

                Console.WriteLine(@"A {0} file named {1} has been created.",
                    Path.GetExtension(concatenatedPath), Path.GetFileNameWithoutExtension(concatenatedPath));
                Console.WriteLine(Environment.NewLine + "You can find it at " + Path.GetFullPath(concatenatedPath));
            }
            catch (DirectoryNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}