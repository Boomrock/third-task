using System;

namespace Abstract.AbstractCommand
{
    public abstract class Command: ICommand
    {
        public event Action CommandExecuteNotify;
        
        private readonly IHistory history;

        public Command(IHistory history)
        {
            this.history = history;
        }
        public virtual void Execute()
        {
            history.ReadDown(this);
            CommandExecuteNotify?.Invoke();
        }

        public abstract void Cancle();
    }
}