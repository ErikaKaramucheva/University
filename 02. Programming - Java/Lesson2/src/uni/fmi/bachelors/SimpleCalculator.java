package uni.fmi.bachelors;

import java.util.Scanner;

public class SimpleCalculator {

	public static void main(String[] args) {
		Scanner in=new Scanner(System.in);
		System.out.println("Моля, въведете две числа: ");
		Integer a=in.nextInt();
		Integer b=in.nextInt();
		
		System.out.println("A*B="+ a*b);
		System.out.println("A/B="+ a/b);
		System.out.println("A%B="+ a%b);
		System.out.println("A+B="+ (a+b));
		System.out.println("A-B="+ (a-b));


	}

}
