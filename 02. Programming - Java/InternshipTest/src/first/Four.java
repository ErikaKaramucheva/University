package first;

import java.util.Scanner;

public class Four {

	public static void main(String[] args) {
		Scanner scanner=new Scanner(System.in);
		System.out.println("Enter a 9 digits number: ");
		int number=scanner.nextInt();
		int reverse=0;
		while(number!=0) {
			int n=number%10;
			reverse=reverse*10+n;
			number=number/10;
		}
System.out.println("The reverse of the given number is: "+reverse);
	}

}
