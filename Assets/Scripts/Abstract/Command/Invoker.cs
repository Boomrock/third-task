using System.Collections.Generic;
using UnityEngine;

namespace Abstract.Command
{
    public class Invoker: IInvoker<GameObject>
    {

        protected readonly List<GameObject> observers = new();
        private readonly Stack<ICommand<GameObject>> executeCommand = new();

        public virtual void Subscribe(GameObject gameObject)
        {
            observers.Add(gameObject);
        } 
        public void Execute(ICommand<GameObject> command)
        {
            observers.ForEach(i=> command.Execute(i));
            executeCommand.Push(command);
        }
        public void Undo()
        {
            var command = executeCommand.Pop();
            observers.ForEach(i=> command.Cancle(i));
        }
    }
}