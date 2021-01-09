using Code.Runtime.Infrastructure.StateMachine;

namespace Code.Runtime.Infrastructure.EntryPoint
{
  public class Game : IGame
  {
    private readonly IGameStateMachine _stateMachine;

    public Game(IGameStateMachine stateMachine) =>
      _stateMachine = stateMachine;

    public void Initialize() =>
      _stateMachine.ChangeState(GameStates.Bootstrap);
  }
}