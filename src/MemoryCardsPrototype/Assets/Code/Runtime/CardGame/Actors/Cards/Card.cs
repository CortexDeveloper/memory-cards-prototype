using UnityEngine;

namespace Code.Runtime.CardGame.Actors.Cards
{
  [System.Serializable]
  public class Card : ICard
  {
    [field: SerializeField] public int Id { get; set; }
    [field: SerializeField] public string Value { get; set; }
    [field: SerializeField] public bool IsMatched{ get; set; }
  }
}