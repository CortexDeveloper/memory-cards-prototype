using Code.Runtime.Infrastructure.EntryPoint;
using Code.Runtime.Infrastructure.Services.CoroutinesRunner;
using Code.Runtime.Infrastructure.Services.ScenesLoader;
using Code.Runtime.Infrastructure.StateMachine;
using Code.Runtime.Infrastructure.StateMachine.States;
using UnityEngine;
using Zenject;

namespace Code.Runtime.Infrastructure.Installers
{
  public class BootstrapInstaller : MonoInstaller
  {
    [SerializeField] private GameObject _coroutineRunner;
    
    public override void InstallBindings()
    {
      BindCoroutineRunner();
      BindScenesLoader();
      BindGameStateMachine();
      BindGameInstance();
    }

    private void BindGameInstance()
    {
      Container
        .Bind<IGame>()
        .To<Game>()
        .AsSingle()
        .NonLazy();
    }

    private void BindScenesLoader()
    {
      Container
        .Bind<ISceneLoader>()
        .To<ScenesLoader>()
        .AsSingle();
    }
    
    private void BindCoroutineRunner()
    {
      Container
        .Bind<ICoroutinesRunner>()
        .FromComponentInNewPrefab(_coroutineRunner)
        .AsSingle();
    }
    
    private void BindGameStateMachine()
    {
      Container
        .Bind<BootstrapState>()
        .To<BootstrapState>()
        .AsSingle();
      
      Container
        .Bind<LobbyState>()
        .To<LobbyState>()
        .AsSingle();

      Container
        .Bind<SessionState>()
        .To<SessionState>()
        .AsSingle();
      
      Container
        .Bind<IGameStateMachine>()
        .To<GameStateMachine>()
        .AsSingle();
    }
  }
}