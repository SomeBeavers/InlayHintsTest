NewLocalFuncIsHere(null);
var t2 = 1;
var t  = new InnerClassHere();

Console.WriteLine(t.Name);

string NewLocalFuncIsHere(string someParameterName)
{
    return null;
}

public class InnerClassHere
{
    public string Name { get; set; } = "Jane Doe";
}