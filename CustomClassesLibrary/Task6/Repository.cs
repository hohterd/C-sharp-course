using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomClassesLibrary.Task6
{
    public class Repository<T> : ICRUDOperation<T>, ISaveRead<T>
    {
        public List<T> Users { get; set; } = new List<T>();

        public void Create(T item)
        {
            if (item is null)
            {
                throw new ArgumentNullException(nameof(item), $"item {item} doesn't exist");
            }
            else SaveItem(item);
        }

        public T Read(T item)
        {
            if (Users.Contains(item))
            {
                return ReadItem(item);
            }
            else if (item is null)
            {
                throw new ArgumentNullException(nameof(item), $"item {item} doesn't exist");
            }
            else
            {
                throw new ArgumentException($"item {item} doesn't exist");
            }
        }

        public void Update(T item, T newItem)
        {
            if (item is null)
            {
                throw new ArgumentNullException(nameof(item), $"item {item} is null");
            }
            else if (newItem is null)
            {
                throw new ArgumentNullException(nameof(newItem), $"item {newItem} cant be null");
            }
            if (Users.Contains(item))
            {
                Users = Users.Select(prop =>
                {
                    if (prop.Equals(item)) prop = newItem;
                    return prop;
                }).ToList();
                
                Console.WriteLine($"Item was successfully update");
            }
            else
            {
                throw new ArgumentException($"item {item} doesn't exist");
            }
        }

        public void Delete(T item)
        {
            if (item is null)
            {
                throw new ArgumentNullException(nameof(item), $"item {item} is null");
            }
            else if (Users.Contains(item))
            {
                Users.Remove(item);
                Console.WriteLine($"Item was successfully delete");
            }
            else
            {
                throw new ArgumentNullException(nameof(item), $"item {item} doesn't exist");
            }
        }

        public void SaveItem(T item)
        {
            Users.Add(item);
            Console.WriteLine($"Item was successfully saved");
        }

        public T ReadItem(T item)
        {
            return Users.Find(user => user.Equals(item));
        }
    }
}
