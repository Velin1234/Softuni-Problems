using System;

namespace Stealer
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string CLASSNAME = "Stealer.Hacker";
            string result;
            Spy spy = new Spy();
            //result = spy.StealFieldInfo(CLASSNAME, "username", "password");
            //result = spy.AnalyzeAccessModifiers(CLASSNAME);
            //result = spy.RevealPrivateMethods(CLASSNAME);
            result = spy.CollectGettersAndSetters(CLASSNAME);
            Console.WriteLine(result);
        }
    }
}
