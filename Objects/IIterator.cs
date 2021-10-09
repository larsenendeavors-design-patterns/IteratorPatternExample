namespace IteratorPatternExample.Objects
{
    public interface IIterator<T>
    {
        public bool HasNext();
        public void Next();
        public T Current();
    }
}