namespace CoreApp;

public class Refactorings2
{
    public static void MoveMe(int intParameter)
    {
        new List<int>().Add(intParameter);
    }



    //private static void MoveMe(int a) { }
}