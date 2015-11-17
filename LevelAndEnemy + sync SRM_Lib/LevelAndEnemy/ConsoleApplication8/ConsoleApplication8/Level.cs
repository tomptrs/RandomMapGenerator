using SdlDotNet.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    public abstract class Level
    {
        protected Surface video;
        public Level(Surface video) {
            this.video = video;
        }

        protected int[,] intTileArray;

        protected Gras[,] spriteTileArray;


        protected abstract void CreateWorld();

        public void DrawWorld() {

            for (int i = 0; i < 30; i++) {
                for (int j = 0; j < 50; j++) {
                    if (spriteTileArray[i, j] != null) {
                        spriteTileArray[i, j].Draw();
                    }

                }
            }
        }
    }
}
