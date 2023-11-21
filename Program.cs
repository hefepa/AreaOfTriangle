// See https://aka.ms/new-console-template for more information
namespace AreaOfTriangle;
public class Triangle
{
    public static void Main(string[] args)
    {
        Calculations loop = new Calculations();
        loop.Repeat();
    }
}

public class Calculations
{
    public void Repeat()
    {
        const int divisor = 2;
        double result, triangleBase, triangleHeight;
        while (true) //repeats process till input is valid
        {
            //catches invalid input
            try
            {
                Console.Write("Enter the base of the triangle: ");
                triangleBase = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the height of the triangle: ");
                triangleHeight = Convert.ToDouble(Console.ReadLine());

                result = (triangleBase * triangleHeight) / divisor;
                Console.WriteLine("The area of the triangle is " + result);
                break;
            }
            catch
            {
                Console.WriteLine("\tInvalid input. Kindly ennter a number ");
                Console.WriteLine();

            }
        }
    }
}
