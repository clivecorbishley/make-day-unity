using System;
namespace Application
{
    public class Cat : Cards
    {
        int point;
        public Cat()
        {
            point = 5;
        }
        public override int Value()
        {
            return point;
        }
    }
}
