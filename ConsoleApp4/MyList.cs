using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp4;

public class MyList<T> : IEnumerable, IComparable
{
    private static int count = 0;

    public int Capacity { get; set; }
    public int Count { get => count; }
    T[] items;

    public MyList()
    {
        Capacity = 0;
    }
    public MyList(int capacity)
    {
        Capacity = capacity;
    }

    public void Add(T item)
    {
        if (Capacity == 0)
        {
            Capacity = 2;
            Array.Resize(ref items, Capacity);
            items[0] = item;
            count++;
            return;
        }
        if (Capacity == Count)
        {
            Capacity = Capacity * 2;
            Array.Resize(ref items, Capacity);
            items[Capacity / 2] = item;
            count++;
            return;
        }
        //[1,1,1,1]
        items[Count] = item;
        count++;
        return;
    }

    public IEnumerator GetEnumerator()
    {
        Array.Resize(ref items, Count);
        return items.GetEnumerator();
    }
    public bool Exist(Predicate<T> match)
    {
        foreach (var item in items)
        {
            if (match(item))
                return true;
        }
        return false;
    }

    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }
}

