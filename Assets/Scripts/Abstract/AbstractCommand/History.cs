using System.Collections.Generic;
using UnityEngine;

namespace Abstract.AbstractCommand
{
    public class History: IHistory
    {
        private readonly Stack<ICommand> executeCommand = new();
        public void ReadDown(ICommand command)
        {
            executeCommand.Push(command);
        }
        public void Undo()
        {
            var command = executeCommand.Pop();
            command.Cancle();
        }
    }
}