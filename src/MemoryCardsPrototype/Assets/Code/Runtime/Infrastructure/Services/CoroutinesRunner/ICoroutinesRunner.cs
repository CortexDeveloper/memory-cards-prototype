using System.Collections;

namespace Infrastructure.Services.CoroutinesRunner
{
  public interface ICoroutinesRunner
  {
    void RunCoroutine(IEnumerator coroutine);
  }
}