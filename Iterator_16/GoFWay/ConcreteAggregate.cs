using System.Collections;

namespace Iterator_16.GoFWay
{
    public class ConcreteAggregate: Aggregate
    {
        private ArrayList items = new ArrayList();
        
        public override Iterator CreateIterator()
        {
           return new ConcreteIterator(this);
        }

        public override int Count => items.Count;

        public override object this[int index]
        {
            get => items[index];
            set => items.Insert(index, value);
        }
    }
}