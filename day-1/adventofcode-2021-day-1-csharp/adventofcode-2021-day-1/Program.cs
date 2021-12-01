using adventofcode_2021_day_1;

var lines = await File.ReadAllLinesAsync("input.txt");

int count = 0;

int previousSum = 0;
var window = new MeasurementWindow();

foreach (var item in lines)
{
    var currentMeasurement = int.Parse(item);

    window.AddValue(currentMeasurement);

    Console.WriteLine($"window is now {string.Join(", ", window.Values)}");

    if (window.Values.Count < 3)
        continue;

    var newSum = window.Values.Sum();

    if (previousSum > 0 && newSum > previousSum)
    {
        Console.WriteLine($"previousSum was {previousSum}, newSum is {newSum}");
        count++;
    }

    previousSum = newSum;
}

Console.WriteLine(count);
