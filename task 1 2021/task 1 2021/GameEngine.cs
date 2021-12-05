using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace task_1_2021
{
    class GameEngine
    {
        Map map;
        bool isGameOver = false;
        const string SAVE_FILE_NAME = "gamesave.txt";

        public Map Map
        {
            get { return map;  }
        }


        public string PlayerStats
        {
            get { return map.Hero.ToString(); }
        }

        public bool IsGameOver
        {
            get { return isGameOver; }
        }

        public void Save()
        {
            FileStream stream = new FileStream(
            SAVE_FILE_NAME, FileMode.Create, FileAccess.Write
            );
            StreamWriter writer = new StreamWriter(stream);

            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, map);

            stream.Close();
        }

        public bool Load()
        {
            if (!File.Exists(SAVE_FILE_NAME))
            {
                return false;
            }

            FileStream stream = new FileStream(
            SAVE_FILE_NAME, FileMode.Open, FileAccess.Read
            );
            BinaryFormatter bf = new BinaryFormatter();           

            map = (Map)bf.Deserialize(stream);

            stream.Close();
            return true;
        }
        public string HeroStats
        {
            get { return map.Hero.ToString(); }
        }
        

        public GameEngine()
        {
            map = new Map(10, 20, 10, 20, 10, 0);
        }
        public string View
        {
            get { return map.ToString(); }
        }


        public bool MovePlayer(Movement desiredMove)
        {
            if (isGameOver)
            {
                return false;
            }

            Movement allowedMove = map.Hero.ReturnMove(desiredMove);
            map.Hero.Move(allowedMove);
            map.Update();

            if (map.Hero.ReturnMove(desiredMove) == Movement.No_Movement)
            {
                return false;   
            }

            int oldPlayerX = map.Hero.X;
            int oldPlayerY = map.Hero.Y;

            map.Hero.Move(desiredMove);

            map.SetEmptyTile(oldPlayerX, oldPlayerY);
            map.Hero.Move(desiredMove);

            EnemiesMove();
            EnemiesAttack();

            map.UpdateVision();         

            Item item = map.GetItemAtPosition(map.Hero.X, map.Hero.Y);
            if (item != null)
            {
                map.Hero.Pickup(item);
            }

            map.Update();

            if (allowedMove == Movement.No_Movement)
            {
                return false;
            }

            if (map.Hero.IsDead())
            {
                isGameOver = true;
            }

            return true;
        }


        




        public string PlayerAttack(Movement dir)
        {
            int visionIndex = (int)dir;
            string failMessage = "Hero attack failed";
            if (map.Hero.Vision[visionIndex].Type == Tile.TileType.Enemy)
            {
                Enemy enemy = (Enemy)map.Hero.Vision[visionIndex];
                if (enemy.IsDead())
                {
                    return failMessage;
                }
                map.Hero.Attack(enemy);
                //return enemy;
                EnemiesAttack();
                map.Update();

                if (enemy.IsDead())
                {
                    return "Hero killed enemy";//im not undertanding this error
                }

                return "Hero attacked enemy"; 

            }
            return failMessage ;
        }

        void EnemiesMove()
        {
            foreach (Enemy enemy in map.Enemies)
            {
                if (enemy.IsDead())
                {
                    continue;
                }

                Movement move = enemy.ReturnMove();
                enemy.Move(move);
            }
        }

        void EnemiesAttack()
        {
            if (IsGameOver)
            {
                
            }

            foreach (Enemy enemy in map.Enemies)
            {
                if (enemy.IsDead())
                {
                    continue;
                }
                if (enemy is Mage)
                {
                    MageAttack((Mage)enemy);
                }
                if (enemy is Goblin)
                {
                    GoblinAttack((Goblin)enemy);
                }
            }
        }

        private void GoblinAttack(Goblin goblin)
        {
            if (goblin.CheckRange(map.Hero))
            {
                goblin.Attack(map.Hero);
            }
        }

        private void MageAttack(Mage mage)
        {
            if (mage.CheckRange(map.Hero))
            {
                mage.Attack(map.Hero);
            }
            foreach (Enemy target in map.Enemies)
            {
                if (mage == target)
                {
                    continue;
                }

                if (!mage.CheckRange(target))
                {
                    continue;
                }

                mage.Attack(target);
            }
        }

    }
}
