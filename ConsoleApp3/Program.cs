using System;

namespace First_HW
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number ending with 5: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int NewNumber = 0;
            if (number % 10 == 5)
            {
                NewNumber = ((number / 10) * ((number / 10) + 1) * 100 + 25);
            }
            else
            {
                Console.WriteLine("The number does not end with 5");
            }
            Console.WriteLine($"Result: {NewNumber}");
        }
    }
}