using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    internal class Shared1
    {
#if NETCOREAPP
        public void Shared1Method(string myCoolStringParameterForCore)
        {
        }

        #else

                public void Shared1Method(string myCoolStringParameterForFramework)
        {
        }
#endif



// comment















































#if NETCOREAPP
        public void Use1()
        {
            Shared1Method("");
        }
        #else
                public void Use1()
        {
            Shared1Method("");
        }
#endif
    }


}
