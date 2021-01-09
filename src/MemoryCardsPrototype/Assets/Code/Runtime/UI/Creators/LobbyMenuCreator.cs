using Code.Runtime.Infrastructure.Factories.UI;
using UnityEngine;
using Zenject;

namespace Code.Runtime.UI.Creators
{
  public class LobbyMenuCreator : MonoBehaviour, IUICreator<ILobbyMenuFactory>
  {
    [SerializeField] private Transform _uiHolder;

    [Inject]
    private void Construct(ILobbyMenuFactory lobbyMenuFactory) =>
      CreateUI(lobbyMenuFactory);

    public void CreateUI(ILobbyMenuFactory lobbyMenuFactory)
    {
      lobbyMenuFactory.Load();
            
      GameObject lobbyMenu = lobbyMenuFactory.Create(_uiHolder.transform.position, Quaternion.identity, _uiHolder);
    }
  }
}