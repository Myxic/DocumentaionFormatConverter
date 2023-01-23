using System;
using System.Xml.Linq;
using System.IO;
using Documentation;
using static Documentation.DocumentationModel;
using static DocumentationAttribute.Program;

namespace DocumentationAttribute
{
    public class FileTXT
    {
        //private string doc;
        //public string Doc
        //{
        //    get
        //    {
        //        return doc;
        //    }
        //    set
        //    {
        //        if (value != "")
        //            doc = value;
        //    }
        //}

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
    }
}

