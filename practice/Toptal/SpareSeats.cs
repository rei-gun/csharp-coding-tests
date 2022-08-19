using System;
namespace practice.Toptal
{
	public class SpareSeats
	{
        public static int solution(int[] P, int[] S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var spareSeats = new Dictionary<int, int>();
            var carsNeeded = S.Length;
            for (var s = 0; s < S.Length; s++)
            {
                if (S[s] - P[s] > 0)
                {
                    if (!spareSeats.ContainsKey(S[s] - P[s]))
                    {
                        spareSeats.Add(S[s] - P[s], 1);
                    }
                    else
                    {
                        spareSeats[S[s] - P[s]]++;
                    }
                }
                
            }
            
            for (var p = 0; p < P.Length; p++)
            {
                if (spareSeats.ContainsKey(P[p]) && spareSeats[P[p]] > 0)
                {
                    spareSeats[P[p]]--;
                    carsNeeded--;
                }
            }

            return carsNeeded;
        }
    }
}

