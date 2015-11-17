using SdlDotNet.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    public abstract class BeweegbaarObject
    {
        protected Point position;
        protected int xVelocity;
        protected Surface video;
        protected Surface image;
        public Rectangle colRectangle;

        public BeweegbaarObject(Surface video) {
            this.video = video;
        }

        public abstract void Update();

        public abstract void Draw();
    }
}
