using System;

namespace Infrastructure.Services.SaveLoadService
{
  [Serializable]
  public class UserSettingsData
  {
    public UserSettingsData(bool soundState) =>
      SoundState = soundState;

    public bool SoundState;
  }
}