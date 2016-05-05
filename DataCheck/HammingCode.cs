using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataCheck
{
    static class HammingCode
    {
        public static string GetHammingCode(this string text, int infWordLength = 16, Encoding enc = null)
        {
            enc = enc ?? Encoding.GetEncoding("windows-1251");

            return string.Join("", text
                .GetBitsString(enc)
                .Split(infWordLength)
                .InsertControlBits()
                .CalcControlBits()
              );
        }

        public static string InsertControlBits(this string infWord)
        {
            var keysCount = GetKeysCount(infWord.Length);
            var code = new char[keysCount + infWord.Length];

            for (int j = 0; j < keysCount; j++) code[(1 << j) - 1] = 'k';

            var index = 0;

            for (int j = 0; j < code.Length; j++)
                if (!code[j].Equals('k')) code[j] = infWord[index++];

            return string.Join("", code);
        }

        public static IEnumerable<string> InsertControlBits(this IEnumerable<string> infWords)
            => infWords.Select(InsertControlBits);

        public static string CalcControlBits(this string oldCode)
        {
            var code = oldCode.ToCharArray();

            for (int j = 0; j < GetKeysCount(oldCode); j++)
            {
                var k = (1 << j) - 1;

                code[k] = (code
                    .Where((ch, ind) => ind > k && ch.Equals('1') && (ind - k) / (k + 1) % 2 == 0)
                    .Count() % 2
                  ).ToString()[0];
            }

            return string.Join("", code);
        }

        public static IEnumerable<string> CalcControlBits(this IEnumerable<string> oldCodes)
            => oldCodes.Select(CalcControlBits); 

        public static string GetBitsString(this string text, Encoding enc = null)
        {
            enc = enc ?? Encoding.GetEncoding("windows-1251");
            
            var result = "";
            var bytes = enc.GetBytes(text);

            foreach (var b in bytes)
                for (var j = 0; j < 8; j++)
                    result += (b >> 7 - j & 1).ToString();

            return result;
        }

        public static int GetKeysCount(int infWordLength)
        {
            var count = 0;
            var remainingBits = infWordLength;

            while (remainingBits > 0)
            {
                remainingBits -= (1 << count) - 1;
                count++;
            }
            
            return count;
        }

        public static int GetKeysCount(string code) => GetKeysCount(code.Length);

        public static IEnumerable<string> Split(this string str, int length)
        {
            var count = str.Length/length;
            for (int i = 0; i < count; i++) yield return str.Substring(i*length, length);
            if (count*length < str.Length) yield return str.Substring(count*length);
        } 
    }
}
