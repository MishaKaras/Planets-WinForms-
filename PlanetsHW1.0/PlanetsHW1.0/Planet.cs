using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetsHW1._0
{
    class Planet : Astro
    {
        public Planet(float sizeX, float sizeY, float posX, float posY) : base(sizeX, sizeY, posX, posY) { }

        public override void Draw(Graphics graph)
        {
            graph.FillEllipse(new SolidBrush(Color.Brown), posX, posY, sizeX, sizeY);

            graph.DrawArc(new Pen(new SolidBrush(Color.IndianRed), 0.05f * sizeX), posX - 2, posY + sizeY / 2, sizeX + 4, sizeY / 3, -5, 185);
        }
    }
}
