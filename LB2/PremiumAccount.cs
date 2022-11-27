namespace ConsoleApplication1
{
    public class PremiumAccount : GameAccount
    {
        private int _winStreak = 0;
        
        public PremiumAccount(string userName) : base(userName)
        {
        }

        public override void WinGame(Game game)
        {
            base.WinGame(game);            
            _winStreak++;
            if (_winStreak > 4) _winStreak = 4;
        }

        public override void LoseGame(Game game)
        {
            _winStreak = 1;
            base.LoseGame(game);
        }

        public override string GetAccountType()
        {
            return "Premium Акаунт";
        }

        protected override int CalculateRating(int inputRating)
        {
            return inputRating * _winStreak;
        }
    }
}