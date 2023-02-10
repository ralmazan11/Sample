namespace Sample
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 2, 3, 4 };

            int prod = 1;

            foreach (int i in input)
            {
                prod *= i;
            }

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = prod / input[i];
            }

            foreach (int i in input) 
                Console.WriteLine(i);
        }
    }
}