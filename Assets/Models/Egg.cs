using System;
namespace Application
{
    public class Egg :Cards
    {
        int point;
        public Egg()
        {
            point = 10;
        }
        public override int Value()
        {
            return point;
        }
    }
}
