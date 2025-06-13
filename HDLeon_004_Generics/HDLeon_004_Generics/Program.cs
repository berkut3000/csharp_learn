// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var numbers = new MyList<int>(5);

var names = new MyList<string>(5);

var beers = new MyList<Beer>(5);


numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Add(6);

names.Add("Hector");
names.Add("Ana");
names.Add("Luis");
names.Add("Juan");
names.Add("Roberto");
names.Add("Antonio");
names.Add("Alejandro");
names.Add("Karla");

beers.Add(new Beer()
{
    Name = "Erdinger",
    Price = 5,
});

beers.Add(new Beer()
{
    Name = "Corona",
    Price = 1,
});

beers.Add(new Beer()
{
    Name = "Delirum",
    Price = 5,
});

beers.Add(new Beer()
{
    Name = "Superior",
    Price = 9,
});

Console.WriteLine(numbers.GetContent());
Console.WriteLine(names.GetContent());
Console.WriteLine(beers.GetContent());



public class MyList<T>
{
    private List<T> _list;
    private int _limit;

    public MyList(int limit)
    {
        _limit = limit;
        _list = new List<T>();
    }

    public void Add(T element)
    {
        if(_list.Count < _limit)
        {
            _list.Add(element);
        }
    }

    public string GetContent()
    {
        string content = "";
        foreach (var element in _list)
        {
            content += element + ",";
        }
        return content;
    }

}

public class Beer
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return "Nombre: " + Name + " Price: "+ Price;
    }
}
