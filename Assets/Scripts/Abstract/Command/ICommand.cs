namespace Abstract.Command
{
    public interface ICommand<T>
    {
        public T Execute(T obj);
        public T Cancle(T obj);
    }
}