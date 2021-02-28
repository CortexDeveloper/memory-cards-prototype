using Infrastructure.StateMachine;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace UI.Buttons
{
  [RequireComponent(typeof(Button))]
  public class StartSessionButton : MonoBehaviour, IButton
  {
    [Inject]
    private void Construct(IGameStateMachine gameStateMachine) =>
      _gameStateMachine = gameStateMachine;

    private Button _button;

    private IGameStateMachine _gameStateMachine;

    private void Awake() =>
      Configure();

    public void Configure()
    {
      _button = GetComponent<Button>();
      _button.onClick.AddListener(Execute);
    }

    public void Execute() =>
      _gameStateMachine.ChangeState(GameStates.Session);
  }
}