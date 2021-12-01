using System;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet test = new Buffet();
            Ninja test1 = new Ninja();

            while(!test1.IsFull)
            {
                test1.Eat(test.Serve());
            }
        }
    }
}
