using Code.Runtime.Infrastructure.Services.SaveLoadService;
using Code.Runtime.Infrastructure.Services.ScenesLoader;
using Zenject;

namespace Code.Runtime.Infrastructure.StateMachine.States
{
  public class BootstrapState : IState
  {
    [Inject]
    private void Construct(IGameStateMachine gameStateMachine,
      ISceneLoader sceneLoader,
      ISaveLoadService<UserSettingsData> saveLoadService)
    {
      StateMachine = gameStateMachine;
      _sceneLoader = sceneLoader;
      _saveLoadService = saveLoadService;
    }
    
    private ISceneLoader _sceneLoader;
    private ISaveLoadService<UserSettingsData> _saveLoadService;
    
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
      _sceneLoader.LoadScene(Scenes.LobbyScene, SetLobbyState);

    private void LoadUserSettings() =>
      _saveLoadService.Load();
  }
}