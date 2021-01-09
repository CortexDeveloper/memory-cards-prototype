using Code.Runtime.Infrastructure.Extensions.BaseTypes;
using Code.Runtime.Infrastructure.Services.AudioPlayer;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Runtime.UI.Buttons
{
  public class SoundSwitchToggle : MonoBehaviour, IToggle
  {
    [Inject]
    private void Construct(IAudioPlayer audioPlayer) =>
      _audioPlayer = audioPlayer;
    
    private Toggle _toggle;

    private IAudioPlayer _audioPlayer;
    private bool _state = true;

    private void Awake() =>
      Configure();
    
    public void Configure()
    {
      _toggle = GetComponent<Toggle>();
      _toggle.onValueChanged.AddListener(Execute);
    }

    public void Execute(bool value)
    {
      _state = !_state;
      _audioPlayer.SetVolume(_state.AsInt());
    }
  }
}