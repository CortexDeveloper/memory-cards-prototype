using System;
using System.Collections;
using Infrastructure.Services.CoroutinesRunner;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Infrastructure.Services.ScenesLoader
{
  public class ScenesLoader : ISceneLoader
  {
    private readonly ICoroutinesRunner _coroutinesRunner;
    
    public ScenesLoader(ICoroutinesRunner coroutinesRunner) =>
      _coroutinesRunner = coroutinesRunner;

    public void LoadScene(string sceneName, Action callback) =>
      _coroutinesRunner.RunCoroutine(LoadYourAsyncScene(sceneName, callback));

    private IEnumerator LoadYourAsyncScene(string sceneName, Action callback)
    {
      AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);
      
      while (!asyncLoad.isDone)
      {
        yield return null;
      }
      
      callback?.Invoke();
    }
  }
}