using static System.Console;

namespace MiUA_Console
{
    internal class Program
    {
        static void Main()
        {
            try 
            {
                Write("Enter name: ");
                int? x = null;
                string? name = ReadLine();
                WriteLine($"Hello, {name}!");
                Write("Enter age: ");
                int age = Convert.ToInt32(ReadLine() ?? "");
                WriteLine($"You are {age} years old.");
            }
            catch (Exception ex)
            {
                WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
