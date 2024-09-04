using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericValueCollectionDemo
{
    public class ValueCollection<T> where T : struct
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public T GetItem(int index)
        {
            if (index >= 0 && index < items.Count)
                return items[index];
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }

        public IEnumerable<T> GetSortedItemsDescending()
        {
            return items.OrderByDescending(x => x);
        }
    }
}
