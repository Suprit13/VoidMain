using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace VoidMainAPI
{
    public sealed class List<T> : IEnumerable<T>, IEnumerator<T>
    {
        // Internal array of the List class
        private T[] array;
        // Count of the elements filled in the array
        private int count;

        private int currentIndex;

        // Return the count of the elements present in the List
        public int Count => count;
        // Return the length of the internal array
        public int ArrayLength => array.Length;

        T IEnumerator<T>.Current => Get(currentIndex);

        object IEnumerator.Current => Get(currentIndex)!;


        // Default constructor to initialize the internal array with a fixed size
        public List()
        {
            currentIndex = -1;
            array = new T[10];
        }

        // Initializes the internal array with a specified size
        public List(int size)
        {
            currentIndex = -1;
            array = new T[size];
        }

        // Initialize the iternal array with a pre-made array/list (Enumerable)
        public List(IEnumerable<T> list)
        {
            currentIndex = -1;

            if (list is T[] arr)
                array = arr;
            else
                array = list.ToArray();
        }

        // Indexer
        public T this[int index]
        {
            get => Get(index);
            set => Set(index, value);
        }

        // Get element from the List at specified index
        public T Get(int index)
        {
            if (count < 1)
                // Throw a runtime error if attempted to remove an element from an empty List
                throw new MissingFieldException($"Cannot access element at index '{index}' from a List of size '{count}'");
            else if (count <= index)
                // Throw a runtime error if attempted to remove an element from outside the List boundary
                throw new IndexOutOfRangeException($"Cannot access element at index '{index}' from a List of size '{count}'");
            else if (index < 0)
                // Throw a runtime error if attempted to remove an element from outside the List boundary
                throw new IndexOutOfRangeException($"Cannot access element at index '{index}' from a List of starting index '0'");

            return array[index];
        }

        // Set the element at specified index in the List
        public void Set(int index, T element) => Insert(index, element);

        // Adds element at the end of the List
        public void Add(T element)
        {
            // Resizing the array
            if (count == array.Length)
            {
                T[] newArray = new T[array.Length + (int)(0.5 * array.Length)];
                Array.Copy(array, newArray, count);
                array = newArray;
            }
                
            array[count] = element;
            ++count;
        }

        // Inserts element at a specified index
        public void Insert(int index, T element)
        {
            if (index > count - 1)
                // Throw a runtime error if attempted to insert an element at the outside of the List boundary
                throw new IndexOutOfRangeException($"Cannot insert element at index '{index}' into a List of size '{count}'");
            else if (index < 0)
                // Throw a runtime error if attempted to insert an element at the outside of the List boundary
                throw new IndexOutOfRangeException($"Cannot insert element at index '{index}' into a List of starting index '0'");

            array[index] = element;
        }

        // Removes element at a specified index
        public void RemoveAt(int index)
        {
            if (count < 1)
                // Throw a runtime error if attempted to remove an element from an empty List
                throw new MissingFieldException($"Cannot remove element at index '{index}' from a List of size '{count}'");
            else if (count <= index)
                // Throw a runtime error if attempted to remove an element from outside the List boundary
                throw new IndexOutOfRangeException($"Cannot remove element at index '{index}' from a List of size '{count}'");
            else if (index < 0)
                // Throw a runtime error if attempted to remove an element from outside the List boundary
                throw new IndexOutOfRangeException($"Cannot remove element at index '{index}' from a List of starting index '0'");

            // Resizing the array
            if (count < array.Length / 2)
            {
                T[] newArray = new T[array.Length - (int)(0.25 * array.Length)];
                Array.Copy(array, newArray, count);
                array = newArray;
            }

            for (int i = index; i < count; i++)
                array[i] = array[i + 1];

            --count;
        }

        // Sort the list of primitive Types
        public void Sort()
        {
            if (count < 1)
                // Throw a runtime error if attempted to sort an empty List
                throw new MissingFieldException($"Cannot sort a List of size '{count}'");

            Sort(array);
        }

        // The most "what the fuck?" Method because there's no way to tell the compiler that they can be compared.
        private void Sort(T[] array)
        {
            try
            {
                // Bubble sort
                // TODO: Change the sorting algorithm into a much faster sort based on the elements count

                bool changed;

                for (int i = 1; i < count; i++)
                {
                    changed = false;

                    for (int j = 0; j < count - i; j++)
                        if (Comparer<T>.Default.Compare(array[j], array[j + 1]) > 0)
                            Swap(ref changed, j);

                    if (!changed)
                        return;
                }
            }
            catch
            {
                throw new NotSupportedException($"Cannot sort a List of type '{typeof(T)}'");
            }

            // Local function to separate the swap logic
            void Swap(ref bool changed, in int index)
            {
                changed = true;
                // Using Tuple to swap values of the array
                (array[index + 1], array[index]) = (array[index], array[index + 1]);
            }
        }

        // Return the index if found or return 0
        public int Search(T data)
        {
            T[] array;

            if (count == this.array.Length)
                array = this.array;
            else
            {
                array = new T[count];
                Array.Copy(this.array, array, count);
            }

            return Search(array, data);
        }

        // Return the index if found or return 0
        public int Find(T data)
        {
            T[] array;

            if (count == this.array.Length)
                array = this.array;
            else
            {
                array = new T[count];
                Array.Copy(this.array, array, count);
            }

            return Find(array, data);
        }

        // Linear search
        private static int Find(T[] array, T data)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i]!.Equals(data))
                    return i;

            return -1;
        }

        // BinarySearch 
        private static int Search(T[] array, T data)
        {
            int max = array.Length - 1;
            int min = 0;
            int targetIndex;

            while (max >= min)
            {
                targetIndex = min + ((max - min) / 2);
                T target = array[targetIndex];
                int comparisonResult = Comparer<T>.Default.Compare(target, data);

                if (comparisonResult == 0)
                    return targetIndex;
                else if (comparisonResult < 0)
                    min = targetIndex + 1;
                else
                    max = targetIndex - 1;
            }

            return -1;
        }

        // Returns the internal array
        public T[] ToArray()
        {
            if (count == array.Length)
                return array;
            else
            {
                T[] newArray = new T[count];
                Array.Copy(array, newArray, count);

                return newArray;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator() => this;

        IEnumerator IEnumerable.GetEnumerator() => this;
        bool IEnumerator.MoveNext()
        {
            ++currentIndex;
            return currentIndex < count;
        }

        void IEnumerator.Reset() => currentIndex = -1;

        void IDisposable.Dispose() => currentIndex = -1;
    }
}