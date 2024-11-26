using System;
using System.Collections;

namespace OldPhoneKeypadAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OldPhonePad("33#")); // E
            Console.WriteLine(OldPhonePad("227*#")); // B
            Console.WriteLine(OldPhonePad("4433555 555666#")); //HELLO
            Console.WriteLine(OldPhonePad("8 88777444666*664#")); // TURING
            Console.WriteLine(OldPhonePad("222 2 22")); // CAB

            //Console.WriteLine(OldPhonePad("227#")); // BP
            //Console.WriteLine(OldPhonePad("222344")); // CDH
            Console.WriteLine(OldPhonePad("329666 6663*3")); // DAWOOD
            Console.WriteLine(OldPhonePad("2*244 633 3")); // AHMED
        }

        public static string OldPhonePad(string input)
        {
            // Hashtable is used because of its O(1) complexity
            var keypad = new Hashtable()
            {
                {"2",   "A"},
                {"22",  "B"},
                {"222", "C"},
                {"3",   "D"},
                {"33",  "E"},
                {"333", "F"},
                {"4",   "G"},
                {"44",  "H"},
                {"444", "I"},
                {"5",   "J"},
                {"55",  "K"},
                {"555", "L"},
                {"6",   "M"},
                {"66",  "N"},
                {"666", "O"},
                {"7",   "P"},
                {"77",  "Q"},
                {"777", "R"},
                {"7777","S"},
                {"8",   "T"},
                {"88",  "U"},
                {"888", "V"},
                {"9",   "W"},
                {"99",  "X"},
                {"999", "Y"},
                {"9999","Z"}
            }; 

            string lastNumber = string.Empty;
            string result = string.Empty;
            foreach (var c in input)
            {
                if (c == '#')
                {
                    break;
                }

                if (c == ' ' || !lastNumber.Contains(c))
                {
                    result += keypad[lastNumber];
                    lastNumber = string.Empty;
                }

                lastNumber += c;

                if (c == '*' && result.Length > 0)
                {
                    result = result.Substring(0, result.Length - 1);
                }
            }

            result += keypad[lastNumber];

            return result;
        }
    }
}
