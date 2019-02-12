using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//There is a robot starting at position (0, 0), the origin, on a 2D plane. Given a sequence of its moves, 
//judge if this robot ends up at (0, 0) after it completes its moves.

namespace LeetCode
{
    class returnToOrigin
    {
        public bool JudgeCircle(string moves)
        {

            int uCount = 0;
            int dCount = 0;
            int lCount = 0;
            int rCount = 0;

            foreach (char x in moves)
            {
                if (x == 'U')
                {
                    uCount += 1;
                }
                if (x == 'D')
                {
                    dCount += 1;
                }
                if (x == 'L')
                {
                    lCount += 1;
                }
                if (x == 'R')
                {
                    rCount += 1;
                }
            }
            if (dCount == uCount && lCount == rCount)
            {
                return true;
            }
            return false;
        }
    }   
}
