namespace Reverse
{
    internal class Program
    {
        static void Main()
        {
            string inputString1 = "The weather is so sunny nowadays";
            string inputString2 = "Life is so beautiful";

            string output1 = ReverseString(inputString1);
            string output2 = ReverseString(inputString2);

            Console.WriteLine(output1);
            Console.WriteLine(output2);
        }

        static string ReverseString(string sentence)
        {
            string[] words = sentence.Split(' '); // Split the sentence into words
            Array.Reverse(words); // Reverse the order of the words
            return string.Join(" ", words); // Join the reversed words into a string
        }
    }
}
