namespace ConsoleApplication1
{
    public class UnRatedGame : Game
    {
        public UnRatedGame(GameAccount player1, GameAccount player2) : base(player1, player2)
        {
        }

        public override void Play()
        {
            Rating = 0;
            base.Play();
        }
    }
}