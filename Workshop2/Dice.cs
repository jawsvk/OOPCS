using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISS.LIB;

namespace Workshop2
{
    class Dice
    {
        int faceUp;

        public Dice()
            {
                Throw();
            }

        public int GetfaceUp()
        {
            return faceUp;
        }


       void Throw()
        {
            faceUp = MyMath.RNDInt(6);
        }

        public string strFaceUp //property to return stringfaceUp
        {
            get
            {
                Throw();
                return Convert.ToString(faceUp);
            }

            set
            {
                faceUp = int.Parse(value);
            }
                  
        }


     }


}



