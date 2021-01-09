using Code.Runtime.Infrastructure.EntryPoint;
using Code.Runtime.Infrastructure.StateMachine;
using Code.Runtime.Infrastructure.StateMachine.States;
using Zenject;

namespace Code.Runtime.Infrastructure.Installers
{
  public class BootstrapInstaller : MonoInstaller
  {
    public override void InstallBindings()
    {
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