using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList randomList = new RandomList();
            randomList.Add("aaa");
            randomList.Add("bbb");
            randomList.Add("ccc");
            Console.WriteLine(randomList.RandomString());
        }
    }
}
