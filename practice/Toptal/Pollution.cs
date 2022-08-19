using System;
namespace practice.Toptal
{
	public class Pollution
	{
        public static int solution(int[] A)
        {
            var Adouble = A.Select(x => (double)x).ToArray();
            var sumPollution = Adouble.Sum();
            var currPollution = sumPollution;
            var targetPollution = sumPollution / 2;
            var sortedDesc = Adouble.OrderByDescending(x => x).ToList();
            var filters = 0;
            while (currPollution > targetPollution)
            {
                filters++;
                sortedDesc[0] = sortedDesc[0] / 2;
                currPollution -= sortedDesc[0];
                sortedDesc = sortedDesc.OrderByDescending(x => x).ToList();

            }
            Console.WriteLine(sumPollution);
            return filters;
        }
    }
}

