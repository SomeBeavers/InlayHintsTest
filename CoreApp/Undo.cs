

using System.Collections.Immutable;

namespace CoreApp;

public class Undo
{
    private object _myObject;

    public void Test(B parameter)
    {
    }

    public void UseTest(A someString)
    {
        Test( /*sel start*/someString /*sel end*/);
        Test(someString); // comment
        Test(someString); //a
        Test(someString); //comment

        _myObject = someString;

        NewMethod(someString);
        Test(someString);

        var list = new List<A>();

        list.Add(new A());

        var enumerable = list.Where(x => x.Name.Contains(""));

        var a = enumerable.ToImmutableSortedSet();
    }

    private void NewMethod(object someString)
    {
        someString = (string)_myObject;
    }
}

public class B
{
}

public class A
{
    public string Name;

    public static implicit operator B(A a)
    {
        return new B();
    }
}