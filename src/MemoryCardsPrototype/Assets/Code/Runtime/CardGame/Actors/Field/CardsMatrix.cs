using System;
using System.Collections.Generic;
using Code.Runtime.CardGame.Actors.Cards;
using Code.Runtime.Infrastructure.Extensions.BaseTypes;

namespace Code.Runtime.CardGame.Actors.Field
{
  public class CardsMatrix
  {
    public CardsMatrix(int horizontalSize, int verticalSize)
    {
      Matrix = new List<List<Card>>(verticalSize);
      foreach (List<Card> row in Matrix)
      {
        List<Card> rowCards = new List<Card>(horizontalSize);
        for (int rowCardIndex = 0; rowCardIndex < horizontalSize; horizontalSize++)
          rowCards.Add(new Card());

        Matrix.Add(rowCards);
      }
    }

    public readonly List<List<Card>> Matrix;
    
    public int UniqueCardsCount => 
      Matrix.Count * Matrix[0].Count / 2;

    public void GenerateMatrix()
    {
      SetCardsIds();
      SetCardsValues();
      ShuffleCards();
    }

    private void SetCardsIds()
    {
      int currentCardId = default;

      foreach (List<Card> row in Matrix)
      {
        foreach (Card cell in Matrix[Matrix.IndexOf(row)])
        {
          cell.Id = currentCardId;
          currentCardId++;
        }
      }
    }

    private void SetCardsValues()
    {
      int currentCardValue = UniqueCardsCount;
      
      for (int row = 0; row < Matrix.Count; row += 2)
      {
        for (int column = 0; column < Matrix[0].Count; column++)
        {
          Matrix[row][column].Value = currentCardValue.ToString();
          Matrix[row + 1][column].Value = currentCardValue.ToString();

          currentCardValue--;
        }
      }
    }

    private void ShuffleCards() =>
      Matrix.Shuffle<Card>(new Random());
  }
}