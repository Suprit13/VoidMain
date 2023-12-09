using System;
using System.Text;

namespace VoidMainAPI
{
  internal sealed class List<T>
  {
    T[] arr;
    int c;
    
    List()
    {
      arr = new T[10];
    }
    
    void Add(T element)
    {
      int lastIndex;
      foreach(T var in arr)
        c++;
      lastIndex = c - 1;
      if(c == arr.Length)
        arr = new T[arr.Length + 5];
      
      arr[lastIndex + 1] = element;
    }
    
    void Insert(int index, T element)
    {
      arr[index] = element;
    }
    
    void Pop(int index)
    {
      foreach(T var in arr)
        c++;
      for(int i = index; i < c; i++)
      {
        arr[i] = arr[i + 1];
      }
    }
  }
}