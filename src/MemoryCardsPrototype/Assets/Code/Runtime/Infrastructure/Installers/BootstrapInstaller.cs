using Zenject;

namespace Code.Runtime.Infrastructure.Installers
{
  public class BootstrapInstaller : MonoInstaller
  {
    public override void InstallBindings()
    {
      BindGameStateMachine();
    }

    private void BindGameStateMachine()
    {
      // Container
      //   .Bind<IGameStateMachine>()
      //   .FromInstance(new GameStateMachine());
      //
      // Container
      //   .Bind<IGameStateMachine>()
      //   .To<GameStateMachine>();
      //
      // Container
      //   .Bind<BootstrapState>()
      //   .To<BootstrapState>();
      //
      // Container
      //   .Bind<LobbyState>()
      //   .To<LobbyState>();
      //
      // Container
      //   .Bind<GameState>()
      //   .To<GameState>();
    }
  }
}