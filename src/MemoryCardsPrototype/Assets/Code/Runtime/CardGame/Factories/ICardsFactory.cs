using UnityEngine;

namespace CardGame.Factories
{
  public interface ICardsFactory
  {
    GameObject Create(Transform parent, Vector3 position);
  }
}