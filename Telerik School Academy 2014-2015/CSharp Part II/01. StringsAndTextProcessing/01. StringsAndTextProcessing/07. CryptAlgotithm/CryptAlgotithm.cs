using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CryptAlgotithm
{
    class CryptAlgotithm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for encode and 2 for decode");
            int key = int.Parse(Console.ReadLine());

            switch (key)
            {
                case 1 :
                    Console.WriteLine("Enter sting: ");
                    char[] text = Console.ReadLine().ToCharArray();
                    Console.WriteLine("Enter encryption key: ");
                    char[] word = Console.ReadLine().ToCharArray();

                    
                    int len = text.Length;
                    int wordLen = word.Length;
                    char[] result = new char[len];
                    for (int i = 0; i < len; i++) {
                        char encryptedChar = (char)(text[i] ^ word[i % wordLen]);
                        result[i] = encryptedChar;
                    }

                    Console.WriteLine(result);
                    break;
                
                
                case 2:
                    Console.WriteLine("Enter sting for decode: ");
                    char[] decode = Console.ReadLine().ToCharArray();
                    Console.WriteLine("Enter encryption key: ");
                    char[] dKey = Console.ReadLine().ToCharArray();

                    
                    int decodeLen = decode.Length;
                    int dKeyLen = dKey.Length;
                    char[] code = new char[decodeLen];
                    for (int i = 0; i < decodeLen; i++) {
                        char encryptedChar = (char)(decode[i] ^ dKey[i % dKeyLen]);
                        code[i] = encryptedChar;
                    }

                    Console.WriteLine(code);
                    break;
                default: Console.WriteLine("Invalid key");
                    break;
            }
            
        }
    }
}
