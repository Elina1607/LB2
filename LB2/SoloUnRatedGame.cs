namespace ConsoleApplication1
{
    public class SoloUnRatedGame : Game
    {
        public SoloUnRatedGame(GameAccount player1) : base(player1,  new GameAccount("SYSTEM"))
        {
        }

        public override void Play()
        {
            Rating = 0;
            base.Play();
        }
    }
}