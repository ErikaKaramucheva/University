package IntroProgramming;

import java.util.Random;
import java.util.Scanner;

public class First {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Scanner scanner=new Scanner(System.in);
		/*Random random=new Random();
		int number=random.nextInt(1,6);
		int a=scanner.nextInt();
		if(a==number) {
			
		System.out.println(true); 
		}else {
			System.out.println(number);
			System.out.println(false);
		}*/
		
		int days=scanner.nextInt();
		double s_per_day=scanner.nextDouble();
		double course=scanner.nextDouble();
		double total_salary=(days*12)*s_per_day;
		double bonus=2.5*(days*s_per_day);
		double dds=(total_salary+bonus)*0.25;
		double salary=total_salary+bonus-dds;
		double bg=salary*course;
		System.out.println(bg/365);
		
	}

}
