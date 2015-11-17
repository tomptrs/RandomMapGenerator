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
    public class Manager
    {
        
        private Surface mVideo;
        private Hero hero, hero2;
        Vijand vijand;
        Level level1,activeLevel;
        
        public Manager()
        {
            mVideo = Video.SetVideoMode(1500, 900);
            hero = new Hero(mVideo, SdlDotNet.Input.Key.O, SdlDotNet.Input.Key.P);
            hero2 = new Hero(mVideo, SdlDotNet.Input.Key.LeftArrow, SdlDotNet.Input.Key.RightArrow);
            vijand = new Vijand(mVideo);
            level1 = new Level1(mVideo);
            activeLevel = level1;
            Events.Tick += Events_Tick;
            Events.Run();
        }

        private void Events_Tick(object sender, TickEventArgs e)
        {
            //Clear
            mVideo.Fill(Color.Cyan);
            //Update
            hero.Update();
            hero2.Update();
            vijand.Update();

            if (vijand.colRectangle.IntersectsWith(hero.colRectangle)) {
                Console.WriteLine("RAAK!!!");
            }

             //Draw
            hero.Draw();
            hero2.Draw();
            vijand.Draw();

            activeLevel.DrawWorld();

            mVideo.Update();
        }
    }
}
