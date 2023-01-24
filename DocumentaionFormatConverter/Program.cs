using Documentation;
using static Documentation.DocumentationModel;

namespace DocumentationAttribute;


class Program
{
    static void Main(string[] args)
    {
        GetDocs();
        Menu();
    }
    public static void Menu()
    {
        Console.WriteLine("*******************************************************\n\nWhat Operation do you want to perform \nEnter:\n1. For \"TXT\"\n2. For \"JSON\"");
        string input = Console.ReadLine();
        switch (input.ToLower())
        {
            case "1":
                Console.Clear();
                FileTXT.WriteToTXT();
                break;
            case "2":
                FileTXT.WriteToJSON();
                break;
            default:
                Console.Clear();
                Console.WriteLine($"\"{input}\" is invalid ");
                Menu();
                break;
        }
    }
    public class FileInfoTypeOperations
    {
        public static void CreateAFile()
        {

            //Change to a folder on your machine that you have read/write access to, or run as administrator
            var fileName = $@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}React{Path.DirectorySeparatorChar}Test.txt";


            // Make a new file on the C drive.
            FileInfo f = new(fileName);

            FileStream fs = f.Create();
            // Use the FileStream object...
            // Close down file stream.
            fs.Close();
        }
    }
}

