namespace CoreApp;

public class Refactorings
{
    /// <summary>
    /// </summary>
    /// <param name="parameterIsHere">This is a cool documentation :)</param>
    public static void UseMe2(string parameterIsHere)
    {
        Console.WriteLine("");
        new List<string>().Add(parameterIsHere);
    }

    public static void UseMoveMe()
    {
        var a  = 2;
        var a1 = 2;
        var a2 = 2;
        var a3 = 2;
        var a4 = 2;
        var a5 = 2;
        var a6 = 2;
        var a7 = 2;
        var a8 = 2;
        var a9 = 2;
        var a0 = 2;
        //int a = 2;
        //int a = 2;
        //int a = 2;
        //int a = 2;
        //int a = 2;
        //int a = 2;
        //int a = 2;
        //int a = 2;
        //int a = 2;
        //int a = 2;
        //int a = 2;
        //int a = 2;
        //int a = 2;
        //int a = 2;
        //int a = 2;
        //int a = 2;


        Refactorings2.MoveMe(a);
        //UseMe2(a);
    }
}