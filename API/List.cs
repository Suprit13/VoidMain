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

            Sort(array);
        }

        // The most "what the fuck?" Method because there's no way to tell the compiler that they can be compared.
        private void Sort(T[] array)
        {

            if (array is int[] arr)
            {
                bool changed;

                for (long i = 1; i < count - 1; i++)
                {
                    changed = false;

                    for (long j = 0; j < count - i; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            changed = true;
                            // Using Tuple to swap values of the array
                            (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
                        }
                    }

                    if (!changed)
                        return;
                }
            }
            else if (array is short[] arrS)
            {
                bool changed;

                for (long i = 1; i < count - 1; i++)
                {
                    changed = false;

                    for (long j = 0; j < count - i; j++)
                    {
                        if (arrS[j] > arrS[j + 1])
                        {
                            changed = true;
                            // Using Tuple to swap values of the array
                            (arrS[j + 1], arrS[j]) = (arrS[j], arrS[j + 1]);
                        }
                    }

                    if (!changed)
                        return;
                }
            }
            else if (array is byte[] arrB)
            {
                bool changed;

                for (long i = 1; i < count - 1; i++)
                {
                    changed = false;

                    for (long j = 0; j < count - i; j++)
                    {
                        if (arrB[j] > arrB[j + 1])
                        {
                            changed = true;
                            // Using Tuple to swap values of the array
                            (arrB[j + 1], arrB[j]) = (arrB[j], arrB[j + 1]);
                        }
                    }

                    if (!changed)
                        return;
                }
            }
            else if (array is char[] arrC)
            {
                bool changed;

                for (long i = 1; i < count - 1; i++)
                {
                    changed = false;

                    for (long j = 0; j < count - i; j++)
                    {
                        if (arrC[j] > arrC[j + 1])
                        {
                            changed = true;
                            // Using Tuple to swap values of the array
                            (arrC[j + 1], arrC[j]) = (arrC[j], arrC[j + 1]);
                        }
                    }

                    if (!changed)
                        return;
                }
            }
            else if (array is long[] arrL)
            {
                bool changed;

                for (long i = 1; i < count - 1; i++)
                {
                    changed = false;

                    for (long j = 0; j < count - i; j++)
                    {
                        if (arrL[j] > arrL[j + 1])
                        {
                            changed = true;
                            // Using Tuple to swap values of the array
                            (arrL[j + 1], arrL[j]) = (arrL[j], arrL[j + 1]);
                        }
                    }

                    if (!changed)
                        return;
                }
            }
            else if (array is float[] arrF)
            {
                bool changed;

                for (long i = 1; i < count - 1; i++)
                {
                    changed = false;

                    for (long j = 0; j < count - i; j++)
                    {
                        if (arrF[j] > arrF[j + 1])
                        {
                            changed = true;
                            // Using Tuple to swap values of the array
                            (arrF[j + 1], arrF[j]) = (arrF[j], arrF[j + 1]);
                        }
                    }

                    if (!changed)
                        return;
                }
            }
            else if (array is double[] arrD)
            {
                bool changed;

                for (long i = 1; i < count - 1; i++)
                {
                    changed = false;

                    for (long j = 0; j < count - i; j++)
                    {
                        if (arrD[j] > arrD[j + 1])
                        {
                            changed = true;
                            // Using Tuple to swap values of the array
                            (arrD[j + 1], arrD[j]) = (arrD[j], arrD[j + 1]);
                        }
                    }

                    if (!changed)
                        return;
                }
            }
            else if (array is decimal[] arrDe)
            {
                bool changed;

                for (long i = 1; i < count - 1; i++)
                {
                    changed = false;

                    for (long j = 0; j < count - i; j++)
                    {
                        if (arrDe[j] > arrDe[j + 1])
                        {
                            changed = true;
                            // Using Tuple to swap values of the array
                            (arrDe[j + 1], arrDe[j]) = (arrDe[j], arrDe[j + 1]);
                        }
                    }

                    if (!changed)
                        return;
                }
            }
            else if (array is string[] arrStr)
            {
                bool changed;

                for (long i = 1; i < count - 1; i++)
                {
                    changed = false;

                    for (long j = 0; j < count - i; j++)
                    {
                        if (arrStr[j].CompareTo(arrStr[j + 1]) > 0)
                        {
                            changed = true;
                            // Using Tuple to swap values of the array
                            (arrStr[j + 1], arrStr[j]) = (arrStr[j], arrStr[j + 1]);
                        }
                    }

                    if (!changed)
                        return;
                }
            }
            else
                // Throw a runtime error if the Type is not one of the primitive types
                throw new NotSupportedException($"Cannot sort a List of type '{typeof(T)}'");
        }

        // Returns the internal array
        public T[] ToArray()
        {
            return array;
        }
    }
}