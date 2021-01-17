using System;
using System.Collections.Generic;
using System.Linq;

namespace Code.Runtime.Infrastructure.Extensions.BaseTypes
{
  public static class ListExtensions
  {
    public static void Shuffle<T>(this List<List<T>> list, Random random)
    {
      T[][] array = list.Select(a => a.ToArray()).ToArray();
      
      int lengthRow = array.GetLength(1);
      for (int i = array.Length - 1; i > 0; i--)
      {
        int i0 = i / lengthRow;
        int i1 = i % lengthRow;

        int j = random.Next(i + 1);
        int j0 = j / lengthRow;
        int j1 = j % lengthRow;

        T temp = array[i0][i1];
        array[i0][i1] = array[j0][j1];
        array[j0][j1] = temp;
      }
    }
  }
}