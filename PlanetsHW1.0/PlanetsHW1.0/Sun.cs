using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetsHW1._0
{
    class Sun : Astro
    {
        public Sun(float sizeX, float sizeY, float posX, float posY) : base(sizeX, sizeY, posX, posY) { }
        
        public override void Draw(Graphics graph)
        {
            graph.FillEllipse(new SolidBrush(Color.Yellow), posX, posY, sizeX, sizeY);
        }
    }
}
