namespace IteratorPatternExample.Objects
{
    public class ConcreteIterable<T> : IIterable<T>
    {
        private readonly ConcreteIterator<T> _iterator;
        public T[] Pieces { get; set; }

        public ConcreteIterable(T[] pieces)
        {
            _iterator = new ConcreteIterator<T>(this);
            Pieces = pieces;
        }

        public IIterator<T> GetIterator()
        {
            return _iterator;
        }
    }
}