using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DefiningClasses
{
    public abstract class MyBase { }
    internal class MyClass : MyBase { }
    public interface IMyBaseInterface { }
    internal interface IMyBaseInterface2 { }
    internal interface IMyInterface : IMyBaseInterface, IMyBaseInterface2 { }
    internal sealed class MyComplexClass : MyClass, IMyInterface { }
    class Program
    {
        static void Main(string[] args)
        {
            MyComplexClass myObj = new MyComplexClass();
            WriteLine(myObj.ToString());
            ReadKey();
        }
    }
}
