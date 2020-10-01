using System;
using System.Collections.Generic;

namespace Tramp
{
    class RandomScore
    {
        public List<int> RandomPlay()
        {
            Random random = new Random();
            List<int> val = new List<int>();
            while (true)
            {
                int randomScore = random.Next(0, 10);

                if (!val.Contains(randomScore))
                {
                    val.Add(randomScore);
                }

                if (val.Count == 10)
                {
                    break;
                }
            }
            return val;
        }
    }
}
