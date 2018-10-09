using System;
namespace Application
{
    public class Unicorn : Cards
    {
        int point;
        public Unicorn()
        {
            point = -5;
        }
        public override int Value()
        {
            return point;
        }
    }
}
