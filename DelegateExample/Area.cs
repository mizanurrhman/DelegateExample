using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateExample
{
   public class Area
    {
        public void Triangle(decimal width, decimal height)
        {
            decimal area = (width * height)/2;
            Console.WriteLine("Area of Triangle is:  " + area) ;
        }
        public void Square(decimal width, decimal height)
        {
            Console.WriteLine("Area of Square is:  " + (width * height)) ;
           
        }
    }
}
