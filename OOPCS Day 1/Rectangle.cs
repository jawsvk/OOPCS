using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Day_1
{
    class Rectangle
    {
        int length;
        int breadth;

        public int Length { get; set; }

        public int Area
        {
            get
            {
                return length * breadth; //this will also work even though there is no attribute called Area 
            }
        }

        int GetArea()
        {
            return length * breadth;
        }
    }
}
