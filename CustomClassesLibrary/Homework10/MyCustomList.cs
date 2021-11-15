using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomClassesLibrary.Homework10
{
    public class MyCustomList : IList<MyCustomItem>
    {
        readonly IList<MyCustomItem> myList = new List<MyCustomItem>();

        public MyCustomItem this[int index] { get => myList[index]; set => myList[index] = value; }

        public int Count => myList.Count;

        public bool IsReadOnly => myList.IsReadOnly;

        public void Add(MyCustomItem item)
        {
            myList.Add(item);
        }

        public void Clear()
        {
            myList.Clear();
        }

        public bool Contains(MyCustomItem item)
        {
            return myList.Contains(item);
        }

        public void CopyTo(MyCustomItem[] array, int arrayIndex)
        {
            myList.CopyTo(array, arrayIndex);
        }

        public int IndexOf(MyCustomItem item)
        {
            return myList.IndexOf(item);
        }

        public void Insert(int index, MyCustomItem item)
        {
            myList.Insert(index, item);
        }

        public bool Remove(MyCustomItem item)
        {
            return myList.Remove(item);
        }

        public void RemoveAt(int index)
        {
            myList.RemoveAt(index);
        }

        public IEnumerator<MyCustomItem> GetEnumerator()
        {
            return myList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)myList).GetEnumerator();
        }
    }
}
