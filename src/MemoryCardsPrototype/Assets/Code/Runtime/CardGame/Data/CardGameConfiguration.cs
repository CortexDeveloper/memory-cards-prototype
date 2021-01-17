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

    [field: SerializeField] public float CellSize { get; private set; }

    [field: SerializeField] public float SessionTime { get; private set; }

#if UNITY_EDITOR
    private void OnValidate()
    {
      ValidateVerticalCellsCount();
      ValidateCellSize();
      ValidateSessionTime();
    }

    private void ValidateSessionTime()
    {
      if (SessionTime <= 0)
        SessionTime = 60f;
    }

    private void ValidateCellSize()
    {
      if (CellSize <= 0)
        CellSize = 1f;
    }

    private void ValidateVerticalCellsCount()
    {
      if (_verticalCellsCount % 2 != 0)
        _verticalCellsCount++;
    }
#endif
  }
}