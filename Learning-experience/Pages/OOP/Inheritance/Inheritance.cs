using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace Learning_experience.Pages.OOP.Inheritance
{
/*Inheritance – the mechanism in which one class acquires all the features of another class.
        We can achieve inheritance by using the “extends” keyword.It facilitates the reusability of the code.*/
    public class Inheritance
    {
        class CSharp
        {
            public string name;

            // public method of base class  
            public void SubjectName(string name)
            {
                this.name = name;
                Console.WriteLine("Currently i am working with: " + name);
            }
        }
        class Tech : CSharp
        {
            public Tech()
            {
                Console.WriteLine("techieclues");
            }
        }
        class NewClass
        {
            static void Main(string[] args)
            {
                Tech T = new Tech();
                T.SubjectName("CSharp");
            }
        }
      /*  Types of Inheritance
Single Inheritance
Multilevel Inheritance
Hierarchical Inheritance
Multiple Inheritance*/
    }
}

