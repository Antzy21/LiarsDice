namespace LiarsDiceGame
{
    public class Claim
    {
        public int quantity;
        public Dice dice;
        public string claimer;

        public Claim(int q, Dice d, string c)
        {
            quantity = q;
            dice = d;
            claimer = c;
        }

        public Claim(decimal q, Dice d, string c)
        {
            quantity = (int)q;
            dice = d;
            claimer = c;
        }
    }
}
