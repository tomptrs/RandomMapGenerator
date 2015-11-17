using SdlDotNet.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    public class Gras
    {

        Surface video;
        Surface image;
        Point position;

        public Gras(Surface video, Point position) {
            this.video = video;
            this.position = position;
            image = new Surface("gras.png");
        }

        public void Draw() {
            video.Blit(image, position);
        }
    }
}
