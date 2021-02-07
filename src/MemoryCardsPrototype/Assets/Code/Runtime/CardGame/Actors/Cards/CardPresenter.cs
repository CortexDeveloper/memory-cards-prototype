using TMPro;
using UnityEngine;

namespace Code.Runtime.CardGame.Actors.Cards
{
  public class CardPresenter : MonoBehaviour
  {
    public Card Card = new Card();
    
    public TMP_Text TextValue;

    public void ShowValue() => 
      TextValue.text = Card.Value;

    public void ShowBackside(string backSide) =>
      TextValue.text = backSide;
  }
}