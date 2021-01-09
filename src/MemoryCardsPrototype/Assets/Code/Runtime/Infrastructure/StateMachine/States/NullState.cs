namespace Code.Runtime.Infrastructure.StateMachine.States
{
  public class NullState : IState
  {
    public NullState(IStateMachine stateMachine) =>
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