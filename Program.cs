using System.Diagnostics.Contracts;

internal class Program
{
    private static void Main(string[] args)
    {
        int playerScore = 0, enemyScore = 0;
        bool fail = false;
        Random dice = new Random();
        while (true) 
        { 
            

            Console.WriteLine("Press any key to roll the Dice");
            Console.ReadKey(true);


            int player = dice.Next(1, 6);
            int enemy = dice.Next(1, 6);

            Console.WriteLine($"Du hast {player} gewürfelt. Dein Gegner hat {enemy} gewürfelt.");
            if (player > enemy) 
            {
                playerScore += 1;
                Console.WriteLine("Du hast ein Punkt gewonnen.");
            }
            else if (enemy > player)
            {
                enemyScore += 1;
                Console.WriteLine("Der Gegner hat ein Punkt gewonnen.");

            }
            else
            {
                Console.WriteLine("Gleichstand");
            }
            Console.WriteLine($"Somit steht es {playerScore} zu {enemyScore}. \n");
            if(playerScore == 3 || enemyScore == 3) 
            {
                Console.WriteLine("Das Spiel ist zu ende.");
                if (playerScore == 3)
                {
                    Console.WriteLine("Der Spieler hat gewonnen.");
                    fail = true;
                }
                else 
                {
                    Console.WriteLine("Der Gegner hat gewonnen");
                    fail = true;
                }
            }
            if (fail) {break; }
        }
    }
}