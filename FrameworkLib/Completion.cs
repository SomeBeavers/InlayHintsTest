using System.Threading.Tasks;

namespace FrameworkLib
{
    public class Completion
    {
        public void Test()
        {
            MyTask().Result.Length
        }

        public Task MyTask()
        {
            return null;
        }
    }
}