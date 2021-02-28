using UnityEngine;
using Zenject;

namespace Infrastructure.EntryPoint
{
  public class GameBootstrapper : MonoBehaviour
  {
    [Inject]
    private void BootGame(IGame game) =>
      game.Initialize();
  }
}