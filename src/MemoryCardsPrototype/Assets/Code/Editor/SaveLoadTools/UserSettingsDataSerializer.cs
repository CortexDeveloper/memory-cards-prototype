using Code.Runtime.Infrastructure.Services.SaveLoadService;
using Newtonsoft.Json;
using UnityEditor;
using UnityEngine;

namespace Code.Editor.SaveLoadTools
{
  public class UserSettingsDataSerializer : EditorWindow
  {
    public UserSettingsData UserSettingsData = new UserSettingsData();
  
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
    
      if (GUILayout.Button("Serialize")) 
        _serializedData = JsonConvert.SerializeObject(UserSettingsData);
    
      _scroll = EditorGUILayout.BeginScrollView(_scroll);
      _serializedData = EditorGUILayout.TextArea(_serializedData, GUILayout.Height(position.height));
      EditorGUILayout.EndScrollView();
    }
  }
}
