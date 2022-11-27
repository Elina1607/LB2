namespace ConsoleApplication1
{
    public class RatedGame : Game
    {
        public RatedGame(GameAccount player1, GameAccount player2) : base(player1, player2)
        {
        }

        public override void Play()
        {
            Rating = Rand.Next(1, 10);
            base.Play();
        }
    }
}