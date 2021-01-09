namespace Code.Runtime.Infrastructure.StateMachine.States
{
  public class GameState : IState
  {
    public GameState(IStateMachine stateMachine) =>
      StateMachine = stateMachine;

    public IStateMachine StateMachine { get; }

    public void Enter()
    {
      
    }

    public void Exit()
    {
      
    }
  }
}