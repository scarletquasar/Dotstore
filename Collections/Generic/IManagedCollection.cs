namespace Dotstore.Collections.Generic
{
    public interface IManagedCollection<T> : IEnumerable<T>
    {
        // Essential
        public T this[int index] { get; set; }
        public void Add(T item);
        public void AddRange(IEnumerable<T> items);
        public void Remove(int index);
        public void RemoveRange(IEnumerable<int> indexes);
        public void Remove(T item);
        public void Contains(T item);
        public void ContainsRange(IEnumerable<T> items);
        public void Clear();
        public T Get(int index);
        public IManagedCollection<T> GetRange(IEnumerable<int> indexes);

        // Discoverability

        public IManagedCollection<(T value, int index)> LinearSearch(T item, IComparer<T>? comparer = null);
        public IManagedCollection<(T value, int index)> BinarySearch(T item, IComparer<T>? comparer = null);
        public IManagedCollection<(T value, int index)> ParallelSearch(T item, IComparer<T>? comparer = null);

        // Polymorphism

        public IManagedCollection<T> Map(Func<T, T> mapper);
        public IManagedCollection<T> Sort(Func<T, T, int> sorter);
        public IManagedCollection<T> Reduce(Func<T, T, T> reducer); 
    }
}
