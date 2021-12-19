using Day3;

var runner = new Parser("input.txt");

var arrays = await runner.ParseIntoBitArrays();

var gamma = Parser.GetGamma(arrays);
var epsilon = Parser.GetEpsilon(arrays);

Console.WriteLine(gamma * epsilon);
