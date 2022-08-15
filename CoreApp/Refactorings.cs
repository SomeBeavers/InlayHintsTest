namespace CoreApp;

public class Refactorings
{
    private static void MoveMe(int intParameter)
    {
        
    }

    public static void UseMoveMe()
    {
        int a = 2;
        MoveMe(a);
    }
}

public class Refactorings2
{
    //private static void MoveMe(int a) { }
}