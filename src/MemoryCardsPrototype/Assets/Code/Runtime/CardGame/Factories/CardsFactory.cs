using UnityEngine;
using Zenject;

namespace CardGame.Factories
{
  public class CardsFactory : ICardsFactory
  {
    public CardsFactory(DiContainer diContainer) =>
      _diContainer = diContainer;

    private readonly DiContainer _diContainer;
    
    public GameObject Create(Transform parent, Vector3 position)
    {
      GameObject card = Resources.Load<GameObject>(CardGamePaths.CardPrefab);
      return _diContainer.InstantiatePrefab(card, position, Quaternion.identity, parent);
    }
  }
}