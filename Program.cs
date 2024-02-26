namespace TheGreaterNumberSalvador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("The first number is greater than the second number.");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("the second number is greater than the first number."); ;
            }
            else
            {
                Console.WriteLine("Both number are equal.");
            }
        }
    }
}
