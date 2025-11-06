using System.Diagnostics.Metrics;

public class ejercicio3
{
    static void Main()
    {
        const string Intro = "Introdueix el numero secret del nivell: ";
        const string Puertas = "S'han generat la seguent quantitat de portes: ";

        Random rnd = new Random();
        int num, door, divisor= 0, result, enter;

        Console.WriteLine(Intro);
        num = Convert.ToInt32(Console.ReadLine());
        door = rnd.Next(5, 16);
        Console.WriteLine(Puertas + door);
        num = divisor;

        while (divisor > 0)
        {
            result = num % divisor;
            if (result == 0)
            {
                enter = divisor;
                divisor--;
            }
            else
            {
                divisor--;
            }

        }
        Console.WriteLine("you can open X doors bla bla no me da tiempo a acabar el resto");
    }
}