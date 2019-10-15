using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeLib = Palindrome.Libraries.Palindrome;

namespace Palindrome.Tests.Palindrome
{
    [TestClass]
    public class PalindromeTest
    {
        [DataTestMethod]
        [DataRow("Racecar", true)]
        [DataRow("A but tuba.", true)]
        [DataRow("A car, a man, a maraca.", true)]
        [DataRow("A dog, a plan, a canal: pagoda.", true)]
        [DataRow("A dog! A panic in a pagoda!", true)]
        [DataRow("A lad named E. Mandala", true)]
        [DataRow("A man, a plan, a canal: Panama.", true)]
        [DataRow("A man, a plan, a cat, a ham, a yak, a yam, a hat, a canal-Panama!", true)]
        [DataRow("A new order began, a more Roman age bred Rowena.", true)]
        [DataRow("A nut for a jar of tuna.", true)]
        [DataRow("A Santa at Nasa.", true)]
        [DataRow("A Santa dog lived as a devil God at NASA.", true)]
        [DataRow("A slut nixes sex in Tulsa.", true)]
        [DataRow("A tin mug for a jar of gum, Nita.", true)]
        [DataRow("A Toyota! Race fast, safe car! A Toyota!", true)]
        [DataRow("A Toyota’s a Toyota.", true)]
        [DataRow("Able was I ere I saw Elba.", true)]
        [DataRow("Acrobats stab orca.", true)]
        [DataRow("Aerate pet area.", true)]
        [DataRow("Ah, Satan sees Natasha!", true)]
        [DataRow("Aibohphobia (fear of palindromes)", false)]
        [DataRow("Air an aria.", true)]
        [DataRow("Al lets Della call Ed Stella.", true)]
        [DataRow("alula", true)]
        [DataRow("Amen icy cinema.", true)]
        [DataRow("Amore, Roma.", true)]
        [DataRow("Amy, must I jujitsu my ma?", true)]
        [DataRow("Ana", true)]
        [DataRow("Animal loots foliated detail of stool lamina.", true)]
        [DataRow("Anna", true)]
        [DataRow("Anne, I vote more cars race Rome to Vienna.", true)]
        [DataRow("Are Mac ‘n’ Oliver ever evil on camera?", true)]
        [DataRow("Are we not drawn onward to new era?", true)]
        [DataRow("Are we not drawn onward, we few, drawn onward to new era?", true)]
        [DataRow("Are we not pure? “No sir!” Panama’s moody Noriega brags. “It is garbage!” Irony dooms a man; a prisoner up to new era.", true)]
        [DataRow("Art, name no tub time. Emit but one mantra.", true)]
        [DataRow("As I pee, sir, I see Pisa!", true)]
        [DataRow("Avid diva.", true)]
        public void IsPalindromeWithArray(string phrase, bool isPalindrome)
        {
            var result = PalindromeLib.Palindrome.IsPalindromeWithArray(phrase);
            Assert.AreEqual(isPalindrome, result);
        }

        [DataTestMethod]
        [DataRow("Racecar", true)]
        [DataRow("A but tuba.", true)]
        [DataRow("A car, a man, a maraca.", true)]
        [DataRow("A dog, a plan, a canal: pagoda.", true)]
        [DataRow("A dog! A panic in a pagoda!", true)]
        [DataRow("A lad named E. Mandala", true)]
        [DataRow("A man, a plan, a canal: Panama.", true)]
        [DataRow("A man, a plan, a cat, a ham, a yak, a yam, a hat, a canal-Panama!", true)]
        [DataRow("A new order began, a more Roman age bred Rowena.", true)]
        [DataRow("A nut for a jar of tuna.", true)]
        [DataRow("A Santa at Nasa.", true)]
        [DataRow("A Santa dog lived as a devil God at NASA.", true)]
        [DataRow("A slut nixes sex in Tulsa.", true)]
        [DataRow("A tin mug for a jar of gum, Nita.", true)]
        [DataRow("A Toyota! Race fast, safe car! A Toyota!", true)]
        [DataRow("A Toyota’s a Toyota.", true)]
        [DataRow("Able was I ere I saw Elba.", true)]
        [DataRow("Acrobats stab orca.", true)]
        [DataRow("Aerate pet area.", true)]
        [DataRow("Ah, Satan sees Natasha!", true)]
        [DataRow("Aibohphobia (fear of palindromes)", false)]
        [DataRow("Air an aria.", true)]
        [DataRow("Al lets Della call Ed Stella.", true)]
        [DataRow("alula", true)]
        [DataRow("Amen icy cinema.", true)]
        [DataRow("Amore, Roma.", true)]
        [DataRow("Amy, must I jujitsu my ma?", true)]
        [DataRow("Ana", true)]
        [DataRow("Animal loots foliated detail of stool lamina.", true)]
        [DataRow("Anna", true)]
        [DataRow("Anne, I vote more cars race Rome to Vienna.", true)]
        [DataRow("Are Mac ‘n’ Oliver ever evil on camera?", true)]
        [DataRow("Are we not drawn onward to new era?", true)]
        [DataRow("Are we not drawn onward, we few, drawn onward to new era?", true)]
        [DataRow("Are we not pure? “No sir!” Panama’s moody Noriega brags. “It is garbage!” Irony dooms a man; a prisoner up to new era.", true)]
        [DataRow("Art, name no tub time. Emit but one mantra.", true)]
        [DataRow("As I pee, sir, I see Pisa!", true)]
        [DataRow("Avid diva.", true)]
        public void IsPanlindromeWithSequenceEquals(string phrase, bool isPalindrome)
        {
            var result = PalindromeLib.Palindrome.IsPalindromeWithSequenceEqual(phrase);
            Assert.AreEqual(isPalindrome, result);
        }

        [DataTestMethod]
        [DataRow("Racecar", true)]
        [DataRow("A but tuba.", true)]
        [DataRow("A car, a man, a maraca.", true)]
        public void IsPalindromeWithForLoop(string phrase, bool isPalindrome)
        {
            var result = PalindromeLib.Palindrome.IsPalindromeWithForLoop(phrase);
            Assert.AreEqual(isPalindrome, result);
        }

        [DataTestMethod]
        [DataRow("Racecar", true)]
        [DataRow("A but tuba.", true)]
        [DataRow("A car, a man, a maraca.", true)]
        public void IsPalindromeWithRecursion(string phrase, bool isPalindrome)
        {
            var phraseWithoutPunctuationOrWhiteSpace = PalindromeLib.Palindrome.StripPunctuationAndWhiteSpaceFromString(phrase).ToLower();
            var result = PalindromeLib.Palindrome.IsPalindromeWithRecursion(
                phraseWithoutPunctuationOrWhiteSpace.Length - 1,
                0,
                phraseWithoutPunctuationOrWhiteSpace.ToCharArray()
            );
            Assert.AreEqual(isPalindrome, result);
        }
    }
}
