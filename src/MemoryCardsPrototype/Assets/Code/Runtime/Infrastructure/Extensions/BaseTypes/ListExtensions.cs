using System;
using System.Collections.Generic;
using System.Linq;

namespace Code.Runtime.Infrastructure.Extensions.BaseTypes
{
  public static class ListExtensions
  {
    public static List<List<T>> Shuffle<T>(this List<List<T>> lists)
    {
      for (var index = 0; index < lists.Count; index++)
        lists[index] = lists[index].Shuffle();

      return lists.OrderBy(a => Guid.NewGuid()).ToList();
    }
    
    public static List<T> Shuffle<T>(this List<T> list) =>
      list.OrderBy(a => Guid.NewGuid()).ToList();
  }
}