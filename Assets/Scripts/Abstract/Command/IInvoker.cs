namespace Abstract.Command
{
    public interface IInvoker<T>
    {
        public void Execute(ICommand<T> command);
        public void Undo();
    }
}