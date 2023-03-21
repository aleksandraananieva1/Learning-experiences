using Learning_experience.Pages.OOP.ClassInformation;
using Learning_experience.Pages.OOP.Inheritance;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;
using System.Reflection.Metadata;

namespace Learning_experience.Pages.OOP.Polymorphism
{
    /* Run Time Polymorphism or Method Overriding:
Method overriding or Run time polymorphism means changing the base class method behavior in child class. 
    We can change the base class method behavior in child class by applying virtual keyword for base class 
    method and override keyword for child class method
Create two classes Employee.cs(which is base class) and another one is Manager.cs(which is  Child Class)
    as shown below.
*/
    public class RunTimePolymorphism
    {
        class Employee

        {

            public virtual string CheckEmpRole(int empId)

            {

                return "Employee";

            }

        }

    }



    namespace PolymorphismExp

    {
        class Manager : Employee
        {
        }
    }


   /* As shown above, base class Employee.cs has CheckEmpRole() method prefixed with virtual keyword and child class Manager.cs inheriting the base class Employee. In Manager class we are overriding the child class method CheckEmpRole() method by using override keyword.This is called run time polymorphism or method overriding because we are changing the method behavior in child class at run time through inheritance.*/
    }

