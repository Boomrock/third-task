namespace Abstract.Command
{
    public interface ICommand<T>
    {
        public T Execute();
        public T Cancle();
    }
}