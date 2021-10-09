namespace IteratorPatternExample.Objects
{
    public class ConcreteIterator<T> : IIterator<T>
    {
        private readonly ConcreteIterable<T> _iterable;
        private int Index { get; set; }

        public ConcreteIterator(ConcreteIterable<T> iterable)
        {
            _iterable = iterable;
        }

        public bool HasNext()
        {
            return Index < _iterable.Pieces.Length;
        }

        public void Next()
        {
            Index += 1;
        }

        public T Current()
        {
            return _iterable.Pieces[Index];
        }
    }
}