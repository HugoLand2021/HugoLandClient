using Hugo_LAND.Client.HugoLandServices;
using System.Collections.Generic;
using System.Drawing;
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
        WorldItemServiceClient worlditemsService = new WorldItemServiceClient();
        ItemServiceClient itemService = new ItemServiceClient();
        MonsterServiceClient monstreService = new MonsterServiceClient();

        public MapTile[,] Map = new MapTile[MapSizeX, MapSizeY];
        private Rectangle _areaRectangle = new Rectangle(AreaOffsetX, AreaOffsetY, MapSizeX * Tile.TileSizeX, MapSizeY * Tile.TileSizeY);

        public Area(Dictionary<string, Tile> tiles, string worldName, int beginX, int beginY)
        {
                var worldoObjects = worlditemsService.ReturnWorldItems(worldName, beginX, beginY).ToList();
                foreach (var item in worldoObjects)
                {
                    MapTile mapTile = new MapTile();
                    Map[item.x % 8, item.y % 8] = mapTile;
                    mapTile.Tile = tiles[item.Description];
                    mapTile.SetSprite(item.x % 8, item.y % 8);
                }

                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        if (Map[x, y] == null)
                        {
                            MapTile mapTile = new MapTile();
                            Map[x, y] = mapTile;
                            mapTile.Tile = tiles["Grass"];
                            mapTile.SetSprite(x, y);
                        }
                    }
                }

                LoadItemsMonsters(tiles, worldName, beginX, beginY);
        }
        public Area(Dictionary<string, Tile> tiles, List<WorldItemDetailsDTO> listItems, string worldName, int beginX, int beginY)
        {
                foreach (var item in listItems)
                {
                    MapTile mapTile = new MapTile();
                    Map[item.x % 8, item.y % 8] = mapTile;
                    mapTile.Tile = tiles[item.Description];
                    mapTile.SetSprite(item.x % 8, item.y % 8);
                }

                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        if (Map[x, y] == null)
                        {
                            MapTile mapTile = new MapTile();
                            Map[x, y] = mapTile;
                            mapTile.Tile = tiles["Grass"];
                            mapTile.SetSprite(x, y);
                        }
                    }
                }
                LoadItemsMonsters(tiles, worldName, beginX, beginY);
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
        public void LoadItemsMonsters(Dictionary<string, Tile> tiles, string worldName, int beginX, int beginY)
        {
                var items = itemService.ReturnItems(worldName, beginX, beginY).ToList();
                foreach (var item in items)
                {
                    if (item.x != null)
                    {
                        MapTile mapTile = Map[item.x.GetValueOrDefault() % 8, item.y.GetValueOrDefault() % 8];
                        mapTile.ObjectTile = tiles[item.Description];
                        mapTile.SetObjectSprite(item.x.GetValueOrDefault() % 8, item.y.GetValueOrDefault() % 8);

                        if (mapTile.ObjectTile.IsTransparent)
                        {
                            mapTile.ObjectSprite.ColorKey = Color.FromArgb(75, 75, 75);
                        }
                    }
                }

                var monstres = monstreService.ReturnMonsters(worldName, beginX, beginY).ToList();
                foreach (var monstre in monstres)
                {

                    MapTile mapTile = Map[monstre.x % 8, monstre.y % 8];
                    mapTile.ObjectTile = tiles[monstre.Nom];
                    mapTile.SetObjectSprite(monstre.x % 8, monstre.y % 8);

                    if (mapTile.ObjectTile.IsTransparent)
                    {
                        mapTile.ObjectSprite.ColorKey = Color.FromArgb(75, 75, 75);
                    }
                }

                //TODO
                /*
                 Faire le code ici qui viendra loader Dans les mapTile tous les héros qui sont présentement connecté à la BD
                 Il me semble que c'est la tuile 70 qui est le sprite a faire popper au travers de la carte.
                 
                 
                 */

        }
    }
}
