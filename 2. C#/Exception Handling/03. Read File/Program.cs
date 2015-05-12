using System;
using System.IO;



class ReadFileContent
{
    static void ReadFile(string filePath)
    {
        try
        {
            string fileContent = File.ReadAllText(filePath);
            Console.WriteLine("Printing the content: ");
            Console.WriteLine(fileContent);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (PathTooLongException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void Main()
    {
        Console.Write("Enter full path to the file: ");
        string filePath = Console.ReadLine();
        ReadFile(filePath);
    }
}