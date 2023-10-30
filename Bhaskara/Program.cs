using System;

class URI
{

    static void Main(string[] args)
    {

        double A = Convert.ToDouble(Console.ReadLine());
        double B = Convert.ToDouble(Console.ReadLine());
        double C = Convert.ToDouble(Console.ReadLine());

        double X = (-B + ((B * B) - 4 * A * C)) / 2;
        double Y = (-B - ((B * B) - 4 * A * C)) / 2;

        if (((B * B) - 4 * A * C) < 0 || A == 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            Console.WriteLine("R1 = " + X);
            Console.WriteLine("R2 = " + Y);
        }
    }
}