### Delegate
- delcalre delegate name as methode `delegate int method(int a, int b);`
- assign a function to a variable ` method aMethod = Formula;` 
- cal the the fuction where implement 
` ApplyFormula(aMethod, firstNumber, secondNumber);`
```cs
static int Formula(int a, int b)
{
    return a * 5 + 2 * b - 3;
}
```

```cs
static void ApplyFormula(method aMethode, int a, int b)
    {
        var callDelegate = aMethode(a, b);
        Console.WriteLine(callDelegate);
    }
```