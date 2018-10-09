using System;
namespace Application
{
    public class Dog : Cards
    {
        int point;
        public Dog()
        {
            point = 5;
        }
        public override int Value()
        {
            return point;
        }
    }
}
