using System;
using Hugo_LAND.Client.HugoLandServices;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using System.Linq;

namespace Hugo_LAND.Client
{

    /// <summary>
    /// Area defines the 8x8 grid that contains a set of MapTiles
    /// </summary>
    public class Area : GameObject
    {
        public const int AreaOffsetX = 30;
        public const int AreaOffsetY = 50;
        public const int MapSizeX = 8;
        public const int MapSizeY = 8;
        public int AreaBeginX = 0;
        public int AreaBeginY = 0;
        WorldItemServiceClient worlditemsService = new WorldItemServiceClient();

        public MapTile[,] Map = new MapTile[MapSizeX, MapSizeY];
        private Rectangle _areaRectangle = new Rectangle(AreaOffsetX, AreaOffsetY, MapSizeX * Tile.TileSizeX, MapSizeY * Tile.TileSizeY);

        public Area(Dictionary<string, Tile> tiles)
        {



            //Read in 8 lines of 8 characters each. Look up the tile and make the
            //matching sprite
            //for (int j = 0; j < MapSizeY; j++)
            //{
            //    //Get a line of map characters
            //    line = stream.ReadLine();

            //    for (int i = 0; i < MapSizeX; i++)
            //    {
            //        MapTile mapTile = new MapTile();
            //        Map[i, j] = mapTile;
            //        mapTile.Tile = tiles[line[i].ToString()];
            //        mapTile.SetSprite(i, j);
            //    }
            //}
            var pooper = worlditemsService.ReturnWorldItems(1112, 0, 0).ToList();



            foreach (var item in pooper)
            {



                MapTile mapTile = new MapTile();
                Map[item.x % 8, item.y % 8] = mapTile;
                mapTile.Tile = tiles[item.Description];
                mapTile.SetSprite(item.x % 8, item.y % 8);
                //mapTile.SetObjectSprite(item.x,item.y);


                //if (mapTile.ObjectTile.IsTransparent)
                //{
                //    mapTile.ObjectSprite.ColorKey = Color.FromArgb(75, 75, 75);
                //}
            }

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    if (Map[x,y] == null)
                    {
                        MapTile mapTile = new MapTile();
                        Map[x,y] = mapTile;
                        mapTile.Tile = tiles["Grass"];
                        mapTile.SetSprite(x,y);
                    }
                }
            }

            //Read game objects until the blank line
            //while (!stream.EndOfStream && (line = stream.ReadLine().Trim()) != "")
            //{
            //    //Each line is an x,y coordinate and a tile shortcut
            //    //Look up the tile and construct the sprite
            //    string[] elements = line.Split(',');
            //    int x = Convert.ToInt32(elements[0]);
            //    int y = Convert.ToInt32(elements[1]);
            //    MapTile mapTile = Map[x, y];
            //    mapTile.ObjectTile = tiles[elements[2]];
            //    mapTile.SetObjectSprite(x, y);

            //    if (mapTile.ObjectTile.IsTransparent)
            //    {
            //        mapTile.ObjectSprite.ColorKey = Color.FromArgb(75, 75, 75);
            //    }
            //}

        }

        public override void Update(double gameTime, double elapsedTime)
        {
            //Update all the map tiles and any objects
            foreach (MapTile mapTile in Map)
            {
                mapTile.Sprite.Update(gameTime, elapsedTime);
                if (mapTile.ObjectSprite != null)
                {
                    if (mapTile.ObjectSprite.NumberOfFrames > 1)
                    {
                        mapTile.ObjectSprite.CurrentFrame = (int)((gameTime * 8.0) % (double)mapTile.ObjectSprite.NumberOfFrames);
                    }
                    mapTile.ObjectSprite.Update(gameTime, elapsedTime);
                }
            }

        }

        public override void Draw(Graphics graphics)
        {
            //And draw the map and any objects
            foreach (MapTile mapTile in Map)
            {
                mapTile.Sprite.Draw(graphics);
                if (mapTile.ObjectSprite != null)
                {
                    mapTile.ObjectSprite.Draw(graphics);
                }
            }

        }
    }
}
