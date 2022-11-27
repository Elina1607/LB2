using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Гра почалась \n");
            GameAccount player1 = new VipAccount("Гравець 1");
            GameAccount player2 = new PremiumAccount("Гравець 2");
            GameAccount player3 = new GameAccount("Гравець 3");
            // ігри 1 на 1
            GameController.StartRatedGame(player1, player2);
            GameController.StartRatedGame(player1, player2);
            GameController.StartUnRatedGame(player1, player2);
            GameController.StartRatedGame(player1, player2);
            GameController.StartUnRatedGame(player1, player2);            GameController.StartRatedGame(player1, player2);
            GameController.StartRatedGame(player3, player2);
            GameController.StartRatedGame(player3, player2);
            GameController.StartRatedGame(player1, player3);

            // Одиночні ігри
            GameController.StartSoloRatedGame(player1);
            GameController.StartSoloUnRatedGame(player1);
            GameController.StartSoloRatedGame(player2);
            GameController.StartSoloRatedGame(player3);
            // Вивід історії ігор
            player1.PrintStats();
            player2.PrintStats();
            player3.PrintStats();
        }
    }
}