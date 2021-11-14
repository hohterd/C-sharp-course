using System;

namespace CustomClassesLibrary.Homework9
{
    public class MyCollection<T>
    {
        private T[] Collection { get; set; }
        public  T[] GetCollection { get {return Collection;}}

        public MyCollection()
        {
            Collection = new T[4];
        }

        private void CapacityExtend()
        {
            var newArray = new T[Collection.Length * 2];
            Collection.CopyTo(newArray, 0);
            Collection = newArray;
        }



        public void InsertItem(T item)
        {

            int index = 0;
            try
            {
                while (true)
                {
                    if (Collection[index] == null)
                    {
                        Collection[index] = item;
                        Console.WriteLine($"{item} add to Collection");
                        break;
                    }
                    else ++index;
                }
            }
            catch (IndexOutOfRangeException)
            {
                CapacityExtend();
                InsertItem(item);
            }

        }

        public T TryToPeak(int index)
        {
            try
            {
                if (Collection[index] != null)
                {
                    return Collection[index];
                }
                else return default(T);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"{ex.Message}");
                return default(T);
            }
        }


    }




}

