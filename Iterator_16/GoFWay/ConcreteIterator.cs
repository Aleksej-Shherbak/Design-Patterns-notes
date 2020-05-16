namespace Iterator_16.GoFWay
{
    public class ConcreteIterator: Iterator
    {
        private Aggregate _aggregate;
        private int _current = 0;

        public ConcreteIterator(Aggregate aggregate)
        {
            _aggregate = aggregate;
        }

        public override object CurrentItem()
        {
            return _aggregate[_current];
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override bool IsDone()
        {
            if (_current < _aggregate.Count)
            {
                return false;
            }

            _current = 0;
            return true;
        }

        public override object Next()
        {
            _current++;

            if (_current < _aggregate.Count)
            {
                return _aggregate[_current];
            }

            return null;

        }
    }
}