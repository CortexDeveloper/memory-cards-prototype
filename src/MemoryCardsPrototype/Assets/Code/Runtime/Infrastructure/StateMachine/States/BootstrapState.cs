using Code.Runtime.Infrastructure.Services.ScenesLoader;
using Zenject;

namespace Code.Runtime.Infrastructure.StateMachine.States
{
  public class BootstrapState : IState
  {
    [Inject]
    private void Construct(IGameStateMachine gameStateMachine, ISceneLoader sceneLoader)
    {
      StateMachine = gameStateMachine;
      _sceneLoader = sceneLoader;
    }

    private const string LobbyScene = "Lobby";

    private ISceneLoader _sceneLoader;
    
    public IStateMachine StateMachine { get; private set; }
    
    public void Enter()
    {
      LoadUserSettings();
      LoadLobbyScene();
    }

    public void Exit()
    {
      
    }

    private void SetLobbyState() =>
      StateMachine.ChangeState(GameStates.Lobby);

    private void LoadLobbyScene() =>
      _sceneLoader.LoadScene(LobbyScene, SetLobbyState);

    private void LoadUserSettings()
    {
      //TODO implement      
    }
  }
}