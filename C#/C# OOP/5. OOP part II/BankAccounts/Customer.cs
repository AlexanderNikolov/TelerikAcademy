namespace BankAccounts
{
    public abstract class Customer
    {
        protected string name;
        protected string address;

        //.tor
        public Customer(string name, string address)
        {
            this.Name = name;
            this.Address = address;

        }

        //properties
        public string Name 
        {
            get { return this.name; }
            set { this.name = value; }
        }
        
        public string Address 
        {
            get { return this.address; }
            set { this.address = value; }
        }
    }
}
