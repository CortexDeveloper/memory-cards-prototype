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
      GameObject cardFieldPrefab = Resources.Load<GameObject>(CardGamePaths.CardsFieldPrefab);
      GameObject cardGame = _diContainer.InstantiatePrefab(cardFieldPrefab);
      cardGame.name = cardGame.name.Replace("(Clone)", string.Empty);
    }
  }
}