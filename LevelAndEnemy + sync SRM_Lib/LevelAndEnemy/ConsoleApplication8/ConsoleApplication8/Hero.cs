using SdlDotNet.Core;
using SdlDotNet.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
   public class Hero: BeweegbaarObject
    {
       
        private Rectangle visibleRectangle;
        private bool left;
        private bool right;
        public Rectangle CollisionRectangle;
        SdlDotNet.Input.Key links, rechts;

        public Hero(Surface video, SdlDotNet.Input.Key links, SdlDotNet.Input.Key rechts):base(video) {
            
            image = new Surface("WalkLeft.jpg");
            visibleRectangle = new Rectangle(0, 0, 64, 205);
            
            position = new Point(50, 200);
            colRectangle = new Rectangle(position.X, position.Y, 64, 205);
            xVelocity = 2;
            this.links = links;
            this.rechts = rechts;

            Events.KeyboardDown += Events_KeyboardDown;
            Events.KeyboardUp += Events_KeyboardUp;
        }

        private void Events_KeyboardUp(object sender, SdlDotNet.Input.KeyboardEventArgs e)
        {
            left = right = false;
        }

        private void Events_KeyboardDown(object sender, SdlDotNet.Input.KeyboardEventArgs e)
        {
            if (e.Key == links)
                left = true;
            if (e.Key == rechts)
                right = true;


        }

        public override void Update() {
            if (left) 
                position.X -= xVelocity;
            if (right)
                position.X += xVelocity;

            if (left || right) {
                visibleRectangle.X += 64;
                if (visibleRectangle.X >= 192)
                    visibleRectangle.X = 0;

                
            }

            colRectangle.X = position.X;
            colRectangle.Y = position.Y;

        }

        public override void Draw() {
            video.Blit(image, position, visibleRectangle);          
        }

       

    }
}
