namespace Multi
{
    public class Multi1
    {
#if NET6_0
        public void Test(InnerClass innerClass)
        {

        }

        #else
                public void Test(InnerClass innerClass2Renamed)
        {

        }
        
#endif


        public void Test2()
        {
#if NET6_0
            Test(new InnerClass());
#else
           Test(new InnerClass());    
#endif
         
        }
    }

    public class InnerClass
    {
    }
}