namespace CoreApp;

public class LongHint
{
    public void TestMethodWithLongHint(InnerClassWithLongName thisIsALongHintWhichIsNotFullyVisibleOnTheScreenSoHorizontalScrollIsRequired
    )
    {
    }

    public void UseMethod(InnerClassWithLongName a)
    {
        TestMethodWithLongHint(/*some comment before hint is here so hint is not visible completely on the current screen*/a);
    }
}

public class InnerClassWithLongName
{
}