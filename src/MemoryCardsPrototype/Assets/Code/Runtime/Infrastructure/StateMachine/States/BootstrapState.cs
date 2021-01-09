using UnityEngine.SceneManagement;

namespace Code.Runtime.Infrastructure.StateMachine.States
{
  public class BootstrapState : IState
  {
    public BootstrapState(GameStateMachine stateMachine)
    {
        
    }
    
    private const string LobbyScene = "Lobby";
    
    public void Enter()
    {
      LoadUserSettings();
      LoadLobbyScene();
    }

    public void Exit()
    {
      
    }

    private static void LoadLobbyScene()
    {
      SceneManager.LoadScene(LobbyScene);
      
    }

    private static void LoadUserSettings()
    {
      //TODO implement      
    }
  }
}