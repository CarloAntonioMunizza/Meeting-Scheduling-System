namespace Meeting_Scheduling_System.ModelTrusted
{
    internal class BillingInfo
    {
        //define vars
        private string typeOfCard, nameOnCard;
        private int cardNumber, expMonth, expYear, cvv, zipcode;

        //constructor
        public BillingInfo(string typeOfCard, string nameOnCard, int cardNumber, int expMonth, int expYear, int cvv, int zipcode)
        {
            this.typeOfCard = typeOfCard;
            this.nameOnCard = nameOnCard;
            this.cardNumber = cardNumber;
            this.expMonth = expMonth;
            this.expYear = expYear;
            this.cvv = cvv;
            this.zipcode = zipcode;
        }

        //setters / getters
        public string TypeOfCard { get => typeOfCard; set => typeOfCard = value; }
        public string NameOnCard { get => nameOnCard; set => nameOnCard = value; }
        public int CardNumber { get => cardNumber; set => cardNumber = value; }
        public int ExpMonth { get => expMonth; set => expMonth = value; }
        public int ExpYear { get => expYear; set => expYear = value; }
        public int Cvv { get => cvv; set => cvv = value; }
        public int Zipcode { get => zipcode; set => zipcode = value; }
    }
}