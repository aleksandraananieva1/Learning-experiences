namespace Learning_experience.Pages.OOP.Inheritance
{
    /*Multilevel Inheritance: 
When one class derived from another derived class then this type of inheritance used
In multiple inheritances, a class can have more than one superclass and inherit functions from all parent 
    classes. Note that C # does not support multiple inheritance classes. In C #, we can only get a 
    Multiinheritance through the interface*/
    public class MultilevelInheritance
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
        class derivedclass1 : derivedclass
        {
            public void show3()
            {
                Console.WriteLine("derived class1 function");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                derivedclass1 derivedclass1 = new derivedclass1();
                derivedclass1.show();
                derivedclass1.show3();
                derivedclass1.show2();
            }
        }
        /*Output
         base class function
         derived class1 function
         derived class function*/
    }
}
