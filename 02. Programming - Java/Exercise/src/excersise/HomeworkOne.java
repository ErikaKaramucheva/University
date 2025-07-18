package excersise;

import java.util.Scanner;

public class HomeworkOne {

	public static void main(String[] args) {
		System.out.println("Въведете три страни на триъгълник: ");
		Scanner scanner=new Scanner(System.in);
		int a=scanner.nextInt();
		int b=scanner.nextInt();
		int c=scanner.nextInt();
		
		if(a+b<=c || b+c<=a || a+c<=b) {
			System.out.println("Не съществува триъгълник с такива размери.");
			System.exit(0);
		} 
		
		if(a==b && b==c) {
			System.out.println("Триъгълникът е равностранен.");
		} else if(a==b || b==c ||c==a) {
			System.out.println("Триъгълникът е равнобедрен.");
		} else {
			System.out.println("Триъгълникът е разностранен.");
		}
		
		int cathetusOne, cathetusTwo, hypotenuse;
		if(a>b && a>c) {
			hypotenuse=a;
			cathetusOne=b;
			cathetusTwo=c;
		} else if(b>a && b>c) {
			hypotenuse=b;
			cathetusOne=a;
			cathetusTwo=c;
		}else {
			hypotenuse=c;
			cathetusOne=a;
			cathetusTwo=b;
		}
		
		if((cathetusOne*cathetusOne)+(cathetusTwo*cathetusTwo)==(hypotenuse*hypotenuse)) {
			System.out.println("Триъгълникът е правоъгълен.");
		}
		
	}

}
