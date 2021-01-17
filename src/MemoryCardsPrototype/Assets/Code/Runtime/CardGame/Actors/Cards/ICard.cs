namespace Code.Runtime.CardGame.Actors.Cards
{
  public interface ICard
  {
    string Id { get; }
    bool IsMatched { get; }
  }
}