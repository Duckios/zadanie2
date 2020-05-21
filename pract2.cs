using System;
using static System.Console;
using static System.Convert;
using static System.String;

namespace pract2
{
    class Program
    {
        static void Main(string[] args)
        {
            int zadanie = ToInt32(ReadLine());
            
            switch (zadanie)
            {
                case 1:
                    string word = ReadLine();
                    int z = 0;
                    int x = -1;
                    for (int i = 0; i < word.Length; i++)
                    {
                        x++;
                        if (word[i] == 'f')
                        {
                            z++;
                            if (z == 2) break;
                        }
                    }
                    if (z == 1) Write("-1");
                    else if (z == 0) Write("-2");
                    else Write("Индекс = " + x);
                    break;

                case 2:
                    string word2 = ReadLine();
                    string[] rus = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", 
                        "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
                    string[] eng = { "a", "b", "v", "g", "d", "e", "e", "zh", "z", "i", "y", "k", "l", "m", "n", 
                        "o", "p", "r", "s", "t", "u", "f", "kh", "ts", "ch", "sh", "sch", "", "", "'", "e", "yu", "ya" };
                    string vivod = "";

                    for (int i = 0; i < word2.Length; i++)
                    {
                        int b = 0;
                        while (b < rus.Length)
                        {
                            string w = word2[i] + "";
                            if (Compare(w, rus[b]) == 0)
                            {
                                vivod = vivod + eng[b];
                                b++;
                            }
                            else b++;
                        }
                    }
                    Write(vivod);
                    break;
                case 3:
                    string word3 = ReadLine();
                    int min = word3.IndexOf("h");
                    int max = word3.LastIndexOf("h");
                    string newWord3 = "";
                    for (int i = 0; i < word3.Length; i++)
                    {
                        string ww = word3[i] + "";
                        if (Compare("h", ww) == 0 && i != min && i != max)
                        {
                            newWord3 = newWord3 + "H";
                        }
                        else newWord3 = newWord3 + word3[i];
                    }
                    WriteLine(newWord3);

                    break;
            }
        }
    }
}
