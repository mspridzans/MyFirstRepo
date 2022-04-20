namespace ConsoleApp7
{
    public class Person
    {
        public string Name { get; set; }
        public string Age { get; set; }

        public bool IsMale { get; set; }


        public void Greeting ()
        {
            Console.WriteLine($"Hello my name is {Name}");

        }

        public void Call (string phoneNumber) 
        {
        Console.WriteLine($"{Name} is calling to { phoneNumber}");
        }


    }
}
