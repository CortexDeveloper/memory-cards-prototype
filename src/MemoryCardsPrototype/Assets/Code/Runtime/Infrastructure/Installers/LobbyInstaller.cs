using Code.Runtime.Infrastructure.Factories.UI;
using UnityEngine;
using Zenject;

namespace Code.Runtime.Infrastructure.Installers
{
    public class LobbyInstaller : MonoInstaller, IInitializable
    {
        [SerializeField] private Transform _uiHolder;
        
        public override void InstallBindings() =>
            BindLobbyMenuFactory();

        private void BindLobbyMenuFactory()
        {
            Container
                .Bind<ILobbyMenuFactory>()
                .To<LobbyMenuFactory>()
                .AsSingle()
                .NonLazy();
        }
        
        public void Initialize()
        {
            ILobbyMenuFactory lobbyMenuFactory = Container.Resolve<ILobbyMenuFactory>();
            GameObject lobbyMenu = lobbyMenuFactory.Create(_uiHolder.transform.position, Quaternion.identity, _uiHolder);
        }
    }
}
