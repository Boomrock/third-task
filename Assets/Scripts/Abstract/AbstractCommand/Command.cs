using System;

namespace Abstract.AbstractCommand
{
    public abstract class Command: ICommand
    {
        public abstract event Action CommandExecuteNotify;
        
        private readonly IHistory history;

        public Command(IHistory history)
        {
            this.history = history;
        }
        public virtual void Execute()
        {
            history.ReadDown(this);
        }

        public abstract void Cancle();
    }
}