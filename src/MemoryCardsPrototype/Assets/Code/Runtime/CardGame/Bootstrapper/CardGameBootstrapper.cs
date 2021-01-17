using Code.Runtime.CardGame.Factories;
using UnityEngine;
using Zenject;

namespace Code.Runtime.CardGame.Bootstrapper
{
  public class CardGameBootstrapper : MonoBehaviour
  {
    [Inject]
    private void Construct(ICardGameFactory cardGameFactory) =>
      cardGameFactory.Create();
  }
}