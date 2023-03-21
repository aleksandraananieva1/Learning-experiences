namespace Learning_experience.Pages.OOP.Polymorphism
{
    /*Compile-time Polymorphism
In Compile time Polymorphism, In this type, we achieved polymorphism through operator overloading or function
    overloading. Functions are overloaded when they have the same name but many functions with different
    parameters. Changing the number of arguments and/or the type of argument can overload the task*/
    public class CompileTypePolimorphism
    {
        class Employee

        {

            public string CheckEmpRole(int empId)

            {

                return "Employee";

            }



            public string CheckEmpRole(int empId, string role)

            {

                return "Employee Role: " + role;

            }

        }

    }

  /*  This is called compile time polymorphism because here
   *  we are changing the method behavior at compile time only.*/
    }

