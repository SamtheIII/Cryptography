using System.Text;

namespace Cryptography
{
    //In Caesar cipher every letter is replaced by an integer called shift or key. word = Crypto shift = 3 then C would be replaced by p
    internal class CaesarCipher
    {

        public string CaesarEncrypt(string word, int shift)
        {
            StringBuilder sb = new();

            for (int i = 0; i < word.Length; i++)
            {
                int indexToShift = CalculateEncryptIndex(i, shift, word.Length);

                sb.Append(word[indexToShift]);
            }

            return sb.ToString();

        }

        public string CaesarDecrypt(string word, int shift)
        {
            StringBuilder sb = new();

            for (int i = 0; i < word.Length; i++)
            {
                int indexToShift = CalculateDecryptIndex(i, shift, word.Length);

                sb.Append(word[indexToShift]);
            }

            return sb.ToString();

        }


        private int CalculateEncryptIndex(int index, int shift, int length)
        {
            if ((index + shift) > length-1)
            {
                return (index+shift) - length;
            }

            return index + shift;

        }

        private int CalculateDecryptIndex(int index, int shift, int length)
        {
            int varIndex = Math.Abs((index - shift) + length);
            if(varIndex >= length)
            {
                return varIndex - length;
            }
            return varIndex;
        }

    }
}
