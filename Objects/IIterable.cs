namespace IteratorPatternExample.Objects
{
    public interface IIterable<T>
    {
        public IIterator<T> GetIterator();
    }
}