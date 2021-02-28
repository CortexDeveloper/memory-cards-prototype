using Infrastructure.Extensions.BaseTypes;
using Infrastructure.Services.AudioPlayer;
using Infrastructure.Services.SaveLoadService;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace UI.Buttons
{
  public class SoundSwitchToggle : MonoBehaviour, IToggle
  {
    [Inject]
    private void Construct(IAudioPlayer audioPlayer, ISaveLoadService<UserSettingsData> saveLoadService)
    {
      _audioPlayer = audioPlayer;
      _saveLoadService = saveLoadService;
    }

    private Toggle _toggle;

    private IAudioPlayer _audioPlayer;
    private ISaveLoadService<UserSettingsData> _saveLoadService;
    private bool _state = true;

    private void Awake() =>
      Configure();

    public void Configure()
    {
      _toggle = GetComponent<Toggle>();
      
      LoadState();
      
      _toggle.onValueChanged.AddListener(Execute);

    }

    public void Execute(bool value)
    {
      _state = !_state;
      _audioPlayer.SetVolume(_state.AsInt());
      
      SaveState();
    }
    
    private void LoadState()
    {
      _state = _saveLoadService.LoadedData.SoundState;
      _toggle.isOn = _state;
      _audioPlayer.SetVolume(_state.AsInt());
    }

    private void SaveState() =>
      _saveLoadService.Save(new UserSettingsData(_state));
  }
}