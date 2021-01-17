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
    [SerializeField] private Transform Root;
    
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
      Vector3 currentCardPosition = Root.transform.localPosition;
      for (int row = 0; row < cardsMatrix.Matrix.Count; row++)
      {
        for (int columns = 0; columns < cardsMatrix.Matrix[0].Count; columns++)
        {
          CardPresenter cardPresenter = _cardsFactory.Create(Root, currentCardPosition).GetComponent<CardPresenter>();
          SetupCardPresenter(cardsMatrix, cardPresenter, row, columns);

          currentCardPosition.x += _configuration.CellSize;
        }
        
        currentCardPosition.x = Root.localPosition.x;
        currentCardPosition.y += _configuration.CellSize;
      }
    }

    private static void SetupCardPresenter(CardsMatrix cardsMatrix, CardPresenter cardPresenter, int row, int columns)
    {
      cardPresenter.Card.Id = cardsMatrix.Matrix[row][columns].Id;
      cardPresenter.Card.Value = cardsMatrix.Matrix[row][columns].Value;
    }
  }
}