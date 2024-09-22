using System;

class Program
{
    public static string PostMessage(string message)
    {
        if (message.Length <= 140)
        {
            return "Posted";
        }
        else
        {
            return "Rejected";
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter your message:");
        string userMessage = Console.ReadLine();

        string result = PostMessage(userMessage);
        Console.WriteLine(result);
    }
}