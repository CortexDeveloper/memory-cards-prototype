using UnityEngine;

namespace Code.Runtime.CardGame.Actors.Cards
{
  [System.Serializable]
  public class Card : ICard
  {
    [field: SerializeField] public string Id { get; private set; }
    [field: SerializeField] public bool IsMatched{ get; private set; }
  }
}