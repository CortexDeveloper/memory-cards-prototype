using Code.Runtime.Infrastructure.StateMachine.States;

namespace Code.Runtime.Infrastructure.StateMachine
{
  public interface IStateMachine
  {
    IState CurrentState { get; }

    void ChangeState(GameStates state);
  }
}