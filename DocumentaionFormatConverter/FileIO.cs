using System;
using static Documentation.DocumentationModel;
using static DocumentationAttribute.Program;
using System.Text.Json;

namespace DocumentationAttribute
{
    public class FileTXT
    {


        public static void WriteToTXT()
        {
            //string writeText = GetDocString;// Create a text string
            File.WriteAllText("Documentation.txt", GetDocString.ToString());  // Create a file and write the content of writeText to it

            Console.WriteLine("Enter 0 to Exit to Main Menu or Any key to Read to the Console");
            string input2 = Console.ReadLine();

            switch (input2.ToLower())
            {
                case "0":
                    Console.Clear();
                    Menu();
                    break;
                default:
                    Console.Clear();
                    ReadTXT();
                    break;
            }

        }
        public static void ReadTXT()
        {
            string readText = File.ReadAllText("Documentation.txt");  // Read the contents of the file
            Console.WriteLine(readText);
        }

       
        public static void SaveAsJsonFormat<T>(T objGraph, string fileName)
        {

            var options = new JsonSerializerOptions
            {

                IncludeFields = true,
                WriteIndented = true
            };
            File.WriteAllText(fileName, JsonSerializer.Serialize(objGraph, options));

        }
        public static void WriteToJSON()
        {
            SaveAsJsonFormat(GetDocString.GetHashCode(), "Documentation.json");
            //string json = JsonSerializer.Serialize(GetDocString.ToString());

            //File.WriteAllText("Documentation.json", json);
            Console.WriteLine("Enter 0 to Exit to Main Menu or Any key to Read to the Console");
            string input2 = Console.ReadLine();

            switch (input2.ToLower())
            {
                case "0":
                    Console.Clear();
                    Menu();
                    break;
                default:
                    Console.Clear();
                    ReadJson();
                    break;
            }
        }
        public static void ReadJson()
        {
            string readJson = File.ReadAllText("Documentation.json");  // Read the contents of the file
            Console.WriteLine(readJson);
        }

    }
}

