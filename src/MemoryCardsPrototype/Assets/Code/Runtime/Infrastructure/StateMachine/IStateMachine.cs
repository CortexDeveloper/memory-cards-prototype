using Infrastructure.StateMachine.States;

namespace Infrastructure.StateMachine
{
  public interface IStateMachine
  {
    IState CurrentState { get; }

    void ChangeState(GameStates state);
  }
}