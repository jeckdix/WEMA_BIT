

using AreaOfTriangle;
using ListItems;

namespace Name
{
    class Program
    {
        public static void Main()
        {

            Console.WriteLine("Enter 1 to calculate Area or 2 display transactions");
            double operation = double.Parse(Console.ReadLine());

            if (operation == 1)
            {
                //Display user details and transactions
                Area.calculatesArea();
            }
            else if (operation == 2)
            {

                // Area.calculatesArea();
                List.DisplayTransaction();
            };
        }
    }
}
