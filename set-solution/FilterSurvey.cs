namespace set_solution;

public class FilterSurvey {
    public List<string> favoriteColors = new List<string>() {
        "blue", "blue", "orange", "red", "yellow", "blue", "cyan", "green", "red", "red", "pink", "yellow", "blue", "blue", "purple", "black", "green", "blue", "gold", "blue", "purple"
    };

    public Dictionary<string, int> surveySummary = new Dictionary<string, int>();

    /// <summary>
    /// Summarize the data in a survey by putting the results in a dictionary.
    /// </summary>
    public void SummarizeSurvey(){

        // Iterate through each color and update the dictionary.
        foreach (var color in favoriteColors) {
            if (surveySummary.ContainsKey(color))
            {
                surveySummary[color] += 1;
            }
            else
            {
                surveySummary[color] = 1;
            }
        }

        // Display the updated dictionary.
        Console.WriteLine($"Color : Number of times chosen");
        surveySummary.ToList().ForEach(colors => Console.WriteLine($"{colors.Key} : {surveySummary[colors.Key]}"));
    }

}