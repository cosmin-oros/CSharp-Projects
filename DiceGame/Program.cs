namespace Dice_Gane{
    class Program{
        static void Main(string[] args){
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            for(int i=0; i<10;i++){
                Console.WriteLine("Press any key to roll the dice.");

                Console.ReadKey();

                playerRandomNum = random.Next(1,7);
                Console.WriteLine("You rolled a "+playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1,7);
                Console.WriteLine("Opponent rolled a "+enemyRandomNum);

                if(playerRandomNum > enemyRandomNum){
                    playerPoints++;
                    Console.Write("Player wins this round");
                }else if(playerRandomNum < enemyRandomNum){
                    enemyPoints++;
                    Console.WriteLine("Opponent wins this round");
                }else{
                    Console.WriteLine("It's a tie");
                }

                Console.WriteLine("The score is now - Player : "+playerPoints+", Opponent: "+enemyPoints);
                Console.WriteLine();
            }
            if(playerPoints > enemyPoints){
                Console.WriteLine("You win!");
            }else if(playerPoints < enemyPoints){
                Console.WriteLine("You lose!");
            }else{
                Console.WriteLine("It's a tie");
            }
            Console.ReadKey();
        }
    }
}