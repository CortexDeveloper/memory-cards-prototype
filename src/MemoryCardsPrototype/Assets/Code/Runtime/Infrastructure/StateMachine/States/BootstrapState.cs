using UnityEngine.SceneManagement;
using Zenject;

namespace Code.Runtime.Infrastructure.StateMachine.States
{
  public class BootstrapState : IState
  {
    [Inject]
    private void Construct(IGameStateMachine gameStateMachine) =>
      StateMachine = gameStateMachine;

    private const string LobbyScene = "Lobby";
    
    public IStateMachine StateMachine { get; private set; }
    
    public void Enter()
    {
      LoadUserSettings();
      LoadLobbyScene();
    }

    public void Exit()
    {
      
    }

    private static void LoadLobbyScene() => 
      SceneManager.LoadScene(LobbyScene);

    private static void LoadUserSettings()
    {
      //TODO implement      
    }
  }
}