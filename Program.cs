

public class exercici2
{
    static void Main()

    {
        const string Lost = "You've lost";
        const string Winner = "You've won";
        const string Traps = "trap found";
        const string Coin = "You found a coin";
        const string TotalCoin = "You got: ";

        int coins = 0, lives = 3, trap = 0;
        Random rnd = new Random();


        for (lives = 3; lives > 0;)
        {
            trap = rnd.Next(1, 2);
            if (trap == 1)
            {
                lives--;
                Console.WriteLine(Traps);
            }
            else
            {
                if (coins < 5)
                {
                    coins++;
                    Console.WriteLine(Coin);
                    Console.WriteLine(TotalCoin + coins);
                }else
                {
                    lives = 0;
                }
            }
        }
        
        if (coins >= 5)
        {
            Console.WriteLine(Winner);
        }
        else
        {
            Console.WriteLine(Lost);
        }
    }
}