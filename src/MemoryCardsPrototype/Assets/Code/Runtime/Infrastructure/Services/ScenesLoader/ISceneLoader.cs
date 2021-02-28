using System;

namespace Infrastructure.Services.ScenesLoader
{
  public interface ISceneLoader
  {
    void LoadScene(string sceneName, Action callback);
  }
}