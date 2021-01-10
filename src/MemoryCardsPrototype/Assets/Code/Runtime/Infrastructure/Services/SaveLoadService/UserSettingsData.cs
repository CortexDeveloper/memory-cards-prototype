using System;

namespace Code.Runtime.Infrastructure.Services.SaveLoadService
{
  [Serializable]
  public class UserSettingsData
  {
    public UserSettingsData(bool soundState) =>
      SoundState = soundState;

    public bool SoundState;
  }
}