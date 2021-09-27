using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetsHW1._0
{
    abstract class Astro
    {
        protected float sizeX;
        protected float sizeY;
        protected float posX;
        protected float posY;

        public Astro(float sizeX, float sizeY, float posX, float posY)
        {
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.posX = posX;
            this.posY = posY;
        }

        public abstract void Draw(Graphics graph);
    }
}
