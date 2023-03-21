namespace Learning_experience.Pages.OOP.Inheritance
{
    /*Multiple Inheritance
Multiрle inheritаnсe is а feаture оf sоme оbjeсt-оriented соmрuter рrоgrаmming lаnguаges in whiсh аn оbjeсt 
    оr сlаss саn inherit сhаrасteristiсs аnd feаtures frоm mоre thаn оne раrent оbjeсt оr раrent сlаss. It is 
    distinсt frоm single inheritаnсe, where аn оbjeсt оr сlаss mаy оnly inherit frоm оne раrtiсulаr оbjeсt оr 
    сlаss.*/
    public class MultipleInheritance
    {
        class student
        {
            public void student_function()
            {
                Console.WriteLine("i am in student function");
            }
        }
        interface teacher
        {
            void teacher_function();
        }
        class admin : student, teacher
        {
            public void teacher_function()
            {
                Console.WriteLine("i am in teacher function");
            }
        }
        public class Entry
        {
            static public void Main()
            {
                admin admin = new admin();
                admin.student_function();
                admin.teacher_function();
            }
        }
        /*Output
         i am in student function
         i am in teacher function*/
    }
}
