namespace ConsoleApp1;

public class GenericRepository<T>: IRepository<T> where T : class, IEntity
{
    private List<T> items = new List<T>();
    
    public void Add(T item)
    {
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item));
        }

        if (item.Id == 0)
        {
            item.Id = GetNextId();
        }
        items.Add(item);
    }

    private int GetNextId()
    {
        return items.Count + 1;
    }
    
    public void Remove(T item)
    {
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item));
        }

        items.Remove(item);
    }

    public void Save()
    {
        Console.WriteLine("Changes saved.");
    }

    public IEnumerable<T> GetAll()
    {
        return items;
    }

    public T? GetById(int id)
    {
        return items.FirstOrDefault(item => item.Id == id);
    }
}

public interface IRepository<T> where T : class, IEntity
{
    void Add(T item);
    void Remove(T item);
    void Save();
    IEnumerable<T> GetAll();
    T? GetById(int id);
}

public interface IEntity
{
    int Id { get; set; }
}