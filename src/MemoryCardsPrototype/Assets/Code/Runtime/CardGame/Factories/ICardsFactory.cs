using UnityEngine;

namespace Code.Runtime.CardGame.Factories
{
  public interface ICardsFactory
  {
    GameObject Create(Transform parent, Vector3 position);
  }
}