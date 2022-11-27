namespace ConsoleApplication1
{
    public class SoloRatedGame : Game
    {
        public SoloRatedGame(GameAccount player1) : base(player1, new GameAccount("SYSTEM"))
        {
        }

        public override void Play()
        {
            Rating = Rand.Next(1, 10);
            base.Play();
        }
    }
}