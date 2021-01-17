using Code.Runtime.Infrastructure.Factories.UI;
using Zenject;

namespace Code.Runtime.Infrastructure.Installers.Behaviours
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
