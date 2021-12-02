using Day2;

var runner = new Runner("input.txt");

var initialState = new State(0, 0);

var result = await runner.GetResultAsync(initialState);

Console.WriteLine(result.Depth * result.Horizontal);
