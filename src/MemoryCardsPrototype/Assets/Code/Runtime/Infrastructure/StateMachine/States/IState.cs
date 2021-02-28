namespace Infrastructure.StateMachine.States
{
  public interface IState
  {
    IStateMachine StateMachine { get; }

    void Enter();
    void Exit();
  }
}