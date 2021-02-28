using Infrastructure.Factories.UI;
using Zenject;

namespace Infrastructure.Installers.Behaviours
{
    public class LobbyInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindLobbyMenuFactory();
        }

        private void BindLobbyMenuFactory()
        {
            Container
                .Bind<ILobbyMenuFactory>()
                .To<LobbyMenuFactory>()
                .AsSingle()
                .NonLazy();
        }
    }
}
