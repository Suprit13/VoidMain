using System;
using System.Collections.Generic;

namespace VoidMainAPI
{
    public sealed class List<T>
    {
        // Internal array of the List class
        private T[] array;
        // Count of the elements filled in the array
        private long count;
        
        // Return the count of the elements present in the List
        public long Count => count;
        // Return the length of the internal array
        public long ArrayLength => array.Length;

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
                array = new T[array.Length + (long)(0.5 * array.Length)];

            array[lastIndex + 1] = element;
            ++count;
        }

        // Inserts element at a specified index
        public void Insert(long index, T element)
        {
            if (index > count - 1)
                // // Throw a runtime error if attempted to insert an element at the outside of the List boundary
                throw new IndexOutOfRangeException($"Cannot insert element at index '{index}' into a List of size '{count}'");

            array[index] = element;
        }

        // Removes element at a specified index
        public void RemoveAt(long index)
        {
            if (count < 1)
                // Throw a runtime error if attempted to remove an element from an empty List
                throw new MissingFieldException($"Cannot remove element at index '{index}' from a List of size '{count}'");
            else if (count <= index)
                // Throw a runtime error if attempted to remove an element from outside the List boundary
                throw new MissingFieldException($"Cannot remove element at index '{index}' from a List of size '{count}'");

            for (long i = index; i < count; i++)
                array[i] = array[i + 1];

            --count;
        }

        // Sort the list of primitive Types
        public void Sort()
        {
            if (count < 1)
                // Throw a runtime error if attempted to sort an empty List
                throw new MissingFieldException($"Cannot sort a List of size '{count}'");

            Sort((dynamic)array);
        }

        // The most "what the fuck?" Method because there's no way to tell the compiler that they can be compared.
        private void Sort(dynamic[] array)
        {
            try
            {
                if (array is string[])
                {
                    // Bubble sort
                    // TODO: Change the sorting algorith into a much faster sort based on the elements count

                    bool changed;

                    for (long i = 1; i < count - 1; i++)
                    {
                        changed = false;

                        for (long j = 0; j < count - i; j++)
                            if (array[j].CompareTo(array[j + 1]) > 0)
                                Swap(ref changed, j);

                        if (!changed)
                            return;
                    }
                }
                else
                {
                    // Bubble sort
                    // TODO: Change the sorting algorith into a much faster sort based on the elements count

                    bool changed;

                    for (long i = 1; i < count - 1; i++)
                    {
                        changed = false;

                        for (long j = 0; j < count - i; j++)
                            if (array[j] > array[j + 1])
                                Swap(ref changed, j);

                        if (!changed)
                            return;
                    }
                }
            }
            catch
            {
                // Throw a runtime error if the Type is not one of the primitive types
                throw new NotSupportedException($"Cannot sort a List of type '{typeof(T)}'");
            }

            // Local function to seperate the swap logic
            void Swap(ref bool changed, in long j)
            {
                changed = true;
                // Using Tuple to swap values of the array
                (array[j + 1], array[j]) = (array[j], array[j + 1]);
            }
        }

        // Returns the internal array
        public T[] ToArray()
        {
            return array;
        }
    }
}