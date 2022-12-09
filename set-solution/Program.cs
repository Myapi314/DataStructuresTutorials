using System;
namespace set_solution;

public static class Program {
    public static void Main()
    {
        var filter = new FilterSurvey();
        Console.WriteLine("Lets look at the results of the color survey:");
        filter.SummarizeSurvey();

    }
}

