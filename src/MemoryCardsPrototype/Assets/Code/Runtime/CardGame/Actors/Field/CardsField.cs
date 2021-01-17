using Code.Runtime.CardGame.Data;
using UnityEngine;
using Zenject;

namespace Code.Runtime.CardGame.Actors.Field
{
  public class CardsField : MonoBehaviour
  {
    [Inject]
    public void Construct(ICardGameConfiguration configuration)
    {
      _configuration = configuration;

      _sessionTime = _configuration.SessionTime;
      _cardsMatrix = new CardsMatrix(_configuration.HorizontalCellsCount, _configuration.VerticalCellsCount);
    }

    private ICardGameConfiguration _configuration;
    
    private CardsMatrix _cardsMatrix;
    private float _sessionTime;
    
    
  }
}