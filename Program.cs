using System;
using System.Collections.Generic;
using vertezml;

class VertezTest
{
    static void Main()
    {   
        // Calculate Mean
        List<double> values = new List<double> { 10, 20, 30, 40, 50 };
        double calc = vertezml.MeanOp.CalculateMean(values);
        Console.WriteLine(calc);
    }
}
