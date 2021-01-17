using UnityEngine;

namespace Code.Runtime.CardGame.Data
{
  [CreateAssetMenu(fileName = nameof(CardGameConfiguration), menuName = "CardGame/Data/" + nameof(CardGameConfiguration), order = 0)]
  public class CardGameConfiguration : ScriptableObject, ICardGameConfiguration
  {
    [SerializeField] private int _horizontalCellsCount;
    public int HorizontalCellsCount => 
      _horizontalCellsCount;
    
    [Tooltip("Vertical cells count must be even number")]
    [SerializeField] private int _verticalCellsCount;
    public int VerticalCellsCount => 
      _verticalCellsCount % 2 == 0 
        ? _verticalCellsCount 
        : ++_verticalCellsCount;

    [field: SerializeField] public float SessionTime { get; private set; }

#if UNITY_EDITOR
    private void OnValidate() =>
      ValidateVerticalCellsCount();

    private void ValidateVerticalCellsCount()
    {
      if (_verticalCellsCount % 2 != 0)
        _verticalCellsCount++;
    }
#endif
  }
}