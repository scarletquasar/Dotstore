using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotstore.Caching.Generic
{
    internal class TimedCollectionItem<T>
    {
        public T? Value { get; set; }
        public DateTimeOffset? ExpiresAt { get; set; }
    }

    public class TimedCollection<T> : ICollection<T>
    {
        private List<TimedCollectionItem<T>> _list;

        public TimedCollection()
        {
            _list = new();
        }

        public TimedCollection(int capacity)
        {
            _list = new(capacity);
        }

        public TimedCollection(IEnumerable<T> collection, TimeSpan expiration)
        {
            var values = collection.Select(item => new TimedCollectionItem<T>
            {
                Value = item,
                ExpiresAt = DateTimeOffset.UtcNow.Add(expiration)
            });

            _list = new(values);
        }

        public TimedCollection(IEnumerable<T> collection, DateTimeOffset expiration)
        {
            var values = collection.Select(item => new TimedCollectionItem<T>
            {
                Value = item,
                ExpiresAt = expiration
            });

            _list = new(values);
        }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
