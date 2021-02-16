using System;

namespace DelegateExample
{
    public delegate void DelArea(decimal width, decimal height);
    public delegate decimal Delg(decimal width, decimal height);
    class Program
    {
        static void Main(string[] args)
        {
            Area area = new Area();
            //initialize deligate with method from object
            DelArea delArea = new DelArea(area.Triangle);
            //add 2nd methode for same delegate
            delArea += area.Square;


            Console.WriteLine("Delegate for multiple methode");
            Console.WriteLine("------------------------------");
            //call delegate
            delArea.Invoke(3, 3);

            Console.WriteLine("--------------------");

            //Anonymous method 
            Delg aDelegate = delegate (decimal width, decimal height)
             {
                 return width * height;
             };
            decimal result = aDelegate(2, 3);
            Console.WriteLine("Anonymous Methode result is : " + result);

            //Two types of delegates are Func and Action 
            //delegate   Func: should at least one return type 
            //delegate Action: those delegate dont have return type 

            //Func Example
            Func<decimal, decimal, decimal> delFunc = delegate (decimal width, decimal height)
                {
                    return width * height;
                };
            decimal resultFunc = delFunc(2, 3);
            Console.WriteLine("Func result is : " + result);

            //Action Example
            Action actionDel = delegate ()
            {
                Console.WriteLine("Action delegate don't have parameter or return type");
            };
            //call action delegate 
            actionDel();


            //Example: If Action delegate need to pass parameter  
            Action<int, string> actionDelParam = delegate (int number, string name)
            {
                Console.WriteLine($"Action Delegate with parameter Number is : { number} and Name is {name}");
            };
            //call action delegate with parameter 
            actionDelParam(1234, "One two three four...");


            //Func Example with Lambda Statement
            //Lambda Expression, Expression is combination of operator and operand 
            Func<decimal, decimal, decimal> delLmbdaStatement = delegate (decimal width, decimal height)
                        {
                            return width * height;
                        };
            decimal resultlS = delLmbdaStatement(2, 3);
            Console.WriteLine("Func result is : " + resultlS);
            //another way in single line 

            Func<decimal, decimal, decimal> delLmbdaExpression = (decimal width, decimal height) => width * height;
            decimal resultLmbdaEx = delLmbdaStatement(2, 3);
            Console.WriteLine("Func result Lambda Expression is : " + resultLmbdaEx);

            //or
            Func<decimal, decimal, decimal> delLmbdaEx = (x, y) => x * y;
            decimal resultSortLmbdaEx = delLmbdaEx(2, 3);
            Console.WriteLine("More shorter Lambda Expression is : " + resultSortLmbdaEx);

            //only Action Expression  
            Action delAction = () => { };
            delAction();

            Console.ReadLine();


        }
    }
    /*
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
     */
}
