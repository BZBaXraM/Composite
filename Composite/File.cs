namespace Composite;

public class File : SystemItem
{
    public string? Name { get; set; }
    public string? Path { get; set; }
    public double Size { get; }

    public File(string name, double size, string path = "")
    {
        Name = name;
        Path = path;
        Size = size;
    }
}