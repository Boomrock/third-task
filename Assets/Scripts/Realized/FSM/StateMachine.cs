using Abstract.FSM;
using UnityEngine.UI;

namespace Realized.FSM
{
    public class StateMachine: IStateMachine
    {
        public State CurrentState { get=> currentState; }
        
        private readonly Transition[] transitions;
        private State currentState;

        public StateMachine(Transition[] transitions)
        {
            this.transitions = transitions;
        }
        public void Update()
        {
            foreach (var transition in transitions)
            {
                if (transition.CanTransit() && transition.CurrentState == CurrentState)
                {
                    currentState = transition.NextState;
                    transition.Action.Invoke();
                    break;
                }
            }
        }
    }
}