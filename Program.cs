public class ejercicio2  {
    static void Main()
    {
        const string Menu = "Introdueix un número (0 per a sortir)";
        const string Divisio = " Els numeros divisors de ";
        int op, num, divisor, result, enter = 0;


        do
        {
            Console.WriteLine(Menu);
            op = Convert.ToInt32(Console.ReadLine());
            num = op;
            divisor = num;
            while (divisor > 0)
            {
                result = num % divisor;
                if (result == 0)
                {
                    enter = divisor;
                    divisor--;
                }else
                {
                    divisor--;
                }

            }
            Console.WriteLine(Divisio + num + " són: " + enter);
        } while (op != 0);
    }
}