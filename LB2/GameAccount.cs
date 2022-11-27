using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class GameAccount
    {
        public string UserName { get; }

        protected int currentRating = 1;
        public int CurrentRating
        {
            get => currentRating;
            set
            {
                currentRating = value;
                if (currentRating < 1) currentRating = 1;
            }
        }

        protected readonly List<Match> Matches = new List<Match>(); 

        public GameAccount(string userName)
        {
            UserName = userName;
        }
        
        public virtual void WinGame(Game game)
        {
            CurrentRating += CalculateRating(game.Rating);
            Matches.Add(new Match(Game.GameId, game.Player1.UserName != UserName ? game.Player1.UserName : game.Player2.UserName,GameResult.Win,CalculateRating(game.Rating)));
        }
        public virtual void LoseGame(Game game)
        {
            CurrentRating -= game.Rating;
            Matches.Add(new Match(Game.GameId, game.Player1.UserName != UserName ? game.Player1.UserName : game.Player2.UserName,GameResult.Lose,game.Rating));
        }
        public virtual string GetAccountType()
        {
            return "Звичайний";
        }
        protected virtual int CalculateRating(int inputRating)
        {
            return inputRating;
        }
        public void PrintStats()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Акаунт гравця " + UserName);
            Console.Write("Рейтинг: " + currentRating);
            Console.WriteLine(" Тип акаунту: " + GetAccountType());
            Console.WriteLine("===============================");
            foreach (var match in Matches)
            {
                match.printMatchInfo();
                Console.WriteLine("-------------------------------");
            }
        }

    }
}