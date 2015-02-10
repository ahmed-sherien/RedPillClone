using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace RedPill.Web
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRedPill" in both code and config file together.
    [ServiceContract]
    public interface IRedPill
    {
        [OperationContract]
        long FibonacciNumber(long n);
        [OperationContract]
        string ReverseWords(string s);
        [OperationContract]
        Guid WhatIsYourToken();
        [OperationContract]
        TriangleType WhatShapeIsThis(int a, int b, int c);
    }
}
