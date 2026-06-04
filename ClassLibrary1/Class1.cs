namespace ClassLibrary1;

public class Class1
{
    private readonly string _name;
    public Class1(string name)
    {
        _name = name;
    }

    public string Name()
    {
        var name = _name;
        return name;
    }
}
