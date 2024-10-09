namespace Week1_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class is a blueprint; it cannot excist in memory. it doesnt allow assigments
            //out of classwe can create object, which will allow us to assign values
            Console.WriteLine("Hello, World!");
            Person person = new Person(); //creating an Object
            person.Name = "Test";
            person.Surname = "tseT";
        }
    }
}
