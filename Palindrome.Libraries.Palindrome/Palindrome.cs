using System;
using System.Linq;

namespace Palindrome.Libraries.Palindrome
{
    public class Palindrome
    {
        public static string StripPunctuationAndWhiteSpaceFromString(string phrase)
        {
            return new string (phrase.ToCharArray().Where(c => !char.IsPunctuation(c) && !char.IsWhiteSpace(c)).ToArray());
        }

        public static bool IsPalindromeWithArray(string phrase)
        {
            var phraseWithoutPunctuation = StripPunctuationAndWhiteSpaceFromString(phrase).ToLower();
            return phraseWithoutPunctuation == new string (phraseWithoutPunctuation.Reverse().ToArray());
        }

        public static bool IsPalindromeWithSequenceEqual(string phrase)
        {
            var phraseWithoutPunctuation = StripPunctuationAndWhiteSpaceFromString(phrase).ToLower();
            return phraseWithoutPunctuation.SequenceEqual(phraseWithoutPunctuation.Reverse());
        }

        public static bool IsPalindromeWithForLoop(string phrase)
        {
            var phraseWithoutPunctuation = StripPunctuationAndWhiteSpaceFromString(phrase).ToLower();
            int length = phraseWithoutPunctuation.Length;
            int iterations = length / 2;
            for (int i = 0; i < iterations; i++)
            {
                if (phraseWithoutPunctuation[i] != phraseWithoutPunctuation[length - i - 1])
                    return false;
            }
            return true;
        }

        public static bool IsPalindromeWithRecursion(int rightIndex, int leftIndex, char[] phrase)
        {
            if (rightIndex == leftIndex || rightIndex < leftIndex)
                return true;
            else if (phrase[rightIndex] == phrase[leftIndex])
                return IsPalindromeWithRecursion(--rightIndex, ++leftIndex, phrase);
            else
                return false;
        }
    }
}
