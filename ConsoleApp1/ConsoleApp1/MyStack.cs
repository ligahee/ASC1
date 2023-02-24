namespace ConsoleApp1;

public class MyStack<T>
{
    private List<T> items = new List<T>();

    public int Count
    {
        get
        {
            return items.Count;
        }
    }

    public T Pop()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("The stack is empty");
        }

        T item = items[Count - 1];
        items.RemoveAt(Count-1);
        return item;
    }

    public void Push(T item)
    {
        items.Add(item);
    }
}