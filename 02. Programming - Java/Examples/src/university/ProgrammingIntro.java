package university;

import java.time.chrono.MinguoChronology;
import java.util.Scanner;

public class ProgrammingIntro {

	public static void main(String[] args) {
		Scanner scanner=new Scanner(System.in);
		//�������� ��������, ����� ���� �� ������������ ���� �����, ������ ������� �� � � �������� 10-20
		//� ������� ������ ����������� �� ������� �������� �� ������� � ���-�������� �� ���.
		//(��� ��������� �� �����, ����������� �� ���� �������� ����� �� �����, ��������� � ��� ����������!)
		
		//�������� ����:
		//4
		//8
		//15

		//�������� �����:
		//9
		//15
		int sum=0;
		int count=0;
		int number=0;
		int biggest_number=Integer.MIN_VALUE;
		do {
			System.out.println("Enter a number:");
			number=scanner.nextInt();
			if(biggest_number<number) {
				biggest_number=number;
			}
			sum+=number;
			count++;
		}while(number<10 || number>20);
		
		int avg=sum/count;
		System.out.println("Avg="+avg);
		System.out.println("Biggest number="+biggest_number);

	}

}
