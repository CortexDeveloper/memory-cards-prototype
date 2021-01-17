using Code.Runtime.CardGame.Factories;
using Zenject;

namespace Code.Runtime.Infrastructure.Installers.Behaviours
{
  public class CardGameInstaller : MonoInstaller
  {
    public override void InstallBindings()
    {
      BindCardGameFactory();
      BindCardsFactory();
    }

    private void BindCardGameFactory()
    {
      Container
        .Bind<ICardGameFactory>()
        .To<CardGameFactory>()
        .AsSingle()
        .NonLazy();
    }
    
    private void BindCardsFactory()
    {
      Container
        .Bind<ICardsFactory>()
        .To<CardsFactory>()
        .AsSingle()
        .NonLazy();
    }
  }
}