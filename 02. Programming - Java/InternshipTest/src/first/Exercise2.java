package first;

import java.util.Scanner;

public class Exercise2 {

	public static void main(String[] args) {
		Scanner scanner=new Scanner(System.in);
		System.out.println("Enter a number:");
		int number=scanner.nextInt();
		
		if(number%2==0) {
			System.out.println("Even");
		}else {
			System.out.println("Odd");
		}

	}

}
