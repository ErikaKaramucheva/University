package uni.fmi.bachelors;

import java.util.Scanner;

public class SwitchExample {

	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		System.out.println("Кой месец сме?"
				+ "( въведете първите три букв от месеца)");
		String month=input.nextLine();
		switch(month) {
		case "jan":
		case "mar":
		case "may":
		case "jul":
		case "aug":
		case "oct":
		case "dec":
			System.out.println("Месецът има 31 дни.");
			break;
		case"feb":
			System.out.println("Високосна ли е годината?");
			String feb=input.nextLine();
			if(feb=="yes") {
				System.out.println("Месец февруари има 29 дни.");
			}else {
			System.out.println("Месец февруари има 28.");}
			//int year=input.nextInt();
			//if((year%4==0 && year&100!=0) || year%400==0){
			//system.out.println()}
			//else{ system.out.println()};
			break;
		case "apr":
		case "jun":
		case "sep":
		case "nov":
			System.out.println(" Месецът има 30 дни.");
			break;
			default:
				System.out.println("Невалиден месец.");
			
		}

	}

}
