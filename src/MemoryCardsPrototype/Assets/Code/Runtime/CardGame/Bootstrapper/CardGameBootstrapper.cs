using CardGame.Factories;
using UnityEngine;
using Zenject;

namespace CardGame.Bootstrapper
{
  public class CardGameBootstrapper : MonoBehaviour
  {
    [Inject]
    private void Construct(ICardGameFactory cardGameFactory) =>
      cardGameFactory.Create();
  }
}