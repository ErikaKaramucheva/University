package excersise;

import java.util.Scanner;

public class HomeworkOne {

	public static void main(String[] args) {
		System.out.println("�������� ��� ������ �� ����������: ");
		Scanner scanner=new Scanner(System.in);
		int a=scanner.nextInt();
		int b=scanner.nextInt();
		int c=scanner.nextInt();
		
		if(a+b<=c || b+c<=a || a+c<=b) {
			System.out.println("�� ���������� ���������� � ������ �������.");
			System.exit(0);
		} 
		
		if(a==b && b==c) {
			System.out.println("������������ � ������������.");
		} else if(a==b || b==c ||c==a) {
			System.out.println("������������ � �����������.");
		} else {
			System.out.println("������������ � ������������.");
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
			System.out.println("������������ � �����������.");
		}
		
	}

}
