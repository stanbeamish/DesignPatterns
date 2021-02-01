namespace DesignPatterns.SingletonPattern
{
    public class BankValues
    {
        private BankValues() {}

        // the only instance of BankValue ever created
        private static BankValues _singletonBankValue;
        
        // global method to receive the instance
        public static BankValues GetInstance()
        {
            return _singletonBankValue ??= new BankValues();
        }

        private double _accountInterest = 0.0;
        private int _accountTransactionVolume = 1000;
        private int _accountFees = 10;
        private int _accountDispositionLimit = -500;
        

        public void SetAccountDispositionLimit(int accountDispositionLimit)
        {
            _accountDispositionLimit = accountDispositionLimit;
        }
        
        public void SetAccountTransactionVolume(int accountTransactionVolume)
        {
            _accountTransactionVolume = accountTransactionVolume;
        }

        public void SetAccountInterest(double accountInterest)
        {
            if (accountInterest > 0 && accountInterest < 4)
            {
                _accountInterest = accountInterest;
            }
        }
        
        public void SetAccountFees(int accountFees)
        {
            if (accountFees > 0 && accountFees < 50)
            {
                _accountFees = accountFees;
            }
        }
    }
    
}