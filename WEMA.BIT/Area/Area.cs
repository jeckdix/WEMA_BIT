
namespace AreaOfTriangle

{

    class Area
    {
        public static void calculatesArea()
        {

            Console.WriteLine("This program calculates the area of a triangle");

            Console.Write("Enter base of the triangle: ");
            double baseNum = double.Parse(Console.ReadLine());

            Console.Write("Enter height of the triangle: ");
            double heightNum = double.Parse(Console.ReadLine());


            double areaOfTriangle = ((baseNum * heightNum) / 2);

            Console.WriteLine("The area of the triangle is : " + areaOfTriangle);



        }

    }

}

