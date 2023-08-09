namespace Meeting_Scheduling_System.ModelTrusted
{
    internal class BillingInfo
    {
        //define vars
        private int cardNumber,ccv ;

        //constructor
        public BillingInfo(int cardNumber, int ccv)
        {
            this.cardNumber = cardNumber;
            this.ccv = ccv;
            
        }

        //setters / getters
       
        public int CardNumber { get => cardNumber; set => cardNumber = value; }
        public int Ccv { get => ccv; set => ccv = value; }
      
    }
}