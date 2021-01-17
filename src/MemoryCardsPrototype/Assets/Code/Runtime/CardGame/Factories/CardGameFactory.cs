using Code.Runtime.Infrastructure.StateMachine;
using UnityEngine;
using Zenject;

namespace Code.Runtime.CardGame.Factories
{
  public class CardGameFactory : ICardGameFactory
  {
    public CardGameFactory(DiContainer diContainer) =>
      _diContainer = diContainer;

    private readonly DiContainer _diContainer;
    
    public void Create()
    {
      GameObject cardField = Resources.Load<GameObject>(CardGamePaths.CardsFieldPrefab);
      _diContainer.InstantiatePrefab(cardField);
      
      
    }
  }
}