namespace adventofcode_2021_day_1
{
    public class MeasurementWindow
    {
        public List<int> Values { get; } = new();

        public void AddValue(int newValue)
        {
            while (Values.Count >= 3)
                Values.RemoveAt(0);

            Values.Add(newValue);
        }
    }
}

