using Code.Runtime.Infrastructure.StateMachine;

namespace Code.Runtime.Infrastructure.EntryPoint
{
  public class Game
  {
    private readonly IGameStateMachine _stateMachine;

    public Game(IGameStateMachine stateMachine)
    {
      _stateMachine = stateMachine;
      stateMachine.ChangeState(GameStates.Bootstrap);
    }
  }
}