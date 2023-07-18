namespace Abstract.AbstractCommand
{
    public interface IHistory
    {
        public void ReadDown(ICommand command);
        public void Undo();
    }
}