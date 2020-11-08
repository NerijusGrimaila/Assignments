using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Home
{
    class SubApart : House
    {
        public int area = 50;
        private int apartArea;

        public SubApart(int A) : base(A)
        {
            apartArea = A;
        }
        public override void ShowData()
        {
            Console.WriteLine("and a small apartament of " + apartArea + "m2");
            
        }
      

        
        
        
        
    
        
         


    }
    
}
