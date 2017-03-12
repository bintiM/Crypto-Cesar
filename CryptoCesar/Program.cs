using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCesar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Geben Sie den zu verschlüsselnden Text ein!");

            var klar = Console.ReadLine();

            var verschl = encryptTextEng(klar, 8); // mit Verschiebung 8 verschlüsseln

            Console.WriteLine("Der verschlüsselte Text lautet:");
            Console.WriteLine(verschl);
            

            Console.ReadLine();

        }




        //Die Methode bekommt den klartext und einen Schlüssel als Parameter
        public static string encryptTextEng(string plainText, int keyValue)
        {
            string encText = ""; //Hier wird der verschlüsselte Text gespeichert
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            //Iteriere durch jedes Zeichen im Klartext
            foreach (char c in plainText.ToUpper())
            {
                //Prüfe ob das Zeichen ein Buchstabe im Alphabet ist
                if (alphabet.Contains(c))
                {
                    //Wenn ja, berechne die neue Position und füge den neuen Buchstaben
                    //dem verschlüsselten Text hinzu
                    var shift = Array.IndexOf(alphabet, c) - keyValue; // + für verschlüsseln

                    if (shift <= 0)
                        shift = shift + 26;

                    if (shift >= 26)
                        shift = shift - 26;

                    encText += alphabet[shift];
                }
                else
                {
                    //Ansonsten übernehme das Zeichen
                    //Beispielsweise Leerzeichen, Satzzeichen unverschlüsselt in den verschlüsselten Text
                    encText += c;
                }
            }

            return encText;
        }

    }

}
