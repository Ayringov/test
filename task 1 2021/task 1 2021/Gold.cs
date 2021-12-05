using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1_2021
{
    [Serializable]
    class Gold : Item
    {
        private int goldAmount;
        static Random random = new Random();
        const int MIN_AMOUNT_AMOUNT = 1;
        const int MAX_GOLD_AMOUNT = 5;

        public int GoldAmount
        {
            get { return goldAmount; }

        }
        public Gold(int x, int y) : base(x, y)
        {
            goldAmount = random.Next(1, 6);
        }
        public override string ToString()
        {
            return "";
        }
    }
}
