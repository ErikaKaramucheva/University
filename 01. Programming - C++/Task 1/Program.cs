int number=0;
int max = int.MinValue;
int sum = 0;
int count=0;
while(number<10 || number > 20)
{
    Console.WriteLine("Моля въведете число:");
    number= int.Parse(Console.ReadLine());
    if (max < number) {  max = number; }
    sum += number;
    count++;
}
Console.WriteLine("Средно аритметичното на въведените до тук числа е: " + Math.Round((double)sum / count, 2));
Console.WriteLine("Максималното от въведените до тук числа е: " + max);
