using Newtonsoft.Json;
using UnityEngine;

namespace Code.Runtime.Infrastructure.Services.SaveLoadService
{
  public class UserSettingsStorage : ISaveLoadService<UserSettingsData>
  {
    private const string UserSettingDataKey = "save_UserSettingData";
    private const string DefaultUserSettingsData = "{\"SoundState\":true}";

    public UserSettingsData LoadedData { get; private set; }

    public UserSettingsData Load()
    {
      UserSettingsData userSettingsData = 
        JsonConvert.DeserializeObject<UserSettingsData>(PlayerPrefs.GetString(UserSettingDataKey, DefaultUserSettingsData));

      LoadedData = userSettingsData;
      
      return LoadedData;
    }

    public void Save(UserSettingsData data)
    {
      string json = JsonConvert.SerializeObject(data);
      PlayerPrefs.SetString(UserSettingDataKey, json);
    }
  }
}