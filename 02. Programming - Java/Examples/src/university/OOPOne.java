package university;

import java.util.Scanner;

public class OOPOne {

	public static void main(String args[]) {
		Scanner scanner=new Scanner(System.in);
		/*��������� �������� ��� ������������ ��, ����� �� ������� �����:


			1. �������� �� ��������� �����
			2. �������� �� ���� � ������ �������� �� �������� �� �����
			0. �����


			��� ����� �� 0 - ��o������� �����.
			��� ����� �� 1 - ������ ���������� �� ��������� �� �������� � ����� �� 
			������ ��������� ����� (��������� ����� � ������ ����� ����� �� �������� �������� � ����� �� ������ �����). 
			���� ��������� �� ��������� �� ������� �� ������ ������ ��������� ����� � ���� ��������.
			��� ����� �� 2 -  ������ ���������� �� ��������� �� ��������. ���� ��������� �� ��������� ������ ������ �����
			������������ �� �� ���� � ������ �� ������� ����� �� ������� � �������� ��������.
			*/
		System.out.println("����� ������ �� ����������?");
		System.out.println("1- �������� �� ��������� �����");
		System.out.println("2- �������� �� ���� � ������ �������� �� �������� �� �����");
		System.out.println("0- �����");
		int choise=scanner.nextInt();
	while(choise<0 || choise>2) {	
		System.out.println("��������� �����. ���� �������� ����� 0,1,2");
		choise=scanner.nextInt();
	}
	if(choise==0) {
		System.exit(0);
	}else if(choise==1) {
		System.out.println("�������� ��������, � ����� �� �� ������ ��������� �����");
		int start=scanner.nextInt();
		int end=scanner.nextInt();
		
		for(int i=start;i<end;i++) {
			int j=2;
			int sum=0;
			while(i>2) {
				if(i%j==0) {
					sum+=i;
					j++;
				}
			}
			
			if(i==sum) {
				System.out.println(i+"is perfect.");
				
			}
		}
		
	}else {
		System.out.println("�������� ��������, ����� ����� �� �� �������");
		int start=scanner.nextInt();
		int end=scanner.nextInt();
		int sum=0;
		for(int i=start;i<=end;i++) {
			sum+=i;
		}
		System.out.println("���� �� ������� � ��������� "+start+" - "+end+": "+sum);
		System.out.println("������ ����������� �� ������� � ��������� "+start+" - "+end+": "+sum/(end-start+1));
	}
	
	}
}
