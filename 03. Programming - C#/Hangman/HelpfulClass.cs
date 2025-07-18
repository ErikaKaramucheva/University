using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class HelpfulClass
    {
        

        public String generateWord()
        {
            String[] words = {"Банан","Анаконда","Магаре","Ягода","Маймуна","Ябълка","Лаптоп","Ананас",
        "Телефон","Зарядно","Химикал","Тефтер","Тетрадка","Часовник","Бебе","Игра","Стена","Лъв","Израз",
        "Обесен","Обелка","Гривна","Маса","Маска","Беседа","Стратегия","Формация","Изложба","Вариант","Вариация",
        "Синоним","Сложен","Пътводител","Произход","Проход","Крепост","Освобождение","Отегчен","Труден",
        "Авокадо","Организатор","Звездообразен","Звукосъчетание","Риболов"
        };
            Random random = new Random();
            int n = random.Next(0, words.Length);
            return words[n];

        }

        public static List<char>  showTheWord(string word)
        {
            List<char> result = new List<char>();
            for (int i = 0; i < word.Length; i++)
            {
                if (i == 0|| i==word.Length-1)
                {
                    result.Add(word[i]);
                }
                else
                {
                    result.Add('_');
                }

            }
            return result;
        }

        public static void checkForLetter(string word,char c)
        {
            bool check = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == c)
                {
                    check = true;

                }
            }

            if (check == false)
            {
                
            }
        }

        
    }
}
