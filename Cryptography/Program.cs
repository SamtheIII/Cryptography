using Cryptography;

namespace cryptograhpy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CaesarCipher cc = new CaesarCipher();
            string encryptedWord = cc.CaesarEncrypt("Hail Caesar!", 5);
            Console.WriteLine(encryptedWord);
            Console.WriteLine(cc.CaesarDecrypt(encryptedWord, 5));

        }
    }

}
