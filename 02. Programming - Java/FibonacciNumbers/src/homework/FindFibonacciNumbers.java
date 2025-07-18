package homework;

import java.util.Scanner;

public class FindFibonacciNumbers {
	public static int FibonacciRecursion (int number) {
		if(number == 0 || number==1) 
		return number;
	        
	      return FibonacciRecursion(number - 1) + FibonacciRecursion(number - 2);
	}

	public static void main(String[] args) {
		Scanner scanner=new Scanner(System.in);
		System.out.println("Колко числа на Фибоначи да ви покажа?");
		int numbers=scanner.nextInt();
		int f1=1;
		int f2=1;
		int fn=0;
		for(int i=0;i<numbers;i++) {
			f1=f2;
			f2=fn;
			fn=f1+f2;
			
			System.out.println(fn);
		}
		System.out.println("");
		System.out.println("Числата на Фибоначи, изведени чрез рекурсия: ");
		int listByRecursion=FibonacciRecursion(numbers);
		System.out.println(listByRecursion);
		}
		
	}


