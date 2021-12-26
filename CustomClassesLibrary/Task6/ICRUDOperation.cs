namespace CustomClassesLibrary.Task6
{
    public interface ICRUDOperation<T>
    {
        public void Create(T item);
        public T Read(T item);
        public void Update(T item, T newItem);
        public void Delete(T item);
    }
}
