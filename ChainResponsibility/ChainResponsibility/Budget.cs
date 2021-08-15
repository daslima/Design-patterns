using System.Collections.Generic;

namespace ChainResponsibility
{
    public class Budget
    {
        public double Total { get;  set; }
        public double Discount { get; set; }
        public string TypeDiscount { get; set; }
        public IList<Item> Items { get; private set; }

        public Budget() => Items = new List<Item>();

        public void addItem(Item item) => Items.Add(item);
        
        public double GetTotal()
        {
            Total = 0;

            foreach (var item in Items)
                Total += item.Value;

            return Total;
        }
    }
}
