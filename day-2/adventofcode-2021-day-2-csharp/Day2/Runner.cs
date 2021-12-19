using System;

namespace Day2
{
    public class Runner
    {
        public string Filename { get; }

        public Runner(string filename)
        {
            Filename = filename;
        }

        public async Task<State> GetResultAsync(State state)
        {
            foreach (var line in await File.ReadAllLinesAsync(Filename))
            {
                state = ParseLine(line, state);
            }

            return state;
        }

        private static State ParseLine(string line, State state)
        {
            const string regex = @"(?<Instruction>\w+) (?<Argument>\d+)";

            var match = System.Text.RegularExpressions.Regex.Match(line, regex);

            var instruction = match.Groups["Instruction"].Value;
            var argument = int.Parse(match.Groups["Argument"].Value);

            switch (instruction)
            {
                case "forward":
                    return state with
                    {
                        Horizontal = state.Horizontal + argument,
                        Depth = state.Depth + state.Aim * argument
                    };

                case "down":
                    return state with
                    {
                        Aim = state.Aim + argument
                    };

                case "up":
                    return state with
                    {
                        Aim = state.Aim - argument
                    };

                default:
                    throw new ArgumentException(nameof(instruction));
            }
        }
    }
}

