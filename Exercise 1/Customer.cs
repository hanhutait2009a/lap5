namespace Exercise_1
{
    public class Customer : Order
    {
        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public Customer()
        {
        }

        public Customer(string name)
        {
            this.name = name;
        }
    }
}