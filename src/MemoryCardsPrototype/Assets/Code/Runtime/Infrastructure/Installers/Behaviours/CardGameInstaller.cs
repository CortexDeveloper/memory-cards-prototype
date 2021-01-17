using Code.Runtime.CardGame.Factories;
using Zenject;

namespace Code.Runtime.Infrastructure.Installers.Behaviours
{
  public class CardGameInstaller : MonoInstaller
  {
    public override void InstallBindings()
    {
      BindCardGameFactory();
    }

    private void BindCardGameFactory()
    {
      Container
        .Bind<ICardGameFactory>()
        .To<CardGameFactory>()
        .AsSingle()
        .NonLazy();
    }
  }
}