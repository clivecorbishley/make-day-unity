using System;
namespace Application
{
    public class Drone : Cards
    {
        int point;
        public Drone()
        {
            point = -5;
        }
        public override int Value()
        {
            return point;
        }
    }
}
