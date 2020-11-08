using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Home
{
    class Door
    {
        private string color;

        public Door(string acolor)
        {
            color = acolor;
        }
        public string GetDoor()
        {
           
            Console.WriteLine("with a door, that is " + color);
             return color;
        }
        /*public string Color
        {
            get { return color; }
            set { color = value; }
        }*/
        //public void ShowData()
        //{
        //    Console.WriteLine("I am a door, My color is " + Color);
        //}
    }
}
