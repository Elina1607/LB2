using System;

namespace ConsoleApplication1
{
    public abstract class Game
    {
        private int _rating;
        public int Rating
        {
            get => _rating;
            protected set
            {
                _rating = value;
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(value));
            }
        }

        public static int GameId = 0;
        
        public readonly GameAccount Player1;
        public readonly GameAccount Player2;

        protected static readonly Random Rand = new Random();

        protected Game(GameAccount player1, GameAccount player2)
        {
            Player1 = player1;
            Player2 = player2;
        }
        
        public virtual void Play()
        {
            GameId++;
            if (Rand.Next(2) == 0)
            {
                Player1.WinGame(this);
                Player2.LoseGame(this);
            }
            else
            {
                Player2.WinGame(this);
                Player1.LoseGame(this);
            }
        }
        
    }
}