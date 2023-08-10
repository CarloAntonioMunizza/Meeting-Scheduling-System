namespace Meeting_Scheduling_System.ModelTrusted
{
    internal class BillingInfo
    {
        //define vars
        private int ccv;
        private long cardNumber;

        //constructor
        public BillingInfo(long cardNumber, int ccv)
        {
            this.cardNumber = cardNumber;
            this.ccv = ccv;
            
        }

        //setters / getters
       
        public long CardNumber { get => cardNumber; set => cardNumber = value; }
        public int Ccv { get => ccv; set => ccv = value; }
      
    }
}