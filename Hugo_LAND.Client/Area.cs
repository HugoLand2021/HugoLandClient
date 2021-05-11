using Hugo_LAND.Client.HugoLandServices;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
        HeroServiceClient heroService = new HeroServiceClient();

        public MapTile[,] Map = new MapTile[MapSizeX, MapSizeY];
        private List<WorldItemDetailsDTO> _worldObjects = new List<WorldItemDetailsDTO>();
        private List<ItemDetailsDTO> _items = new List<ItemDetailsDTO>();
        private List<MonsterDetailsDTO> _monsters = new List<MonsterDetailsDTO>();
        public List<HeroDetailsDTO> _heroes = new List<HeroDetailsDTO>();

        private Dictionary<string, Tile> _tiles = new Dictionary<string, Tile>();
        private string _worldName = "";
        private int IdHero;
        public HeroDetailsDTO UpdatedCurrentHero = new HeroDetailsDTO();
        private bool ErrorMessage = false;
        private bool isAlreadyUpdating = false;


        private Rectangle _areaRectangle = new Rectangle(AreaOffsetX, AreaOffsetY, MapSizeX * Tile.TileSizeX, MapSizeY * Tile.TileSizeY);

        public Area(Dictionary<string, Tile> tiles, string worldName, int beginX, int beginY, int idHero)
        {
            IdHero = idHero;
            _tiles = tiles;
            _worldName = worldName;

            LoadWorldObjects(null, beginX, beginY);
            LoadItemsMonsters(beginX, beginY);
            LoadHeroes(beginX, beginY);
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
        public bool LoadWorldObjects(List<WorldItemDetailsDTO> worldObjects, int beginX, int beginY)
        {
            try
            {
                if (worldObjects is null)
                    _worldObjects = worlditemsService.ReturnWorldItems(_worldName, beginX, beginY).ToList();
                else
                    _worldObjects = worldObjects;
                foreach (var item in _worldObjects)
                {
                    MapTile mapTile = new MapTile();
                    Map[item.x % 8, item.y % 8] = mapTile;
                    mapTile.Tile = _tiles[item.Description];
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
                            mapTile.Tile = _tiles["Grass"];
                            mapTile.SetSprite(x, y);
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool LoadItemsMonsters(int beginX, int beginY)
        {
            try
            {
                _items = itemService.ReturnItems(_worldName, beginX, beginY).ToList();
                foreach (var item in _items)
                {
                    if (item.x != null)
                    {
                        MapTile mapTile = Map[item.x.GetValueOrDefault() % 8, item.y.GetValueOrDefault() % 8];
                        mapTile.ObjectTile = _tiles[item.Description];
                        mapTile.SetObjectSprite(item.x.GetValueOrDefault() % 8, item.y.GetValueOrDefault() % 8);

                        if (mapTile.ObjectTile.IsTransparent)
                        {
                            mapTile.ObjectSprite.ColorKey = Color.FromArgb(75, 75, 75);
                        }
                    }
                }

                _monsters = monstreService.ReturnMonsters(_worldName, beginX, beginY).ToList();
                foreach (var monstre in _monsters)
                {

                    MapTile mapTile = Map[monstre.x % 8, monstre.y % 8];
                    mapTile.ObjectTile = _tiles[monstre.Nom];
                    mapTile.SetObjectSprite(monstre.x % 8, monstre.y % 8);

                    if (mapTile.ObjectTile.IsTransparent)
                    {
                        mapTile.ObjectSprite.ColorKey = Color.FromArgb(75, 75, 75);
                    }
                }
                return true;
            }
            catch
            {
                DialogResult dr = MessageBox.Show("An error occured while loading the map!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool LoadHeroes(int beginX, int beginY)
        {
            try
            {
                _heroes = heroService.ReturnHeroes(_worldName, beginX, beginY).ToList();
                UpdatedCurrentHero = _heroes.First(h => h.Id == IdHero);
                _heroes.Remove(UpdatedCurrentHero);
                foreach (var hero in _heroes)
                {
                    MapTile mapTile = Map[hero.x % 8, hero.y % 8];
                    mapTile.ObjectTile = _tiles["Hero"];
                    mapTile.ObjectTile.Health = hero.StatVitality;

                    mapTile.SetObjectSprite(hero.x % 8, hero.y % 8);

                    if (mapTile.ObjectTile.IsTransparent)
                    {
                        mapTile.ObjectSprite.ColorKey = Color.FromArgb(75, 75, 75);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void ChangeMap(List<WorldItemDetailsDTO> worldObjects, int beginX, int beginY)
        {
            Map = new MapTile[MapSizeX, MapSizeY];
            LoadWorldObjects(worldObjects, beginX, beginY);
            LoadItemsMonsters(beginX, beginY);
            LoadHeroes(beginX, beginY);
            
        }

        public void RefreshMap(int beginX, int beginY)
        {
            for (int i = 0; i < 8; i++)
                for (int ia = 0; ia < 8; ia++)
                {
                    Map[i, ia].ObjectTile = null;
                    Map[i, ia].ObjectSprite = null;
                }
            LoadItemsMonsters(beginX, beginY);
            LoadHeroes(beginX, beginY);
        }

    }
}
