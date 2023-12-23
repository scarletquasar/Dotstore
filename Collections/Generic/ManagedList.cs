using System.Collections;

namespace Dotstore.Collections.Generic
{
    public class ManagedList<T> : IManagedCollection<T>
    {
        private const uint INITIAL_CAPACITY = 100;

        private T?[] _dataArray;

        public ManagedList()
        {
            _dataArray = new T?[INITIAL_CAPACITY];
        }

        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(T item)
        {
            var index = 0;

            while (true)
            {
                if (_dataArray.Length < index && _dataArray[index] is null)
                {
                    _dataArray[index] = item;
                    return;
                }

                // todo: now, if the capacity is not enough, recreate the
                // array as one with new capacity (+ 100)
                // todo: add resiliency to concurrent operations
                index++;
            }
        }

        public void AddRange(IEnumerable<T> items)
        {
            throw new NotImplementedException();
        }

        public IManagedCollection<(T value, int index)> BinarySearch(T item, IComparer<T>? comparer = null)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void ContainsRange(IEnumerable<T> items)
        {
            throw new NotImplementedException();
        }

        public T Get(int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IManagedCollection<T> GetRange(IEnumerable<int> indexes)
        {
            throw new NotImplementedException();
        }

        public IManagedCollection<(T value, int index)> LinearSearch(T item, IComparer<T>? comparer = null)
        {
            throw new NotImplementedException();
        }

        public IManagedCollection<T> Map(Func<T, T> mapper)
        {
            throw new NotImplementedException();
        }

        public IManagedCollection<(T value, int index)> ParallelSearch(T item, IComparer<T>? comparer = null)
        {
            throw new NotImplementedException();
        }

        public IManagedCollection<T> Reduce(Func<T, T, T> reducer)
        {
            throw new NotImplementedException();
        }

        public void Remove(int index)
        {
            throw new NotImplementedException();
        }

        public void Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<int> indexes)
        {
            throw new NotImplementedException();
        }

        public IManagedCollection<T> Sort(Func<T, T, int> sorter)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
