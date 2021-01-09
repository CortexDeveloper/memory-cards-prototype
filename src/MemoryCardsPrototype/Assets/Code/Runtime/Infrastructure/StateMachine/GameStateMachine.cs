using System.Collections.Generic;
using Code.Runtime.Infrastructure.StateMachine.States;

namespace Code.Runtime.Infrastructure.StateMachine
{
  public class GameStateMachine : IGameStateMachine
  {
    public GameStateMachine()
    {
      _states = new Dictionary<GameStates, IState>
      {
        [GameStates.Bootstrap] = new BootstrapState(this),
        [GameStates.Lobby] = new LobbyState(this),
        [GameStates.Game] = new GameState(this)
      };
    }

    public IState CurrentState { get; private set; } 

    private readonly Dictionary<GameStates, IState> _states;
    
    public void ChangeState(GameStates state)
    {
      CurrentState?.Exit();
      CurrentState = _states[state];
      CurrentState?.Enter();
    }
  }
}