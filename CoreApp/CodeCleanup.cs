namespace CoreApp;

public class CodeCleanup
{
    public A? a = null;

    public A? Test(string myCoolStringParameter)
    {
        return null;
    }

    public void UseTest()
    {
        var a = Test("");

        Console.WriteLine(a);
        var t   = 1;
        var s   = "";
        var k   = 2;
        var b   = false;
        var bb  = true;
        var bb1 = true;


        Test("");
        Test("");
        Test("");
        Test("");
        Test("");
        Test("");
        Test("");
        Test("");
        Test("");
    }
}