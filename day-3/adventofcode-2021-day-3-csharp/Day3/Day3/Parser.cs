using System;
using System.Collections;

namespace Day3
{
	public class Parser
	{
        public string Filename { get; }

		public Parser(string filename)
		{
			Filename = filename;
		}

        public async Task<BitArray[]> ParseIntoBitArrays()
        {
            var results = new List<BitArray>();

            foreach (var line in await File.ReadAllLinesAsync(Filename))
            {
                var length = line.Length;

                var array = new BitArray(length);

                for (int i = 0; i < length; i++)
                {
                    if (line[i] == '1')
                        array[i] = true;
                }

                results.Add(array);
            }

            return results.ToArray();
        }

        public static bool GetMostCommonBit(BitArray[] arrays, int position)
        {
            return _GetBitCountsForPosition(arrays, position).OrderBy(kvp => kvp.Value).Last().Key;
        }

        public static bool GetLeastCommonBit(BitArray[] arrays, int position)
        {
            return _GetBitCountsForPosition(arrays, position).OrderBy(kvp => kvp.Value).First().Key;
        }

        private static Dictionary<bool, int> _GetBitCountsForPosition(BitArray[] arrays, int position)
        {
            return arrays.Select(a => a[position]).GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
        }

        public static int GetGamma(BitArray[] arrays)
        {
            int gamma = 0;

            int width = arrays.First().Length;

            for (int i = 0; i < width; i++)
            {
                var mostCommonBit = GetMostCommonBit(arrays, i);

                if (mostCommonBit)
                    gamma += 1 << (width - i - 1);
            }

            return gamma;
        }

        public static int GetEpsilon(BitArray[] arrays)
        {
            int epsilon = 0;

            int width = arrays.First().Length;

            for (int i = 0; i < width; i++)
            {
                var mostCommonBit = GetLeastCommonBit(arrays, i);

                if (mostCommonBit)
                    epsilon += 1 << (width - i - 1);
            }

            return epsilon;
        }
    }
}
