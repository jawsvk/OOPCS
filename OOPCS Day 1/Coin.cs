using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISS.LIB;

namespace OOPCS_Day_1
{
    class Coin
    {
        int face;  //implementation detail that need not be revealed to increase complexity

       public int Flip()
        {
            face = MyMath.RNDInt(2);
            return face;
        }

        public int GetFace()
        {
            return face;
        }
    }
}
