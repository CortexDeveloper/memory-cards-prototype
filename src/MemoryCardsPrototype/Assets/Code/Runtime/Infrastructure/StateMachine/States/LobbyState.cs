using Code.Runtime.Infrastructure.Services.ScenesLoader;
using Zenject;

namespace Code.Runtime.Infrastructure.StateMachine.States
{
  public class LobbyState : IState
  {
    [Inject]
    private void Construct(IGameStateMachine gameStateMachine) =>
      StateMachine = gameStateMachine;
    
    private ISceneLoader _sceneLoader;
    public IStateMachine StateMachine { get; private set; }

    public void Enter()
    {
      ShowMenu();
    }

    public void Exit() =>
      LoadSessionScene();

    private void ShowMenu()
    {
      //call factory create method
    }

    private void LoadSessionScene() =>
      _sceneLoader.LoadScene(Scenes.SessionScene, () => { });
  }
}