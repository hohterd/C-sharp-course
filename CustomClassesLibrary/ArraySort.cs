using System;
namespace CustomClassesLibrary
{
    public class ArraySort
    {

        public int[] GetReverseSortArray(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }

        public int[] GetMaxValueEachRow(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int[] result = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                int max = array[i, 0];
                for (int j = 0; j < columns; j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }
                }
                result[i] = max;
            }
            return result;
        }
    }
}
