using System;
using System.Reflection;
namespace Documentation
{
    public class DocumentationAttribute
    {
        [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
        public class DocumentAttribute : Attribute
        {
            public string Description { get; }
            public string Input { get; }
            public string Output { get; }

            
            public DocumentAttribute(string description, string input = "" , string output = "")
            {
                Description = description;
                Input = input;
                Output = output;
            }
        }
    }
}

