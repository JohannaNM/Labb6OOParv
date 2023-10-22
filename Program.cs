namespace Labb6OOParv
{
    internal class Program    // Johanna Marklund .NET23
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Nahla", 9, "Brindle", "Female", true, "Black and Brown");
            dog.makeSound();// overrided from baseclass animal
            dog.eat(); // overrided from baseclass animal
            dog.sleep(); //overrided from baseclass animal
            dog.WalkOnLeash(); // uniqe method for the dog class.
            

            Tiger tiger = new Tiger("Mofasa", 3, "Black and orange", "male", false, "India");
            tiger.makeSound();
            tiger.eat();
            tiger.sleep();
            tiger.Hunt(); // uniqe method for the tiger class. 


            Elephant elephant = new Elephant("Dumbo", 1, "Gray", "male", false, 500);
            elephant.makeSound();
            elephant.eat();
            elephant.sleep();
            elephant.cool(); // uniqe method for the elephant class


            Retriver retriver = new Retriver("Lady", 5, "brown", "female", true, "pink", "Tennis ball");
            retriver.makeSound();
            retriver.eat(); 

            retriver.GoFetch(); // uniqe method for the retriver class. 
            retriver.WalkOnLeash(); // inherited from dog class.
            

            Terrier terrier = new Terrier("Akira", 7, "brindle", "female", true, "Red", "to be left home alone");
            terrier.makeSound();
            terrier.eat();
            terrier.dig(); // uniqe method for the terrier class.
            terrier.WalkOnLeash();
           
        }
    }
}