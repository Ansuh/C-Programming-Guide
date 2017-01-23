using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance3DShapes
{
    public class Cone : AbstractShapes
    {
        float radius { get; set; }
        float height { get; set; }
        public override Point point { get; set; }
        
            

        public Cone(float radius, float height, Point p)
        {

            this.radius = 1f;
            this.height = 1f;
            this.point = new Point();
        }

        public override float Area()
        {
            float l = (float)Math.Sqrt((Math.Pow(radius, 2) + Math.Pow(height, 2)));
            return (float)Math.PI * (float)Math.Pow(radius, 2) + (float)Math.PI * radius * l;

        }
        public override float Volume()
        {
            return 1f / 3 * (float)Math.PI * (float)Math.Pow(radius, 2) * height;
        }
    }
}
