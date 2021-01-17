namespace Code.Runtime.CardGame.Data
{
  public interface ICardGameConfiguration
  {
    public int HorizontalCellsCount { get; }
    public int VerticalCellsCount { get; }
    public float SessionTime { get; }
  }
}