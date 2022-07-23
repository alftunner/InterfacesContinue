namespace Interfaces;

public interface IIndexer : IRender
{
    string this[int index]
    {
        get;
        set;
    }
    string this[string index]
    {
        get;
    }
}