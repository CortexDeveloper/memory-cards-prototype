using UnityEngine;
using Zenject;

namespace Code.Runtime.CardGame.Factories
{
  public class CardsFactory : ICardsFactory
  {
    public CardsFactory(DiContainer diContainer) =>
      _diContainer = diContainer;

    private readonly DiContainer _diContainer;
    
    public void Create(Transform parent, Vector3 position)
    {
      GameObject card = Resources.Load<GameObject>(CardGamePaths.CardPrefab);
      _diContainer.InstantiatePrefab(card, position, Quaternion.identity, parent);
    }
  }
}