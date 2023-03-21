using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Learning_experience.Pages.OOP.Inheritance
{
    /*Hierarchical Inheritance:
This is the type of inheritance in which there are multiple class derived from one base class
When multiple classes needed the functionality of one class this type of inheritance used*/
    public class HierarchicalInheritance
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
        class derivedclass1 : baseclass
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
                derivedclass derivedclass = new derivedclass();
                derivedclass.show();
                derivedclass.show2();
                derivedclass1 derivedclass1 = new derivedclass1();
                derivedclass1.show();
                derivedclass1.show3();
            }
        }
        /*Output
         base class function
         derived class function
         base class function
         derived class1 function*/
    }
}
