namespace CustomClassesLibrary.Task6
{
    public interface ISaveRead<T>
    {
        public void SaveItem(T item);
        public T ReadItem(T item);
    }
}

