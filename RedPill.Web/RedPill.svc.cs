using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace RedPill.Web
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RedPill" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RedPill.svc or RedPill.svc.cs at the Solution Explorer and start debugging.
    public class RedPill : IRedPill
    {
        public long FibonacciNumber(long n)
        {
            return RedPillClone.FibonacciNumber(n);
        }

        public string ReverseWords(string s)
        {
            return RedPillClone.ReverseWords(s);
        }

        public Guid WhatIsYourToken()
        {
            return RedPillClone.WhatIsYourToken();
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            return RedPillClone.WhatShapeIsThis(a, b, c);
        }
    }
}
