namespace Interfaces;

enum Numbers
{
    one,
    two,
    three,
    four,
    five
};

public class IndexerClass : IIndexer
{
    string[] names = new string[5];

    public IndexerClass()
    {
        this[0] = "Bob";
        this[1] = "Jack";
        this[2] = "Alex";
        this[3] = "Mike";
        this[4] = "John";
    }
    
    public string this[int index]
    {
        get => names[index];
        set => names[index] = value;
    }

    public string this[string index]
    {
        get
        {
            if (Enum.IsDefined(typeof(Numbers), index))
                return names[(int)Enum.Parse(typeof(Numbers), index)];
            else
                return "";
        }
    }

    public void Show()
    {
        Console.WriteLine("Show");
    }
}