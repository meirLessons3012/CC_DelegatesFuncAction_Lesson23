using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_DelegatesFuncAction_Lesson23
{
    public delegate int MethodReturnIntAcceptTwoInts(int n1, int n2);
    public delegate int MethodReturnIntAcceptNoParams();
    public delegate void PrintMessageDelegate(string text);
    public delegate string MethodReturnStringAndAcceptLong(long number);
}
