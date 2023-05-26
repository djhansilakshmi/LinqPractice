using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics
{
    public class RuntimePoly
    {
        public virtual void Print()
        {
            Console.WriteLine("ParentPrint.Print");
        }


    }

    public class ChildRuntimePoly : RuntimePoly
    {
        public override void Print()
        {
            Console.WriteLine("ChildPrint.Print");
        }
    }
}
