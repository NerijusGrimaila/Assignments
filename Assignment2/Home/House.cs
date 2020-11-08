using System;
using System.Collections.Generic;
using System.Text;

namespace Home
{
    public class House
    {
        private int area;
        
        
        

        public House(int houseArea)
        {
            area = houseArea;
   
        }

        public int Area
        {
            get { return area; }
            set { area = value; }
        }


        public virtual void ShowData()
        {

            Console.WriteLine("a house, with area of " + area + "m2");
        }

    }
}
