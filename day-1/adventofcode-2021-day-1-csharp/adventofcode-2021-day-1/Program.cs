var lines = await File.ReadAllLinesAsync("input.txt");

int count = 0;
int? previousMeasurement = null;

foreach (var item in lines)
{
    var currentMeasurement = int.Parse(item);

    if (previousMeasurement == null)
        previousMeasurement = currentMeasurement;

    if (currentMeasurement > previousMeasurement)
        count++;

    previousMeasurement = currentMeasurement;
}

Console.WriteLine(count);
