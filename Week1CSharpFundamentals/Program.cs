namespace Week1CSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int @float = 5;
            int[] array = { 3, 4, 5 };

            // contextual keywords
            var results = from n in array
                          where n == 3
                          select n;

            // literal values

        }
    }
}
