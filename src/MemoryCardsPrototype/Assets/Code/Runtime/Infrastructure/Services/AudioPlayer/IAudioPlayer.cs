namespace Code.Runtime.Infrastructure.Services.AudioPlayer
{
  public interface IAudioPlayer
  {
    void Play(string path);
    void SetVolume(float value);
  }
}