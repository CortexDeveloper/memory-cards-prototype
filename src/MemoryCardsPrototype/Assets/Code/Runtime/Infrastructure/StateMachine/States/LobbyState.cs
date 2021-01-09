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

    }

    public void Exit() =>
      LoadSessionScene();

    private void LoadSessionScene() =>
      _sceneLoader.LoadScene(Scenes.SessionScene, () => { });
  }
}