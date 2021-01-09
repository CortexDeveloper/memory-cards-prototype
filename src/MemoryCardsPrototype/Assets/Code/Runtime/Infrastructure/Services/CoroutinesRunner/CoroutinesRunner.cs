using System.Collections;
using UnityEngine;

namespace Code.Runtime.Infrastructure.Services.CoroutinesRunner
{
  public class CoroutinesRunner : MonoBehaviour, ICoroutinesRunner
  {
    public void RunCoroutine(IEnumerator coroutine) =>
      StartCoroutine(coroutine);
  }
}