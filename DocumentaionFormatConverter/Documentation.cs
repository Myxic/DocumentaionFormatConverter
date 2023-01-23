using System.Reflection;
using System.Text;
using static Documentation.DocumentationAttribute;

namespace Documentation;

public class DocumentationModel
{
    public static StringBuilder GetDocString = new();
    public static void GetDocs()
    {
        var assembly = Assembly.GetExecutingAssembly();
        GetDocString.AppendLine("| Code Documentation |\n\n");
        
        var types = assembly.GetTypes();



        foreach (Type type in types)
        {
            var attributes = type.GetCustomAttributes(typeof(DocumentAttribute), true);

            if (attributes.Length > 0)
            {
                if (type.IsClass)
                {
                    GetDocString.AppendLine($"Class: {type.Name}");
                    GetDocString.AppendLine("\tDescription: \n\n" + ((DocumentAttribute)attributes[0]).Description);
                   


                    foreach (ConstructorInfo constructor in type.GetConstructors())
                    {
                        var constructorAttributes = constructor.GetCustomAttributes(typeof(DocumentAttribute), true);
                        if (constructorAttributes.Length > 0)
                        {
                            GetDocString.AppendLine("Constructor: " + constructor.Name);
                            GetDocString.AppendLine("\tDescription: " + ((DocumentAttribute)constructorAttributes[0]).Description);
                            GetDocString.AppendLine("\tInput: \n\n" + ((DocumentAttribute)constructorAttributes[0]).Input);
                            
                        }
                    }

                    foreach (MethodInfo method in type.GetMethods())
                    {
                        var methodAttributes = method.GetCustomAttributes(typeof(DocumentAttribute), true);
                        if (methodAttributes.Length > 0)
                        {
                            GetDocString.AppendLine("Method: " + method.Name);
                            GetDocString.AppendLine("\tDescription: " + ((DocumentAttribute)methodAttributes[0]).Description);
                            GetDocString.AppendLine("\tInput: " + ((DocumentAttribute)methodAttributes[0]).Input);
                            GetDocString.AppendLine("\tOutput: \n\n" + ((DocumentAttribute)methodAttributes[0]).Output);
                           
                        }
                    }

                    foreach (PropertyInfo property in type.GetProperties())
                    {
                        var propertyAttributes = property.GetCustomAttributes(typeof(DocumentAttribute), true);
                        if (propertyAttributes.Length > 0)
                        {
                            GetDocString.AppendLine("Property: " + property.Name);
                            GetDocString.AppendLine("\tDescription: " + ((DocumentAttribute)propertyAttributes[0]).Description);
                            GetDocString.AppendLine("\tOutput: \n\n" + ((DocumentAttribute)propertyAttributes[0]).Output);
                            
                        }
                    }

                }

                if (type.IsEnum)
                {
                    GetDocString.AppendLine("Enum: " + type.Name);
                    GetDocString.AppendLine("\tDescription: " + ((DocumentAttribute?)attributes.SingleOrDefault(a => a.GetType() == typeof(DocumentAttribute)))?.Description);

                    string[] names = type.GetEnumNames();
                    foreach (string name in names)
                    {
                        GetDocString.AppendLine(name);

                    }
                    GetDocString.AppendLine("  ");
                }

            }

        }
        GetDocString.Append("| End of Documentation |");
        

    }
    

}