using System;
namespace Application
{
    public class Sloth :Cards
    {
        int point;
        public Sloth()
        {
            point = -10;
        }
        public override int Value(){
            return point;
        }
    }
}
