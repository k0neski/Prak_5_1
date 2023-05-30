/* Подсчитать количество слов, в которые буква «а» входит не менее двух раз. Слова 
обязательно разделены пробелом.*/
using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string text = "Это тестовый текст для проверки работы программы. В нем должно быть не менее" +
            " пяти предложений. Сейчас мы попробуем выделить двухбуквенные слова и подсчитать их количество" +
            ". Например, в тексте 'в нем' слово 'в' и слово 'нем' относятся к двухбуквенным словам. А слова," +
            " в которых буква 'а' встречается не менее двух раз: кабан, сарай, абажур, абак.";

        string[] words = text.Split(' ');
        int count1 = 0;
        foreach (string word in words)
        {
            int count = 0;
            foreach (char c in word)
            {
                if (c == 'a')
                {
                    count++;
                }
            }
            if(count >= 2)
            {
                count1++;
            }

        }
        Console.WriteLine($"Количество слов с двумя и более буквами 'а': {count1}");

        words = Regex.Split(text, @"\W+").Where(word => word.Length == 2).ToArray();
        var groups = words.GroupBy(word => word);
        foreach (var group in groups)
        {
            Console.WriteLine($"Слово '{group.Key}' встречается {group.Count()} раз");
        }
    }
}
