using System;

namespace VoidMainAPI
{
    public sealed class List<T>
    {
        // Internal array of the List class
        private T[] array;
        // Count of the elements filled in the array
        private long count;

        // Default constructor
        public List()
        {
            array = new T[10];
        }

        // Initializes the internal array with a specified size
        public List(long size)
        {
            array = new T[size];
        }

        // Adds element at the end of the List
        public void Add(T element)
        {
            long lastIndex = count - 1;

            if (count >= array.Length)
                array = new T[array.Length + (int)(0.5 * array.Length)];

            array[lastIndex + 1] = element;
            ++count;
        }

        // Inserts element at a specified index
        public void Insert(long index, T element)
        {
            if (index > count - 1)
                throw new IndexOutOfRangeException($"Cannot insert element at index {index} into a List of size {count}");
            array[index] = element;
        }

        // Removes element at a specified index
        public void RemoveAt(long index)
        {
            if (count < 1)
                throw new IndexOutOfRangeException($"Cannot remove element at index {index} from a List of size {count}");

            for (long i = index; i < count; i++)
                array[i] = array[i + 1];

            --count;
        }
        
        // Returns the internal array
        public T[] ToArray()
        {
            return array;
        }
    }
}