using Zenject;

namespace Code.Runtime.Infrastructure.StateMachine.States
{
  public class SessionState : IState
  {
    [Inject]
    private void Construct(IGameStateMachine gameStateMachine) =>
      StateMachine = gameStateMachine;
    
    public IStateMachine StateMachine { get; private set; }

    public void Enter()
    {
      
    }

    public void Exit()
    {
      
    }
  }
}