namespace CardGame.Actors.Cards
{
  public interface ICard
  {
    int Id { get; set; }
    string Value { get; set; }
    bool IsMatched { get; set; }
  }
}