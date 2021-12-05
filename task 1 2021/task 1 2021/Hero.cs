using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1_2021
{
    [Serializable]
    class Hero : Character
    {
        public Hero(int x, int y, int hp) : base(x, y, TileType.Hero)
        {
            this.damage = 2;
            this.hp = hp;
            this.maxHp = hp;
        }


        public override Movement ReturnMove(Movement move = 0)
        {
            int dir = (int)move - 1;
            Tile tile = vision[dir];
            //Tile selectedTile = Vision[(int)move];

            if (tile != null)
            {
                if (tile.Type == TileType.Empty)
                {
                    return move;
                }
            }

            return Movement.No_Movement;


        }
        public override string ToString()
        {
            return "player stats: \n" +
                "hp: " + hp + "/" + maxHp + "\n" +
                "Damage: " + damage + "\n" +
                "[" + x + "," + y + "]";
        }
    }
}
