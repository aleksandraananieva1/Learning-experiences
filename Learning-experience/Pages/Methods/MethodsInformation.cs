using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

namespace Learning_experience.Pages.Methods
{
    public class MethodsInformation
    {
        /*A METHOD is a block of code which only runs when it is called.

You can pass data, known as parameters, into a method.

Methods are used to perform certain actions, and they are also known as functions.

Why use methods? To reuse code: define the code once, and use it many times.
        Create a Method
A method is defined with the name of the method, followed by parentheses ().
        C# provides some pre-defined methods, which you already are familiar with, 
        such as Main(), but you can also create your own methods to perform certain 
        actions:

        class Program
{
  static void MyMethod() 
  {
    // code to be executed
  }
}
- MyMethod() is the name of the method
- Static means that the method belongs to the Program class and not an object of the Program class.
- Void means that this method does not have a return value.\

/// <summary>
/// Return value
/// </summary>

        If you want the method to return a value, you can use a primitive data type (such as int or double) instead of void,
        and use the return keyword inside the method:
        EXAMPLE
        static int MyMethod(int x) 
{
  return 5 + x;
}

static void Main(string[] args)
{
  Console.WriteLine(MyMethod(3));
}

// Outputs 8 (5 + 3)

/// <summary>
/// Call a Method
/// </summary>
        
To call (execute) a method, write the method's name followed by two parentheses () and  a semicolon;

In the following example, MyMethod() is used to print a text (the action), when it is called:
        EXAMPLE (Method can be called several times)
        static void MyMethod() 
{
  Console.WriteLine("I just got executed!");
}

static void Main(string[] args)
{
  MyMethod();
  MyMethod();
  MyMethod();

/// <summary>
/// Parameters and Arguments
/// </summary>
        
Information can be passed to methods as parameter. Parameters act as variables inside the method.

They are specified after the method name, inside the parentheses. You can add as many parameters as you want, 
        just separate them with a comma.

The following example has a method that takes a string called fname as parameter. When the method is called,
        we pass along a first name, which is used inside the method to print the full name:
        static void MyMethod(string fname) 
{
  Console.WriteLine(fname + " Refsnes");
}

static void Main(string[] args)
{
  MyMethod("Liam");
  MyMethod("Jenny");
  MyMethod("Anja");
}

// Liam Refsnes
// Jenny Refsnes
// Anja Refsnes
}

// I just got executed!
// I just got executed!
// I just got executed!
        
/// <summary>
/// Default Parameter Value
/// </summary>
        
        You can also use a default parameter value, by using the equals sign(=).

If we call the method without an argument, it uses the default value("Norway") :
        EXAMPLE

        static void MyMethod(string country = "Norway") 
{
  Console.WriteLine(country);
}

static void Main(string[] args)
{
  MyMethod("Sweden");
  MyMethod("India");
  MyMethod();
  MyMethod("USA");
}

// Sweden
// India
// Norway
// USA
        */
    }
}
// Polymorphism in Java is the ability of an object to take many forms.We can perform
// Polymorphism in two ways: 
/// <summary>
/// Method Overloading
/// </summary>
/* 1.Method overloading is the process that can create multiple methods of the same 
 name in the same class, and all the methods work in different ways. Method 
 overloading occurs when there is more than one method of the same name in the class.
	Example:

// C# program to demonstrate the function
// overloading by changing the Number
// of parameters
using System;
class GFG {
 
    // adding two integer values.
    public int Add(int a, int b)
    {
        int sum = a + b;
        return sum;
    }
 
    // adding three integer values.
    public int Add(int a, int b, int c)
    {
        int sum = a + b + c;
        return sum;
    }
 
    // Main Method
    public static void Main(String[] args)
    {
 
        // Creating Object
        GFG ob = new GFG();
 
        int sum1 = ob.Add(1, 2);
        Console.WriteLine("sum of the two "
                          + "integer value : " + sum1);
 
        int sum2 = ob.Add(1, 2, 3);
        Console.WriteLine("sum of the three "
                          + "integer value : " + sum2);
    }
}*/

/// <summary>
/// Method Overriding
/// </summary>
/* 2.Method overriding is the process when the subclass or a child class has the same method as declared in the parent class.
	Example:

using System;
namespace MethodOverriding
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
        public virtual double CalculateBonus(double Salary)
        {
            return 50000;
        }
    }
    public class Developer : Employee
    {
        //50000 or 20% Bonus to Developers which is greater
        public override double CalculateBonus(double Salary)
        {
            double baseSalry = base.CalculateBonus(Salary);
            double calculatedSalary = Salary * .20;
            if (baseSalry >= calculatedSalary)
            {
                return baseSalry;
            }
                
            else
            {
                return calculatedSalary;
            }
        }
    }
    public class Manager : Employee
    {
        //50000 or 25% Bonus to Developers which is greater
        public override double CalculateBonus(double Salary)
        {
            double baseSalry = base.CalculateBonus(Salary);
            double calculatedSalary = Salary * .25;
            if (baseSalry >= calculatedSalary)
            {
                return baseSalry;
            }
            else
            {
                return calculatedSalary;
            }
        }
    }
    public class Admin : Employee
    {
        //return fixed bonus 50000
        //no need to overide the method
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Developer
            {
                Id = 1001,
                Name = "Ramesh",
                Salary = 500000,
                Designation = "Developer"
            };
            double bonus = emp1.CalculateBonus(emp1.Salary);
            Console.WriteLine($"Name: {emp1.Name}, Designation: {emp1.Designation}, Salary: {emp1.Salary}, Bonus:{bonus}");
            Console.WriteLine();
            Employee emp2 = new Manager
            {
                Id = 1002,
                Name = "Sachin",
                Salary = 800000,
                Designation = "Manager"
            };
            bonus = emp2.CalculateBonus(emp2.Salary);
            Console.WriteLine($"Name: {emp2.Name}, Designation: {emp2.Designation}, Salary: {emp2.Salary}, Bonus:{bonus}");
            Console.WriteLine();
            Employee emp3 = new Admin
            {
                Id = 1003,
                Name = "Rajib",
                Salary = 300000,
                Designation = "Admin"
            };
            bonus = emp3.CalculateBonus(emp3.Salary);
            Console.WriteLine($"Name: {emp3.Name}, Designation: {emp3.Designation}, Salary: {emp3.Salary}, Bonus:{bonus}");
            Console.WriteLine();
            Employee emp4 = new Developer
            {
                Id = 1004,
                Name = "Priyanka",
                Salary = 200000,
                Designation = "Developer"
            };
            bonus = emp1.CalculateBonus(emp4.Salary);
            Console.WriteLine($"Name: {emp4.Name}, Designation: {emp4.Designation}, Salary: {emp4.Salary}, Bonus:{bonus}");
            
            Console.Read();
        }
    }
}*/