using UnityEngine;

namespace Infrastructure.Services.AudioPlayer
{
  [RequireComponent(typeof(AudioSource))]
  public class AudioPlayer : MonoBehaviour, IAudioPlayer
  {
    private AudioSource _audioSource;
    private AudioSource AudioSource => 
      _audioSource ? _audioSource : (_audioSource = GetComponent<AudioSource>());

    public void Play(string path) =>
      AudioSource.PlayOneShot(Resources.Load<AudioClip>(path));

    public void SetVolume(float value) =>
      AudioListener.volume = value;
  }
}