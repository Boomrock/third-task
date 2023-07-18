namespace Abstract.FSM
{
    public interface IStateMachine
    {
        State CurrentState { get; }
        void Update();
    }
}