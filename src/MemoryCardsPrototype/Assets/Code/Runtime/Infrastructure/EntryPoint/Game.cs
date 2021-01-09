using Code.Runtime.Infrastructure.StateMachine;

namespace Code.Runtime.Infrastructure.EntryPoint
{
  public class Game
  {
    private readonly GameStateMachine _stateMachine;

    public Game(GameStateMachine stateMachine)
    {
      _stateMachine = stateMachine;
      stateMachine.ChangeState(GameStates.Bootstrap);
    }
  }
}