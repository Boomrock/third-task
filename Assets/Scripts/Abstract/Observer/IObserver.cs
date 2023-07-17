namespace Abstract.Observer
{
    public interface IObserver<T>
    {
        void Update(T obj);
    }
}