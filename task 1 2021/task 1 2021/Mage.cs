using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1_2021
{
    [Serializable]
    class Mage : Enemy
    {
       public Mage (int x, int y) : base(x, y, 5, 5)
        {

        }
        public override Movement ReturnMove(Movement move = Movement.No_Movement)
        {
            return base.ReturnMove(move);
        }

        public override bool CheckRange(Character target)
        {
            return base.CheckRange(target);
        }
    }
}
