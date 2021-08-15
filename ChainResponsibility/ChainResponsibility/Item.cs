namespace ChainResponsibility
{
    public  class Item
    {
        public string Name { get; private set; }
        public double Value { get; set; }

        public Item(string name, double value)
        {
            Name = name;
            Value = value;
        }
    }
}
