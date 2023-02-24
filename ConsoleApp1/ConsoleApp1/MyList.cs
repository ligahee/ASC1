namespace ConsoleApp1;

public class MyList<T>
{
    private List<T> items;

    public void Add(T element)
    {
        items.Add(element);
    }

    public T Remove(int index)
    {
        if (index < 0 || index > items.Count)
        {
            throw new InvalidOperationException("Index out of range");
        }
        T item = items[index];
        items.RemoveAt(index);
        return item;
    }

    public void Clear()
    {
        items.Clear();
    }

    public void InsertAt(T element, int index)
    {
        if (index < 0 || index > items.Count)
        {
            throw new InvalidOperationException("Index out of range");
        }
        items.Insert(index, element);
    }

    public void DeleteAt(int index)
    {
        if (index < 0 || index > items.Count)
        {
            throw new InvalidOperationException("Index out of range");
        }
        items.RemoveAt(index);
    }

    public T Find(int index)
    {
        if (index < 0 || index > items.Count)
        {
            throw new InvalidOperationException("Index out of range");
        }
        T item = items[index];
        return item;
    }
}