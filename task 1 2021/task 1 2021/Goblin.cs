using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1_2021
{
    [Serializable]
    class Goblin : Enemy
    {
        public Goblin(int x, int y) : base(x, y, 1, 10) // public Goblin(int x, int y) : base(x, y, 1, 10, TileType.Goblin)
        {

        }

        public override Movement ReturnMove(Movement move = Movement.No_Movement)
        {
            int dir = random.Next(1, 5);

            int maxTries = 10;
            int tries = 0;
            while (vision[dir - 1].Type != TileType.Empty && tries < maxTries)
            {
                dir = random.Next(1, 5);
                tries++;

                if (tries == maxTries)
                {
                    return Movement.No_Movement;
                }
            }

            return (Movement)dir;
        }
    }
}
