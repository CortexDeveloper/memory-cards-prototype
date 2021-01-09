using System.Collections.Generic;
using Code.Runtime.Infrastructure.StateMachine;
using Code.Runtime.Infrastructure.StateMachine.States;
using UnityEngine;

namespace Code.Runtime.Infrastructure.EntryPoint
{
  public class GameBootstrapper : MonoBehaviour
  {
    private void Awake() =>
      CreateGameInstance();

    private static void CreateGameInstance()
    {
      Game game = new Game(new GameStateMachine(
        new Dictionary<GameStates, IState>
        {
          [GameStates.Bootstrap] = new BootstrapState(),
          [GameStates.Lobby] = new LobbyState(),
          [GameStates.Game] = new GameState()
        }));
    }
  }
}