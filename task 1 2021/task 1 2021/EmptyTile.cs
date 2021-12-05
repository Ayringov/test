using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1_2021
{
    [Serializable]
    class EmptyTile : Tile
    {
        public EmptyTile(int x, int y) : base(x, y, TileType.Empty)
        {

        }
    }
}
