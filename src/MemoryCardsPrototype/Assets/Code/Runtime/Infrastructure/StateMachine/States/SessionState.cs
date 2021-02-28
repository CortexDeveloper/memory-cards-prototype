using Infrastructure.Services.ScenesLoader;
using Zenject;

namespace Infrastructure.StateMachine.States
{
  public class SessionState : IState
  {
    [Inject]
    private void Construct(IGameStateMachine gameStateMachine, ISceneLoader sceneLoader)
    {
      StateMachine = gameStateMachine;
      _sceneLoader = sceneLoader;
    }
    
    private ISceneLoader _sceneLoader;
    
    public IStateMachine StateMachine { get; private set; }

    public void Enter()
    {
      
    }

    public void Exit()
    {
      
    }
  }
}