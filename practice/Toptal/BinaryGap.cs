using System;
namespace practice.Toptal
{
	public class BinaryGap
	{
        public static int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var binary = Convert.ToString(N, 2).ToCharArray();
            Console.WriteLine(binary);
            var output = 0;
            var isGap = false;
            var currGap = 0;
            for (var i = 1; i<binary.Length; i++)
            {
                if (binary[i] == '0' && isGap == false)
                {
                    isGap = true;
                    currGap++;

                } else if (binary[i] == '0' && isGap == true)
                {
                    currGap++;
                }
                else if (binary[i] == '1' && isGap == true)
                {
                    if (currGap > output)
                    {
                        output = currGap;
                    }
                    isGap = false;
                    currGap = 0;
                }
            }
            Console.WriteLine(output);
            return output;
        }
    }
}

