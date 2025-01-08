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
            int i = 5;
            double d = 5.5;
            float f = 5.5F;
            decimal m = 5.5M;
            long l = 43543324L;


            var x = "5.5";

            Console.WriteLine(@"Hello\nWorld");


            int cars = 5, trucks = 4, bikes = 8;

            // string concatenation
            Console.WriteLine("I have " + cars + " cars, " + trucks + " trucks and " + bikes + " bikes");

            // string interpolation
            Console.WriteLine($"I have {cars} cars, {trucks} trucks and {bikes} bikes");
        }
    }
}
