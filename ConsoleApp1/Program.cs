namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello =)");
            Console.WriteLine("Hello, World!");
            //string aFriend= "Nikita";
            string aFriend = "Nika";
            //Console.WriteLine(aFriend);
            Console.WriteLine("Hello" + " " + aFriend);
            Console.WriteLine($"Hello {aFriend}");
            string firstFriend = "Bob";
            string secondFriend = "Karl";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} leters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} leters.");

            string greeting = "        Hello world)         ";
            Console.WriteLine($"[{greeting}]");
            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");
        }
    }
}