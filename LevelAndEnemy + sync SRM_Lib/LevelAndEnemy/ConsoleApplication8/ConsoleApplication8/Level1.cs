using SdlDotNet.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRM_Library;


namespace ConsoleApplication8
{
    public class Level1:Level
    {
        SmallRandomMap map = new SmallRandomMap();
        
        public Level1(Surface video):base(video) {
            map.create_map();
            CreateWorld();        
        }
       
        protected override void CreateWorld()
        {
            spriteTileArray = new Gras[30, 50];
            for (int i = 0; i < 30; i++) {
                for (int j = 0; j < 50; j++) {
                    try
                    {
                        if (map.mapArray[i, j] == 1)
                        {
                            spriteTileArray[i, j] = new Gras(video, new System.Drawing.Point(j * 30, i * 30));
                        }
                    }
                    catch (NullReferenceException)
                    {

                    }
                }
            }
        }
    }
}
