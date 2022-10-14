using System.Collections;

namespace Composite;

public class Folder : SystemItem
{
    private List<SystemItem> _items;

    public Folder(string name, string path)
    {
        Name = name;
        Path = path;
        _items = new();
    }

    public string? Name { get; set; }
    public string? Path { get; set; }

    public double Size
    {
        get { return _items.Sum(x => x.Size); }
    }

    public void Add(SystemItem item) => _items.Add(item);

    public void Delete(SystemItem item) => _items.Remove(item);

    public List<SystemItem> GetSystemItems() => _items;
}