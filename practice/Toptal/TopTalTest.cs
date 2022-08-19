using System;
using System.Collections.Generic;

namespace practice.Toptal
{
	public class TopTalTest
	{
		public static string solution(string message, int K)
		{
			if (message.Length <= K)
            {
				return message;
            }
			var charArray = message.ToCharArray();
			var i = K;
			for (; i<= 0; i--)
            {
				if (charArray[i] == ' ')
                {
					break;
                }
            }
			i--;
            var outputArr = charArray[..^i];
			Console.WriteLine(outputArr);
			return new string(outputArr);
		}
	}
}

