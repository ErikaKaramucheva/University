package excersise;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;
import java.util.Scanner;

public class JavaFundamentalsFirst {
	static Scanner scanner=new Scanner(System.in);
	public static void main(String[] args) {
		//Scanner scanner=new Scanner(System.in);

//		1. Намиране на перфектни числа
//		2. Намиране на сума и средна стойност на интервал от числа
//		0. Изход
//		При избор на 0 - Прoграмата спира.
//		При избор на 1 - Излиза възможност за въвеждане на интервал в който да търсим перфектни числа 
		//(перфектно число е такова което сбора на неговите делители е равен на самото числа). 
		//След въвеждане на интервала ни извежда на екрана всички перфектни числа в този интервал.
//		При избор на 2 -  Излиза възможност за въвеждане на интервал. 
		//След въвеждане на интервала сумира всички числа принадлежащи му на него и накрая ни 
		//показва сбора от числата и средната стойност
//	
		printTriangleOfStars();
		
		
		System.out.println("What do you want to do?");
		System.out.println("1. Find a perfect numbers");
		System.out.println("2. Find a sum and average of numbers in a range.");
		System.out.println("0. Exit");
		
		int command=scanner.nextInt();
		switch(command) {
		case 0: System.exit(0);
		break;
		case 1: findPerfectNumbers();
			break;
		case 2: break;
      default: System.out.println("Invalid operation.");
      break;
	}
		
	
	
	}
	
	public static void printTriangleOfStars() {
		for(int i=1;i<11;i++) {
			for(int j=0;j<i;j++) {
				System.out.print("*");
			}
			System.out.println();
		}
	}
	
	public static void sumAndAvg() {
		System.out.println("Enter a range (left and right side):");
		int leftSide=scanner.nextInt();
		int rightSide=scanner.nextInt();
		int sum=0;
		for(int i=leftSide;i<=rightSide;i++) {
			sum+=i;
		}
		System.out.println("Sum of number of the range: "+sum);
		System.out.println("Avg of numbers: "+(sum/(rightSide-leftSide)));
	}
	
	
	public static void findPerfectNumbers() {
		System.out.println("Enter a range (left and right side):");
		int leftSide=scanner.nextInt();
		int rightSide=scanner.nextInt();
		boolean flag=false;
		for(int i=leftSide;i<rightSide;i++) {
			int sum=0;
			for(int j=2;j<i;j++) {
				if(i%j==0) {
					sum+=j;
				}
			}
			if(sum==i) {
				System.out.println(i+ " is perfect.");
				flag=true;
			}
		}
		if(flag==false) {
			System.out.println("We didn't find perfect number in this range.");
		}
	}
	
	
	//3.2-2
}
