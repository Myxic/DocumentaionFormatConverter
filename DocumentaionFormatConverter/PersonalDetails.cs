using System;
using static Documentation.DocumentationAttribute;

namespace DocumentationAttribute
{
   
    [Document("A little detail about me")]
public class PersonalDetails
{
        public IPersonal myself;

        [Document("This tells you about Ben", "IPersonal")]

    public PersonalDetails(IPersonal myself)
        {
            this.myself = myself;
        }

        [Document("DisplayAge")]
        public void DisplayAge()
        {
            Console.WriteLine(myself.Age);
        }

        [Document("DisplayGender")]
        public void DisplayGender()
        {
            Console.WriteLine(myself.Gender);
        }

        [Document("This checks if Ben is a good guy")]
        public bool GoodGuy
        {
            get
            {
                return true;
            }
            set
            {

            }
        }

        [Document("This indicates how responsible Ben is")]
        public enum Responsible
        {
            Low = 1,
            Medium = 2,
            High = 3
        }

    }

    public interface  IPersonal
    {
        public int Age { get; }

        public string Gender { get; }
    }

    [Document("This is a Bezao database of Ben")]
    public class Bezao : IPersonal
    {
        [Document("Shows how old Ben is ", "", "int")]
        public int Age
        {
            get
            {
                return 23;
            }
        }

        [Document("Shows Ben's Gender", "", "string")]
        public string Gender{
            get
            {
                return "Male";
            }
        }
    }
}

