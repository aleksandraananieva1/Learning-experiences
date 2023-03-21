namespace Learning_experience.Pages.OOP.Encapsulation
{
    /*Encapsulation – the process of binding data and functions into a single unit.A class is an example
        of encapsulation.*/
    public class Encapsulation
    {
        // private variables declared
        // these can only be accessed by
        // public methods of class
        private String studentName;
        private int studentAge;

        // using accessors to get and 
        // set the value of studentName
        public String Name
        {

            get
            {
                return studentName;
            }

            set
            {
                studentName = value;
            }

        }

        // using accessors to get and 
        // set the value of studentAge
        public int Age
        {

            get
            {
                return studentAge;
            }

            set
            {
                studentAge = value;
            }

        }


    }

    // Driver Class
    class GFG
    {

        // Main Method
        static public void Main()
        {

            // creating object
            DemoEncap obj = new DemoEncap();

            // calls set accessor of the property Name, 
            // and pass "Ankita" as value of the 
            // standard field 'value'
            obj.Name = "Aleksandra";

            // calls set accessor of the property Age, 
            // and pass "26" as value of the 
            // standard field 'value'
            obj.Age = 26;

            // Displaying values of the variables
            Console.WriteLine("Name: " + obj.Name);
            Console.WriteLine("Age: " + obj.Age);
        }
    }

    internal class DemoEncap
    {
        public string Name { get; internal set; }
        public int Age { get; internal set; }
    }
}

