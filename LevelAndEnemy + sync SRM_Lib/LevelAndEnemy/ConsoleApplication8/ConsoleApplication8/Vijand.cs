using SdlDotNet.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    public class Vijand : BeweegbaarObject
    {
        public Vijand(Surface video) : base(video) {
            position = new Point(100, 100);
            xVelocity = 1;
            image = new Surface("Dragon.gif");
            colRectangle = new Rectangle(position.X, position.Y, 220,  235);
        }

        public override void Draw()
        {
            video.Blit(image, position);
           

        }

        public override void Update()
        {
            if (position.X >= 50 && position.X <= 200)
                position.X += xVelocity;
            else
            {
                xVelocity *= -1;
                position.X += xVelocity;
            }

            colRectangle.X = position.X;
            colRectangle.Y = position.Y;

        }
    }
}
