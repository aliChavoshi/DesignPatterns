namespace DesignPatterns.Encapsulation
{
    public class Account
    {
        private float _balanced;

        public void Deposit(float amount)
        {
            if (amount>0)
                _balanced += amount;
        }

        public void Withdraw(float amount)
        {
            if (amount > 0)
                _balanced-=amount;
        }

        /*public void SetBalanced(float balance)
        {
            if (balance > 0)
                _balanced = balance;
        }*/

        public float GetBalanced()
        {
            return _balanced;
        }
    }
}