using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Second
    {
        public static void SecondTask()
        {
            /*Console.WriteLine("Въведете сума, която искате да конверирате: ");
           double usd = Double.Parse(Console.ReadLine());
           double bgn = usd * 1.79549;
           Console.WriteLine(usd + " са еквивалентни на {0} лева", bgn);*/
            /*  Console.WriteLine("Въведете стойността на радианите: ");
              double rad = Double.Parse(Console.ReadLine());
              double deg = rad * 180 / Math.PI;
              Console.WriteLine("{0} радиани са еквивалентни на {1} градуси",rad,deg);*/
            /*Console.WriteLine("Въведете депозирана сума: ");
            double deposit = Double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете срок на депозита в месеци: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете годишен лихвен процент: ");
            double percent = Double.Parse(Console.ReadLine());
            double sum = deposit +( month * ((deposit * (percent/100)) / 12));
            Console.WriteLine("Общата сума е: " + sum);*/
            /*Console.WriteLine("Въведете брой страници, които трябва да прочетете: ");
            int pages = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете колко страници прочитате за час:");
            int pagesPerHour = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете броя дни, с които разполагате: ");
            int days = int.Parse(Console.ReadLine());
            int pagesForOneDay = (pages / pagesPerHour)/days;
            Console.WriteLine("Необходими часове за ден: " + pagesForOneDay);*/
            /* Console.WriteLine("Въведете брой пакети химикали:");
             int pens = int.Parse(Console.ReadLine());
             Console.WriteLine("Въведете брой пакети маркери: ");
             int markers = int.Parse(Console.ReadLine());
             Console.WriteLine("Въведете необходимите литри препарат за почистване на дъска:");
             int litres = int.Parse(Console.ReadLine());
             Console.WriteLine("Въведете процент намаление: ");
             int percent = int.Parse(Console.ReadLine());
             double sumBeforeDiscount = (pens * 5.8) + (markers * 7.2) + (litres * 1.2);
             double sumAfterDiscount=sumBeforeDiscount-(sumBeforeDiscount*((double)percent /100));
             Console.WriteLine("На Ани ще са нужни {0} лева.", sumAfterDiscount);
            */
            /*Console.WriteLine("Въведете необходимото количество найлон в кв.м.: ");
            int naylon = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете необходимото количество боя (в литри):");
            int colorLiters = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете необходимото количество разредител (в литри):");
            int razLiters = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете часовете, за които майсторите ще свършат работата:");
            int hours = int.Parse(Console.ReadLine());
            naylon += 2;
            double totalLiters = colorLiters + ((double)colorLiters * 0.10);
            double materialPrice = 0.4+(naylon * 1.5) + (totalLiters * 14.50) + (razLiters * 5);
            double priceForOneHour = materialPrice * 0.3;
            double totalPrice = materialPrice + (hours * priceForOneHour);

            Console.WriteLine("Суматра за всички разходи е: "+totalPrice);*/

            /*Console.WriteLine("Колко пилешки менюта ще желаете?");
            int chicken = int.Parse(Console.ReadLine());
            Console.WriteLine("Колко менюта с риба ще желаете?");
            int fish = int.Parse(Console.ReadLine());
            Console.WriteLine("Колко броя вегански менюта ще желаете?");
            int veg = int.Parse(Console.ReadLine());
            double sumBeforeDessert = (chicken * 10.35) + (fish * 12.40) + (veg * 8.15);
            double dessertPrice = sumBeforeDessert * 0.2;
            double totalSum = sumBeforeDessert + dessertPrice + 2.5;
            Console.Write("Цена на поръчката: " + totalSum);*/

            /* Console.WriteLine("Въведете годишната такса за тренировка по баскетбол:");
             int tax = int.Parse(Console.ReadLine());
             double shoes = tax - (tax * 0.4);
             double equipment = shoes - (shoes * 0.20);
             double ball = equipment / 4;
             double accessory = ball / 5;
             double totalSum = tax + shoes + equipment + ball + accessory;
             Console.WriteLine("На Джеси ще са й необходими {0} лева.", totalSum);*/

            Console.WriteLine("Въведете дължина в сантиметри: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете широчина в сантиметри: ");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете височина в сантиметри: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете процента, който е зает:");
            double percent = Double.Parse(Console.ReadLine());
            int v = length * width * height;
            // v = v / 10;
            double emptyP = v - (v * (percent / 100));
            double liters = emptyP * 0.001;
            Console.WriteLine("Аквариума ще събира {0} литри вода.", liters);

        }
    }
}
