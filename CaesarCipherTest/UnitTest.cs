using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaesarCipher;

namespace CaesarCipherTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Test1()
        {
            Cipher cipher = new Cipher();

            string input = "thequickbrownfoxjumpsoverthelazydog";
            int key = -3;
            string result = cipher.Encryption(input, key);

            Assert.AreEqual("qebnrfzhyoltkclugrjmplsboqebixwvald", result);
        }
        [TestMethod]
        public void Test2()
        {
            Cipher cipher = new Cipher();

            string input = "qebnrfzhyoltkclugrjmplsboqebixwvald";
            int key = -3;
            string result = cipher.Decryption(input, key);

            Assert.AreEqual("thequickbrownfoxjumpsoverthelazydog", result);
        }
        [TestMethod]
        public void Test3()
        {
            Cipher cipher = new Cipher();

            string input = "docd";
            int key = 10;
            string result = cipher.Decryption(input, key);

            Assert.AreEqual("test", result);
        }
        [TestMethod]
        public void Test4()
        {
            Cipher cipher = new Cipher();

            string input = "TesT";
            int key = 10;
            string result = cipher.Encryption(input, key);
            result = cipher.Decryption(result, key);

            Assert.AreEqual("TesT", result);
        }
        [TestMethod]
        public void Test5()
        {
            Cipher cipher = new Cipher();

            string input = "EduJmeJxhuu";
            int key = 16;
            string result = cipher.Decryption(input, key);
            key = 10;
            result = cipher.Encryption(result, key);
            result = cipher.Decryption(result, key);

            Assert.AreEqual("OneTwoThree", result);
        }
    }
}
