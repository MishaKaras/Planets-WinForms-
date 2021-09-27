using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetsHW1._0
{
    class Comet : Astro
    {
        public Comet(float sizeX, float sizeY, float posX, float posY) : base(sizeX, sizeY, posX, posY) { }

        public override void Draw(Graphics graph)
        {
            graph.FillEllipse(new SolidBrush(Color.White), posX, posY, sizeX, sizeY);

            graph.DrawLine(new Pen(new SolidBrush(Color.White), 0.05f * sizeX), (posX - sizeX * 1.5f), (posY - sizeY / 3f), posX, (posY + sizeY / 2f));

            graph.DrawLine(new Pen(new SolidBrush(Color.White), 0.05f * sizeX), (posX - sizeX * 1.5f), posY, posX, (posY + sizeY / 2f));

            graph.DrawLine(new Pen(new SolidBrush(Color.White), 0.05f * sizeX), (posX - sizeX * 1.5f), (posY + sizeY / 3f), posX, (posY + sizeY / 2f));
        }
    }
}
