using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1_2021
{
    [Serializable]
    abstract class Character : Tile
    {
        //the protected variabes with access modifiers second test
        protected int hp;
        protected int maxHp;
        protected int damage;
        protected Tile[] vision;
        protected Movement movement;
        Random random = new Random();
        protected int goldPurse = 0;

        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }

        public int GoldPurse
        {
            get { return goldPurse; }
            
        }

        public int MaxHP
        {
            get { return maxHp; }

        }

        public int Damage
        {
            get { return damage; }
        }

        public Tile[] Vision
        {
            get { return vision; }

        }

        public Character(int x, int y, TileType type) : base(x, y, type)
        {
            vision = new Tile[4]; //0 = up, 1 = down, 2 = left, 3 = right 
        }

        public virtual void Attack(Character target)
        {
            target.HP -= this.damage;
        }
        public bool IsDead()
        {
            return hp <= 0;
        }

        public virtual bool CheckRange(Character target)
        {
            //return DistanceTo(target) <= 1;
            for(int nx = -1; nx <= 1; nx++)
            {
                for(int ny = -1; ny <= 1; ny++)
                {
                    if(nx == 0 && ny == 0)
                    {
                        continue;
                    }
                    if(x + nx == target.X && y + ny == target.Y)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private int DistanceTo(Character target)
        {
            int xDist = Math.Abs(target.X - x);
            int yDist = Math.Abs(target.Y - y);

            return xDist + yDist;
        }

        public void Move(Movement movement)
        {
            switch (movement)
            {
                case Movement.Up: y -= 1; break;
                case Movement.Down: y += 1; break;
                case Movement.Left: x -= 1; break;
                case Movement.Right: x += 1; break;
            }
        }

        public void SetVision(Tile up, Tile down, Tile left, Tile right)
        {
            vision[0] = up;
            vision[1] = down;
            vision[2] = left;
            vision[3] = right;
        }

        public void Pickup(Item item)
        {
            if (item is Gold)
            {
                Gold gold = (Gold)item;
                goldPurse += gold.GoldAmount;
            }
        }

        public override Movement ReturnMove(Movement move = Movement.No_Movement)
        {
            int moveDir;
            int tries = 10;

            do
            {
                moveDir = random.Next(0, 4);
                tries--;

                if (tries == 0)
                {
                    return Movement.No_Movement;
                }
            } while (!(Vision[moveDir] is EmptyTile));

            return Movement(moveDir); //fix it
        }

        public abstract override string ToString();

        public void UpdateVision(Map map)
        {
            vision[0] = map.GetTileAt(x, y - 1);
            vision[1] = map.GetTileAt(x + 1, y);
            vision[2] = map.GetTileAt(x, y + 1);
            vision[3] = map.GetTileAt(x - 1, y);
        }


    }


    


    public enum Movement
    {
        No_Movement,     //0
        Up,              //1
        Down,            //2
        Left,            //3
        Right            //4
    }
}
