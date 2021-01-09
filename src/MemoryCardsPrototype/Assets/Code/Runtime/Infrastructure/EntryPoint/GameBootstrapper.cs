using UnityEngine;
using Zenject;

namespace Code.Runtime.Infrastructure.EntryPoint
{
  public class GameBootstrapper : MonoBehaviour
  {
    [Inject]
    private void BootGame(IGame game) =>
      game.Initialize();
  }
}