using System.Linq;
using Abstract.FSM;
using UnityEngine.UI;

namespace Realized.FSM
{
    public class StateMachine : IStateMachine
    {
        public State CurrentState
        {
            get => currentState;
        }

        private readonly Transition[] transitions;
        private State currentState;

        public bool TryTransit(State nextState)
        {
            foreach (var transition in transitions)
            {
                if (transition.CurrentState == CurrentState && transition.NextState == nextState)
                {
                    changeState(transition);
                    return true;
                }
            }

            return false;
        }


        public void Transit(State nextState)
        {
            if (!TryTransit(nextState))
            {
                foreach (var transition in transitions)
                {
                    if (transition.NextState == nextState)
                    {
                        changeState(transition);

                    }
                }
            }
        }

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
                    changeState(transition);
                    break;
                }
            }
        }

        private void changeState(Transition transition)
        {
            currentState = transition.NextState;
            transition.Action.Invoke();
        }
    }
}