using System;

namespace VoidMainAPI
{
    public sealed class List<T>
    {
        private T[] arr;
        private int c;

        List()
        {
            arr = new T[10];
        }

        public void Add(T element)
        {
            int lastIndex;

            foreach (var _ in arr)
                c++;

            lastIndex = c - 1;

            if (c == arr.Length)
                arr = new T[arr.Length + 5];

            arr[lastIndex + 1] = element;
        }

        public void Insert(int index, T element) => arr[index] = element;

        public void RemoveAt(int index)
        {
            foreach (var _ in arr)
                c++;

            for (int i = index; i < c; i++)
                arr[i] = arr[i + 1];
        }
        
        public T[] ToArray()
        {
            return arr;
        }
    }
}