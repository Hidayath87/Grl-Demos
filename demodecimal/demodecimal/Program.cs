using System;
public class Demo
{
    public static void Main()
    {
        decimal decimalVal;
        string stringVal = "2,345.26";
        decimalVal = System.Convert.ToDecimal(stringVal);
        System.Console.WriteLine("String converted to decimal = {0} ", decimalVal);
    }
}