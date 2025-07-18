using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Eneter first time: ");
             int firstTime = int.Parse(Console.ReadLine());
              Console.WriteLine("Eneter second time: ");
             int secondTime = int.Parse(Console.ReadLine());
              Console.WriteLine("Eneter third time: ");
             int thirdTime = int.Parse(Console.ReadLine());
             int sum = firstTime + secondTime + thirdTime;
             if (sum < 60)
             {
                 if (sum < 10)
                 {
                     Console.WriteLine("0 : 0" + sum);
                 }
                 else
                     Console.WriteLine("0 : " + sum);
             }
             else
             {
                 int min = 0;
                 while (sum > 60)
                 {
                     min++;
                     sum -= 60;
                 }

                 if (sum < 10)
                 {
                     Console.WriteLine(min + " : 0" + sum);
                 }
                 else
                 {
                     Console.WriteLine(min + " : " + sum);
                 }
             }*/
            /*Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (number <= 100)
            {
                bonus+= 5;
            }else if (number > 100 && number<1000)
            {
                bonus = 0.2 * number;
            }else 
            {
                bonus = 0.1 * number;
            }

            if (number % 2 == 0)
            {
                bonus +=1;
            }

            if (bonus % 10 == 5)
            {
                bonus += 2;
            }
            Console.WriteLine("Bonus: " + bonus);
            Console.WriteLine("Final result: " + (number + bonus));
            */
            /*
            Console.WriteLine("Въведете часове: ");
            int hour = int.Parse(Console.ReadLine());

            while (hour < 0 || hour > 23)
            {
                Console.WriteLine("МОля, въведете час, който е между 0 и 23");
                hour = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Въведете минути: ");
            int min = int.Parse(Console.ReadLine());

            while (min < 0 || min > 59)
            {
                Console.WriteLine("Мoля, въведете минути, които да са между 0 и 59");
                min = int.Parse(Console.ReadLine());
            }
            min += 15;
            if (min > 60)
            {
                hour += 1;
                min -= 60;
                if (hour > 23)
                {
                    hour = 0;
                }
            }
            if (min < 10)
            {
                Console.WriteLine(hour + " : 0" + min);
            }
            else
                Console.WriteLine(hour + " : " + min);
            */
            /* Console.WriteLine("Въведете цената на екскурзията:");
             double excursion = Double.Parse(Console.ReadLine());
             Console.WriteLine("Въведете брой продадени пъзъле:");
             int puzzels = int.Parse(Console.ReadLine());
             Console.WriteLine("Въведете брой говорещи кукли:");
             int dolls = int.Parse(Console.ReadLine());
             Console.WriteLine("Въведете брой плюшени мечета:");
             int bears = int.Parse(Console.ReadLine());
             Console.WriteLine("Въведете брой миньони:");
             int minions = int.Parse(Console.ReadLine());
             Console.WriteLine("Въведете брой камиончета:");
             int trucks = int.Parse(Console.ReadLine());
             double sumOfToys = (puzzels * 2.6) + (dolls * 3) + (bears * 4.1) + (minions * 8.2) + (trucks * 2);
             int toysCount = puzzels + dolls + bears + minions + trucks;
             if (toysCount >= 50)
             {
                 sumOfToys = sumOfToys - (0.25 * sumOfToys);
             }
             sumOfToys = sumOfToys-(sumOfToys * 0.1);
             if (sumOfToys >= excursion)
             {
                 Console.Write("Да! Остават {0} лева.", Math.Round((sumOfToys - excursion), 2));
             }
             else
             {
                 Console.Write("Недостатъчно пари! Недостигат {0} лева.", Math.Round((excursion - sumOfToys),2));
             }
             */
            //5
            /*Console.WriteLine("Въведете бюджета за филма: ");
            double budget = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ввъведете броя на статистите:");
            int statists = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете цената на облеклото за един статист:");
            double priceForOne = Double.Parse(Console.ReadLine());
            double priceForDecor = budget * 0.1;
            double outfit = statists * priceForOne;
            if (statists > 150)
            {
                outfit = outfit - (outfit * 0.1);
            }
            double totalPrice = priceForDecor + outfit;
            if (totalPrice <= budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine("Wingard needs "+ Math.Round((totalPrice-budget),2)+" leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine("Wingard starts filming with {0} leva left.", Math.Round((budget - totalPrice),2));
            }*/
            //6
            Console.WriteLine("Enter records seconds: ");
            int seconds = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter meters:");
            int meters = int.Parse(Console.ReadLine());
            Console.WriteLine()


        }
    }
}
