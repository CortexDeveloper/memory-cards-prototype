using System.Collections.Generic;
using Code.Runtime.CardGame.Actors.Cards;

namespace Code.Runtime.CardGame.Actors.Field
{
  public class CardsMatrix
  {
    public CardsMatrix(int horizontalSize, int verticalSize)
    {
      Matrix = new List<List<Card>>(verticalSize);
      foreach (var row in Matrix)
        Matrix.Add(new List<Card>(horizontalSize));
    }

    public readonly List<List<Card>> Matrix;
  }
}