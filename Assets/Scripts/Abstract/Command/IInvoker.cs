namespace Abstract.Command
{
    public interface IInvoker<T>
    {
        public void Execute(ICommand<T> command);
        public void Execute(ICommand<T>[] commands);
        public void Undo();
        public void Undo(int count);
    }
}