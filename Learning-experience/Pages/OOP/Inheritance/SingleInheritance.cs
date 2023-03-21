namespace Learning_experience.Pages.OOP.Inheritance
{

   // Single Inheritance: 
//It is the type of inheritance in which one base class and one derived class
    public class SingleInheritance
    {
        class baseclass
        {
            public void show()
            {
                Console.WriteLine("base class function");
            }
        }
        class derivedclass : baseclass
        {
            public void show2()
            {
                Console.WriteLine("derived class function");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                derivedclass derivedclass = new derivedclass();
                derivedclass.show();
                derivedclass.show2();
            }
            //Output
            //base class function
            //derived class function
        }
    }
}
