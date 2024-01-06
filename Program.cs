using System;
using System.Collections.Generic;
using vertezml;

class VertezTest
{
    static void Main()
    {   
        // Calculate Mean
        List<double> values = new List<double> { 10, 20, 30, 40, 50 };
        double calc = vertezml.MeanOp.Mean(values);
        Console.WriteLine($"Mean: {calc}");

        // Calculating Median
        double medianCalc = vertezml.MedianOp.Median(values);
        Console.WriteLine($"Median: {medianCalc}");

        // Calculating ANOVA
        List<double> x = new List<double> { 10.0, 20.0, 30.0, 40.0, 50.0, 60.0 };
        List<double> y = new List<double> { 15.0, 25.0, 35.0, 45.0, 55.0, 65.0 };
        var anovaResult = vertezml.AnovaOp.Anova(x,y);
        Console.WriteLine($"SSWG: {anovaResult.sswgOut}");
        Console.WriteLine($"TSS: {anovaResult.tssOut}");
        Console.WriteLine($"ANOVA Result: {anovaResult.anovaRes}");

        // Calculating Standard Deviation
        double calcStdev = vertezml.stdevOp.stdev(values);
        Console.WriteLine($"Standard Deviation: {calcStdev}");
    }
}