namespace Code.Runtime.CardGame.Actors.Cards
{
  public interface ICard
  {
    int Id { get; }
    string Value { get; }
    bool IsMatched { get; }
  }
}