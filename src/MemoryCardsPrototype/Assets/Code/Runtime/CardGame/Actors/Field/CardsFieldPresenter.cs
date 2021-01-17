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

    public void SpawnCards(CardsMatrix matrix)
    {
      Vector3 currentCardPosition = Root.transform.localPosition;

      for (int row = 0; row < matrix.Matrix.Count; row++)
      {
        for (int columns = 0; columns < matrix.Matrix[0].Count; columns++)
        {
          _cardsFactory.Create(Root, currentCardPosition);
          
          currentCardPosition.x += _configuration.CellSize;
        }
        
        currentCardPosition.x = Root.localPosition.x;
        currentCardPosition.y += _configuration.CellSize;
      }
    }
  }
}