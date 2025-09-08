using static System.Net.Mime.MediaTypeNames;

namespace Leetcode_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int[] result = Solution.GetNoZeroIntegers(n);
            Console.WriteLine("[" + result[0] + "," + result[1] + "]");
            Console.ReadLine();
        }
        
    }
}
