package first;

import java.util.Scanner;

public abstract class Third {

	public static void main(String[] args) {
		Scanner scanner=new Scanner(System.in);
		System.out.println("Enter a number:");
		double number=scanner.nextDouble();
		
	double sqrt=Math.sqrt(number);
	System.out.printf("%.5f",sqrt);
	}

}
