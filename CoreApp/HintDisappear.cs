namespace CoreApp;

public class HintDisappear
{
    public void Test(string formatRenamed)
    {
        MyNewlyCreatedMethod(formatRenamed);
        int t = 1;
    }

    private static void MyNewlyCreatedMethod(string myCoolParameter)
    {
        Console.WriteLine(myCoolParameter);
    }
}