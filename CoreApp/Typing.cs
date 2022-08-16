namespace CoreApp;

public partial class Typing
{
    public void Test2()
    {
        var test = "";

        #region MyRegion

        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);
        Test(test /*caret*/);

        #endregion


        /*caret*/
        AnotherTestMethod4(test);
    }

    private void AnotherTestMethod4(string test)
    {
        throw new NotImplementedException();
    }

    private void AnotherTestMethod3(string test)
    {
        throw new NotImplementedException();
    }

    private void AnotherTestMethod2(string test)
    {
        throw new NotImplementedException();
    }

    private void AnotherTestMethod(string test)
    {
        throw new NotImplementedException();
    }
}