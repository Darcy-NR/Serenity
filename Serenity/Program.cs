using Serenity;
class Program
{
    static void Main(string[] args)
    {

        User testUser = new User("1234", "password", "email@email.com");

        Console.WriteLine("User Receipt: ");
        Console.WriteLine(testUser.getReceiptID());
        Console.WriteLine("User Password: ");
        Console.WriteLine(testUser.getPassword());
        Console.WriteLine("User Email: ");
        Console.WriteLine(testUser.getEmail());


        Console.ReadKey();
    }
}
