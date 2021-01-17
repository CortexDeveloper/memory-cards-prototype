using UnityEngine;

namespace Code.Runtime.CardGame.Data
{
  [CreateAssetMenu(fileName = nameof(CardGameConfiguration), menuName = "CardGame/Data/" + nameof(CardGameConfiguration), order = 0)]
  public class CardGameConfiguration : ScriptableObject
  {
    [field: SerializeField] private int HorizontalCellsCount { get; }
    [field: SerializeField] private int VerticalCellsCount { get; }

    [field: SerializeField] private float SessionTime { get; }
  }
}