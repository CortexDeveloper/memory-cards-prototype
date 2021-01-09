using System;

namespace Code.Runtime.Infrastructure.Services.ScenesLoader
{
  public interface ISceneLoader
  {
    void LoadScene(string sceneName, Action callback);
  }
}