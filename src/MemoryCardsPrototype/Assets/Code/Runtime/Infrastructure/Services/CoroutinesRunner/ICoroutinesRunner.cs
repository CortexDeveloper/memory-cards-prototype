using System.Collections;

namespace Code.Runtime.Infrastructure.Services.CoroutinesRunner
{
  public interface ICoroutinesRunner
  {
    void RunCoroutine(IEnumerator coroutine);
  }
}