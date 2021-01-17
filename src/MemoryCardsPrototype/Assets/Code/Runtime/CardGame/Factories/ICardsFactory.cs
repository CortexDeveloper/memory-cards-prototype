using UnityEngine;

namespace Code.Runtime.CardGame.Factories
{
  public interface ICardsFactory
  {
    void Create(Transform parent, Vector3 position);
  }
}