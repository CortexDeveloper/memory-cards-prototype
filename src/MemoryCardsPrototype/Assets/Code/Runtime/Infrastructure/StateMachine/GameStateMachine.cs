using System.Collections.Generic;
using Code.Runtime.Infrastructure.StateMachine.States;
using Zenject;

namespace Code.Runtime.Infrastructure.StateMachine
{
  public class GameStateMachine : IGameStateMachine
  {
    [Inject]
    public void Construct(BootstrapState bootstrapState, LobbyState lobbyState, SessionState sessionState)
    {
      _states = new Dictionary<GameStates, IState>
      {
        [GameStates.Bootstrap] = bootstrapState,
        [GameStates.Lobby] = lobbyState,
        [GameStates.Game] = sessionState
      };
    }

    public IState CurrentState { get; private set; } 

    private Dictionary<GameStates, IState> _states;
    
    public void ChangeState(GameStates state)
    {
      CurrentState?.Exit();
      CurrentState = _states[state];
      CurrentState?.Enter();
    }
  }
}