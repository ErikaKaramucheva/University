package uni.fmi.bachelors;

import java.util.Scanner;

public class WhileExample {

	public static void main(String[] args) {

System.out.println("���� �������� ����� � �������� �� 5 �� 10000");
Scanner input=new Scanner(System.in);
int number=input.nextInt();
while(number<5 || number>10000) {
	System.out.println("���� �������� ����� � �������� �� 5 �� 10000");
	number=input.nextInt();
	}
System.out.println("�����!");
	}

}
