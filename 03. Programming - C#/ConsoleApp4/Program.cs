using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //теглене на пари
            //внос на пари
            // проверка на налична сума по сметка
            // смяна на пин

            //стартираща налична сума
            //сума за теглене
            // оставаща сума

            Console.WriteLine("Какво искате да направите? ");
            Console.WriteLine("1. Теглене на пари ");
            Console.WriteLine("2. Внос на пари");
            Console.WriteLine("3. Проверка на налична сума по сметка");
            Console.WriteLine("4. Смяна на ПИН");
            int desire = int.Parse(Console.ReadLine());

            if(desire<1 || desire > 4)
            {
                Console.WriteLine("Невалидна операция.");
            }

            if (desire == 1)
            {
                Console.WriteLine("Въведете налична сума: ");
                int startSum = int.Parse(Console.ReadLine());
                Console.WriteLine("Каква сума искате да изтеглите? ");
                int desireSum = int.Parse(Console.ReadLine());

                int endSum = startSum - desireSum;
                Console.WriteLine("Остават Ви " + endSum);
            } else if(desire == 2)
            {
                Console.WriteLine("Въведете налична сума: ");
                int startSum = int.Parse(Console.ReadLine());
                Console.WriteLine("Каква сума искате да внесете? ");
                int desireSum = int.Parse(Console.ReadLine());
                int endSum = startSum + desireSum;
                Console.WriteLine("Новата налична сметка по сумата Ви е: " + endSum);
            } else if (desire == 3)
            {
                Console.WriteLine("Въведете наличан сума: ");
                int startSum = int.Parse(Console.ReadLine());
                Console.WriteLine("Не сте извършвали други транзакции. Вашата сметка е: " + startSum);
            } else if (desire == 4)
            {
                Console.WriteLine("Въведете старата парола. ");
                char[] password = new char[30];
                for(int i=0; i < password.Length; i++)
                {
                    password[i]=char.Parse(Console.ReadLine());
                }
                Console.WriteLine("Въведете новата парола. ");
                char[] newPassword = new char[30];
                for (int i = 0; i < password.Length; i++)
                {
                    newPassword[i] = char.Parse(Console.ReadLine());
                }
                Console.WriteLine("Повторете новата парола. ");
                char[] verpassword = new char[30];
                for (int i = 0; i < password.Length; i++)
                {
                    verpassword[i] = char.Parse(Console.ReadLine());
                }

                if (newPassword == verpassword)
                {
                    Console.WriteLine("Вие успешно сменихте своята парола. ");
                }
                else
                {
                    Console.WriteLine("Опитайте отново. ");
                }
                

            }
        }
    }
}
