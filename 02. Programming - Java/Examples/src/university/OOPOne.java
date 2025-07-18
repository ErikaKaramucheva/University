package university;

import java.util.Scanner;

public class OOPOne {

	public static void main(String args[]) {
		Scanner scanner=new Scanner(System.in);
		/*Направете програма при стартирането на, която ви показва избор:


			1. Намиране на перфектни числа
			2. Намиране на сума и средна стойност на интервал от числа
			0. Изход


			При избор на 0 - Прoграмата спира.
			При избор на 1 - Излиза възможност за въвеждане на интервал в който да 
			търсим перфектни числа (перфектно число е такова което сбора на неговите делители е равен на самото числа). 
			След въвеждане на интервала ни извежда на екрана всички перфектни числа в този интервал.
			При избор на 2 -  Излиза възможност за въвеждане на интервал. След въвеждане на интервала сумира всички числа
			принадлежащи му на него и накрая ни показва сбора от числата и средната стойност.
			*/
		System.out.println("Какво искате да напраавите?");
		System.out.println("1- Намиране на перфектни числа");
		System.out.println("2- Намиране на сума и средна стойност на интервал от числа");
		System.out.println("0- Изход");
		int choise=scanner.nextInt();
	while(choise<0 || choise>2) {	
		System.out.println("Невалидни данни. Моля въведете число 0,1,2");
		choise=scanner.nextInt();
	}
	if(choise==0) {
		System.exit(0);
	}else if(choise==1) {
		System.out.println("Въведете интервал, в който ще се търсят перфектни числа");
		int start=scanner.nextInt();
		int end=scanner.nextInt();
		
		for(int i=start;i<end;i++) {
			int j=2;
			int sum=0;
			while(i>2) {
				if(i%j==0) {
					sum+=i;
					j++;
				}
			}
			
			if(i==sum) {
				System.out.println(i+"is perfect.");
				
			}
		}
		
	}else {
		System.out.println("Въведете интервал, чиито числа да се съберат");
		int start=scanner.nextInt();
		int end=scanner.nextInt();
		int sum=0;
		for(int i=start;i<=end;i++) {
			sum+=i;
		}
		System.out.println("Сума на числата в интервала "+start+" - "+end+": "+sum);
		System.out.println("Средно аритметично на числата в интервала "+start+" - "+end+": "+sum/(end-start+1));
	}
	
	}
}
