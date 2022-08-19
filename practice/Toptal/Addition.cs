using System;
namespace practice.Toptal
{
	public class Addition
	{
		public static int solution(int a, int b)
		{
			var aStr = a.ToString();
			var aList = aStr.Select(digit => int.Parse(digit.ToString())).ToList();
			var bStr = b.ToString();
			var bList = bStr.Select(digit => int.Parse(digit.ToString())).ToList();
			//if 1 list is shorther than the other, pad it with leading 0s
			if (aStr.Length - bStr.Length > 0)
            {
				for (var i = 0; i < aStr.Length - bStr.Length; i++)
                {
					i++;
					aList.Prepend(0);
                }
            }
			if (bStr.Length - aStr.Length > 0)
			{
				for (var i = 0; i < bStr.Length - aStr.Length; i++)
				{
					i++;
					bList.Prepend(0);
				}
			}
			var output = 0;
			var carryOver = 0;
			for (var i = bStr.Length-1; i>=0; i--)
            {
				if (aList[i] + bList[i] + carryOver > 9)
                {
					carryOver = 1;
					output++;
                } else
                {
					carryOver = 0;
                }
            }
			return output;
		}
	}
}

