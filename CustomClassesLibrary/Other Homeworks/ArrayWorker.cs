using System;

namespace CustomClassesLibrary
{
    public class ArrayWorker
    {
        public int[] ReverseArray(params int[] array)
        {
            Array.Reverse(array);
            return array;
        }

        public int[] ExtendArray(int index, int newValue, params int[] source)
        {
            int[] newArray = new int[source.Length + 1];
            int iterator = 0;
            for (; iterator < index; iterator++)
            {
                newArray[iterator] = source[iterator];
            }
            newArray[iterator] = newValue;
            for (; iterator < source.Length; iterator++)
            {
                newArray[iterator + 1] = source[iterator];
            }
            return newArray;
        }
    }
}
