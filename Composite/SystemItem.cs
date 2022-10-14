namespace Composite;

public interface SystemItem
{
    string? Name { get; set; }
    string? Path { get; set; }
    double Size { get; }
}