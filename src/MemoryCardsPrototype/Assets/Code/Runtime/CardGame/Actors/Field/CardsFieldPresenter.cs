using Code.Runtime.CardGame.Actors.Cards;
using Code.Runtime.CardGame.Data;
using Code.Runtime.CardGame.Factories;
using UnityEngine;
using Zenject;

namespace Code.Runtime.CardGame.Actors.Field
{
  [RequireComponent(typeof(CardsField))]
  public class CardsFieldPresenter : MonoBehaviour
  {
    [SerializeField] private Transform cardsParent;
    [SerializeField] private Transform cardsSpawnStartPoint;
    
    [Inject]
    private void Construct(ICardGameConfiguration configuration, ICardsFactory cardsFactory)
    {
      _configuration = configuration;
      _cardsFactory = cardsFactory;
    }

    private ICardsFactory _cardsFactory;
    private ICardGameConfiguration _configuration;

    public void SpawnCards(CardsMatrix cardsMatrix)
    {
      Vector3 currentCardPosition = cardsSpawnStartPoint.transform.position;
      for (int row = 0; row < cardsMatrix.Matrix.Count; row++)
      {
        for (int column = 0; column < cardsMatrix.Matrix[0].Count; column++)
        {
          CardPresenter cardPresenter = _cardsFactory.Create(cardsParent, currentCardPosition).GetComponent<CardPresenter>();
          SetupCardPresenter(cardsMatrix, cardPresenter, row, column);

          currentCardPosition.x += _configuration.CellSize;
        }
        
        currentCardPosition.x = cardsSpawnStartPoint.position.x;
        currentCardPosition.y += _configuration.CellSize;
      }
    }

    private static void SetupCardPresenter(CardsMatrix cardsMatrix, CardPresenter cardPresenter, int row, int column)
    {
      cardPresenter.Card.Id = cardsMatrix.Matrix[row][column].Id;
      cardPresenter.Card.Value = cardsMatrix.Matrix[row][column].Value;
      cardPresenter.ShowBackside("*");
      cardPresenter.name = cardPresenter.name.Replace("(Clone)", $"[{row}][{column}]");
    }
  }
}