namespace ConsoleApplication1
{
    public class VipAccount : GameAccount
    {
        public VipAccount(string userName) : base(userName)
        {
        }

        protected override int CalculateRating(int inputRating)
        {
            return inputRating * 2;
        }

        public override string GetAccountType()
        {
            return "VIP-Акаунт";
        }
    }
}