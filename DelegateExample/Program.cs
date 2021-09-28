using System;

namespace DelegateExample
{
    //public delegate void DelArea(decimal width, decimal height);
    //public delegate decimal Delg(decimal width, decimal height);


    delegate int method(int a, int b);

    class Program
    {


        static void Main(string[] args)
        {
            int firstNumber = 5;
            int secondNumber = 9;

            method aMethod = Formula;

            ApplyFormula(aMethod, firstNumber, secondNumber);

            //or
            /* var executeDel = aMethod(firstNumber, secondNumber);
             Console.WriteLine(executeDel);
            */

            // for cal a methode from outside and send it to other methode parameter, we can pass here logic here parameter 
            int[] numbers = new int[] { 10, 20, 30, 40, 50 };

            qsort(numbers, 0, numbers.Length, compare);
        }

        private static void qsort(int[] numbers, int v, int length, Func<int, int, int> compare)
        {
            throw new NotImplementedException();
        }

        static int compare(int num1, int num2)
        {
            return num1 == num2 ? 0 : num1 < num2 ? 1 : 1;
        }

        static void ApplyFormula(method aMethode, int a, int b)
        {
            var callDelegate = aMethode(a, b);

            Console.WriteLine(callDelegate);
        }
        static int Formula(int a, int b)
        {
            return a * 5 + 2 * b - 3;

        }


        #region Delegate Example first
        /* static void Main(string[] args)
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
             //func with output paramater
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
        */
        #endregion
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
