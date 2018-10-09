using System;
namespace Application
{
    public class Plant : Cards
    {
        int point;
        public Plant()
        {
            point = 10;
        }
        public override int Value()
        {
            return point;
        }
    }
}
