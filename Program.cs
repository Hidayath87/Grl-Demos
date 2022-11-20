using System;
using System.Text;

class Program
{

    static void Main(string[] args)
    {
        // hexadecimal number as string
        string input = "56304";
        int output = 0;

        // converting to integer
        output = Convert.ToInt32(input, 16);

        // to print  the value
        Console.WriteLine("Integer number: " + output);
    }
}