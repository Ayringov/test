using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1_2021
{
    class Map
    {
        Tile[,] map;
        Hero hero;
        Enemy[] enemies;
        Item[] items;

        /*int x, y;
        TileType type;*/

        int width;
        int height;

        Random random = new Random();

        public Hero Hero
        {
            get { return hero; }
        }

        public Enemy[] Enemies
        {
            get { return enemies; }
        }

        public Item[] Items
        {
            get { return items; }
        }

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int numEnemies, int numItems)
        {
            

            width = random.Next(minWidth, maxWidth + 1);
            height = random.Next(minHeight, maxHeight + 1);
            map = new Tile[width, height];

            enemies = new Enemy[numEnemies];
            items = new Item[numItems];
            

            InitializeMap();

            //created hero
            hero = (Hero)Create(Tile.TileType.Hero);
            //created goblins
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = (Enemy)Create(Tile.TileType.Enemy);
            }
            

            Update();
            UpdateVision();
        }

        private void InitializeMap()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (x == 0 || x == width - 1 || y == 0 || y == height - 1)
                    {
                        map[x, y] = new Obstacle(x, y);
                    }
                    else
                    {
                        map[x, y] = new EmptyTile(x, y);
                    }

                }
            }
        }

        private  Tile Create(Tile.TileType type)  //need to ADD MAGES AND GOLD
        {
            int x = random.Next(0, width);
            int y = random.Next(0, height);

            while (map[x, y].Type != Tile.TileType.Empty)
            {
                x = random.Next(0, width);
                y = random.Next(0, height);
            }

            if (type == Tile.TileType.Hero)
            {
                return map[x, y] = new Hero(x, y, 10);


            }
            else if (type == Tile.TileType.Gold)
            {
               a //fix
            }
            else if (type == Tile.TileType.Enemy)
            {
                if (random.Next(0, 2) == 0)
                {
                    map[x, y] = new Goblin(x, y);
                }
                else
                {
                    map[x, y] = new Mage(x, y);
                }
                return map[x, y];
            }
            return map[x, y];
        }



        public void Update()
        {
            InitializeMap();

            map[hero.X, hero.Y] = hero;

            for (int i = 0; i < enemies.Length; i++)
            {
                Enemy currentEnemy = enemies[i];
                map[currentEnemy.X, currentEnemy.Y] = enemies[i];
            }

            for (int i = 0; i < items.Length; i++)
            {
                Item item = items[i];
                if (item != null)
                {
                    map[item.X, item.Y] = item;
                }

            }


            if (items != null)
            {
                foreach (Item item in items)
                {
                    map[item.X, item.Y] = item;
                }

                if (enemies != null)
                {
                    foreach (Enemy enemy in enemies)
                    {
                        map[enemy.X, enemy.Y] = enemy;
                    }

                    if (hero != null)
                    {
                        map[hero.X, hero.Y] = hero;
                    }
                }
            }

        }

        public Item GetItemAtPosition(int x, int y)
        {
            
            for (int i = 0; i < items.Length; i++)
            {

                if (items[i] == null)
                {
                    continue;
                }

                if (items[i].X == x && items[i].Y == y)
                {
                    Item temItem = items[i];
                    items[i] = null;
                    return temItem;
                }
            }


            return null;
        }

        public void SetEmptyTile(int x, int y)
        {
            if (x < 0 || x > width || y < 0 || y > height)
            {
                return;
            }

            map[x, y] = new EmptyTile(x, y);
        }

        public Tile GetTileAt(int x, int y)
        {
            if(x < 0 || x > width || y < 0 || y > height)
            {
                return null;
            }

            return map[x, y];
        }

        public void UpdateVision()
        {
            hero.UpdateVision(this);

            foreach(Enemy e in enemies)
            {
                e.UpdateVision(this);
            }
        }

        public override string ToString()
        {
            int value = 0;
            string mapString = "";
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Tile.TileType currentType = map[x, y].Type;
                    if (Hero.X == x && Hero.Y == y)
                    {
                        mapString += 'H';
                        continue;
                    }
                    if (currentType == Tile.TileType.Enemy)
                    {
                        Enemy enemy = (Enemy)map[x, y];
                        if (enemy.IsDead())
                        {
                            mapString += '\u2020';
                        }
                        else
                        {
                            if (enemy is Goblin)
                            {
                                mapString += 'G';
                            }
                            else if (enemy is Mage)
                            {
                                mapString += "M";
                            }
                            else if(map[x, y] is Gold)
                            {
                                Gold gold = (Gold)map[x, y];//henks code need to fix
                                value += gold.GoldAmount;
                            }


                        }
                    }

                    else if (currentType == Tile.TileType.Item)
                    {
                        if (map[x, y] is Gold)
                        {
                            
                            Gold gold = (Gold)map[x, y];
                            mapString += gold.GoldAmount;
                        }

                    }
                    else if (currentType == Tile.TileType.Empty)
                    {
                        mapString += '.';
                    }
                    else if (currentType == Tile.TileType.Obstacle)
                    {
                        mapString += 'X';
                    }

                }
                mapString += "\n";
            }
            return mapString;
        }




        /*public enum TileType
        {
            Hero,
            Enemy,
            Obstacle,
            Empty,
        }*/
    }


    /* This must go in UptateMap 
     * 
     * if (items != null)
     * {
     * foreach (Item item in items)
     * {
     * map[item.x, item.y] = item;
     * }
     * 
     * if (enemies != null) 
     * {
     * foreach (Enemy enemy in enemies)
     * {
     * map[enemy.x, enemy.y] = enemy;
     * }
     * 
     * if (hero != null)
     * {
     * map[hero.x,hero.y] = hero;
     * }
     */
}
