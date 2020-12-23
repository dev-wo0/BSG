using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleStockGround
{
	class NumberForm
	{
		// 숫자를 서식에 맞춰서 변환해주는 클래스
		  						  //   0     1      2     3     4     5     6     7     8     9    10    11    12   13    14   15
		static string[] Unit = { "일", "십", "백", "천", "만", "억", "조", "경", "해", "자", "양", "구", "간", "정", "재", "극" };

		private static string reverseString(string str)
		{
			string result = "";

			for (int i = str.Length - 1; i >= 0; i--)
				result += str[i];

			return result;
		}

		// 콤마 삽입 메소드 (3글자 마다)
		public static string insertComma3(string num)
		{
			string result = "";
			string tmp = num.ToString();
			int length = tmp.Length;
			int j = 0;

			for (int i = length - 1; i >= 0; i--)
			{
				j++;
				result += tmp[i];
				if ((j % 3 == 0) && (i != 0)) result += ',';
			}

			return reverseString(result);
		}

		// long형 정수에 한글 단위를 추가하여 string으로 반환, space에 true를 주면 공백 추가
		public static string insertUnit(string num, bool space)
		{
			int unit = 4;
			string result = "";
			string tmp = num.ToString();
			int length = tmp.Length;

			int j = 0;

			string zeroSave = "";
			bool nextUnit = false;
			for (int i = length - 1; i >= 0; i--)
			{
				j++;
				if (tmp[i] == '0')
					zeroSave += '0';
				else
				{
					result += zeroSave;
					result += tmp[i];
					zeroSave = "";
				}

				if ((j % 4 == 0) && (i != 0))
				{
					if(space) result += ' ';
					if (!nextUnit)
					{
						result += Unit[unit];
						nextUnit = false;
					}
					if(zeroSave == "0000") nextUnit = true;
					
					unit++;
					zeroSave = "";
				}
			}

			return reverseString(result);
		}

		public static string insertUnitWithComma(string num, bool space)
		{
			int unit = 4;
			string result = "";
			string tmp = num.ToString();
			int length = tmp.Length;

			int j = 0;

			string numSave = "";
			for (int i = length - 1; i >= 0; i--)
			{
				j++;
				numSave += tmp[i];

				if ((j % 4 == 0) && (i != 0))
				{
					if (numSave != "0000")
					{
						if (numSave[3] == '0')
						{
							numSave = "" + numSave[0] + numSave[1] + numSave[2];
						}
						numSave = reverseString(insertComma3(reverseString(numSave)));
						result += numSave;
						if (space) result += ' ';
						result += Unit[unit];
					}
					unit++;

					numSave = "";
				}
			}
			result += numSave;

			return reverseString(result);
		}
	}
}
