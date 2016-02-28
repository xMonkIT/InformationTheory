using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataReduction
{
    public class Alphabet : IEnumerable
    {
        public class AlphabetChar
        {
            public char Char { get; }
            public int Frequency { get; }

            public AlphabetChar(char ch, int frequency)
            {
                Char = ch;
                Frequency = frequency;
            }
        }

        readonly List<AlphabetChar> _alphabet;
        readonly string _incoming;

        public Alphabet(string incoming)
        {
            var dict = new Dictionary<char, int>();

            foreach (var ch in incoming)
            {
                if (!dict.ContainsKey(ch)) dict.Add(ch, 0);
                dict[ch]++;
            }

            _incoming = incoming;
            _alphabet = dict.Select(x => new AlphabetChar(x.Key, x.Value)).ToList();
        }

        public int GetFrequency(char ch)
        {
            foreach (var item in _alphabet)
            {
                if (item.Char.Equals(ch)) return item.Frequency;
            }
            throw new IndexOutOfRangeException();
        }

        public double GetRelativeFrequency(char ch)
        {
            foreach (var item in _alphabet)
            {
                if (item.Char.Equals(ch)) return (double)item.Frequency / CharCount;
            }
            throw new IndexOutOfRangeException();
        }

        public double this[char ch] => GetFrequency(ch);

        public IEnumerable<char> Chars => _alphabet.Select(x => x.Char);

        public int CharCount => _incoming.Length;

        public int GetBitCount(Encoding enc) => enc.GetByteCount(_incoming) * 8;

        public double GetBitPerChar(Encoding enc) => (double)GetBitCount(enc) / CharCount;

        public double Entropy => _alphabet.Sum(x => -GetRelativeFrequency(x.Char) * Math.Log(GetRelativeFrequency(x.Char), 2));

        public void Sort(Comparison<AlphabetChar> comparison) => _alphabet.Sort(comparison);

        public void SortByFrequency(bool reverse = false) => Sort((x, y) => (reverse ? -1 : 1) * x.Frequency.CompareTo(y.Frequency));

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)_alphabet).GetEnumerator();
        }
    }
}
