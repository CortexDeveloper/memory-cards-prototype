using Infrastructure.Services.SaveLoadService;
using Newtonsoft.Json;
using UnityEditor;
using UnityEngine;

namespace Editor.SaveLoadTools
{
  public class UserSettingsDataSerializer : EditorWindow
  {
    public UserSettingsData UserSettingsData = new UserSettingsData(true);
  
    private Vector2 _scroll;
    private string _serializedData;

    [MenuItem("Tools/User Settings Data Serializer")]
    private static void Init()
    {
      UserSettingsDataSerializer window = (UserSettingsDataSerializer)GetWindow(typeof(UserSettingsDataSerializer));
      window.Show();
    }
  
    private void OnGUI()
    {
      GUILayout.Label("User Settings Data", EditorStyles.boldLabel);
      UserSettingsData.SoundState = EditorGUILayout.Toggle("Sound State", UserSettingsData.SoundState);
      
      GUILayout.Label($"PlayerPrefs: Sound State = {PlayerPrefs.GetString("save_UserSettingData")}", EditorStyles.boldLabel);
    
      if (GUILayout.Button("Serialize")) 
        _serializedData = JsonConvert.SerializeObject(UserSettingsData);
    
      _scroll = EditorGUILayout.BeginScrollView(_scroll);
      _serializedData = EditorGUILayout.TextArea(_serializedData, GUILayout.Height(position.height - 250f));
      EditorGUILayout.EndScrollView();
    }
  }
}
