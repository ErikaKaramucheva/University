package uni.fmi.bachelors;

import java.util.Scanner;

public class SwitchExample {

	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		System.out.println("��� ����� ���?"
				+ "( �������� ������� ��� ���� �� ������)");
		String month=input.nextLine();
		switch(month) {
		case "jan":
		case "mar":
		case "may":
		case "jul":
		case "aug":
		case "oct":
		case "dec":
			System.out.println("������� ��� 31 ���.");
			break;
		case"feb":
			System.out.println("��������� �� � ��������?");
			String feb=input.nextLine();
			if(feb=="yes") {
				System.out.println("����� �������� ��� 29 ���.");
			}else {
			System.out.println("����� �������� ��� 28.");}
			//int year=input.nextInt();
			//if((year%4==0 && year&100!=0) || year%400==0){
			//system.out.println()}
			//else{ system.out.println()};
			break;
		case "apr":
		case "jun":
		case "sep":
		case "nov":
			System.out.println(" ������� ��� 30 ���.");
			break;
			default:
				System.out.println("��������� �����.");
			
		}

	}

}
