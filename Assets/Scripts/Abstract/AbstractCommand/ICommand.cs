namespace Abstract.AbstractCommand
{
    public interface ICommand
    {
        public void Execute();
        public void Cancle();
    }
}