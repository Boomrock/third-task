namespace Abstract.FSM
{
    public interface IStateMachine
    {
        State CurrentState { get; }
        bool TryTransit(State nextState);
        void Transit(State nextState);
        void Update();
    }
}