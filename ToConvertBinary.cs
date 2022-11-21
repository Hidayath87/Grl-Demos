using System;
using System.Text;

class Binary
{

    static void Main(string[] args)
    {
        // binary number as string
        string bin_strng = "1010101010101010";
        int number = 0;

        // converting to integer
        number = Convert.ToInt32(bin_strng, 2);

        // to print  the value
        Console.WriteLine("Number value of binary \"{0}\" is = {1}", bin_strng,
                          number);
    }
}
