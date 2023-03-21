namespace Learning_experience.Pages.OOP.Polymorphism
{
    /*Polymorphism – a concept by which we can perform a single action in different ways. We can perform
      polymorphism in java by method overloading and method overriding. There are two types of polymorphism
      in Java: compile-time polymorphism and runtime polymorphism. */
    /*The word polymorphism means that it has many forms. Basically, we can define polymorphism as the ability
     * to represent a message in more than one way. A real example of polymorphism, a person can have several
     * properties at the same time. As a man, he is at the same time a father, husband, employee. So the same
     * person behaves differently in different situations. This is called polymorphism. one of the most 
     * important topics in the object-oriented programming language is polymorphism.
     /*C# provides an option to override the base class method, by adding the virtual keyword to the method 
    inside the base class, and by using the override keyword for each derived class methods:*/

    /*Types of Polymorphism
Compile-time Polymorphism
Runtime Polymorphism*/
    public class Polymorphism
    {
        class Animal  // Base class (parent) 
        {
            public virtual void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Pig : Animal  // Derived class (child) 
        {
            public override void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Dog : Animal  // Derived class (child) 
        {
            public override void animalSound()
            {
                Console.WriteLine("The dog says: bow wow");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Animal myAnimal = new Animal();  // Create a Animal object
                Animal myPig = new Pig();  // Create a Pig object
                Animal myDog = new Dog();  // Create a Dog object

                myAnimal.animalSound();
                myPig.animalSound();
                myDog.animalSound();
            }
        }
    }
}
