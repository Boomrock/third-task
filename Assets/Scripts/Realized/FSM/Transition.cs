using System;
using Abstract.FSM;

namespace Realized.FSM
{
    public class Transition: ITransition
    {
        public readonly State CurrentState;
        public readonly State NextState;
        public readonly Action Action;

        private Func<bool> condition;
        public Transition(State currentState, State nextState,Func<bool> condition, Action action)
        {
            this.CurrentState = currentState;
            this.NextState = nextState;
            this.condition = condition;
            this.Action = action;
        }
        public bool CanTransit()
        {
            return condition.Invoke();
        }
    }
}