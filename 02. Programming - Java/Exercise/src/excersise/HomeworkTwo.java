package excersise;

import java.util.Scanner;

public class HomeworkTwo {

	public static boolean isPerfect(int number) {
		int i = 0;
		int sum = 0;
		while (i++ < number) {
			if (number % i == 0 && i < number) {
				sum += i;
			}
		}
		return sum == number;
	}

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		System.out.println("Какво искате да направите?");
		System.out.println("Намиране на перфектни числа (въведете 1)");
		System.out.println("Намиране на сума и средна стойност на интервал от числа (въведете 2)");
		System.out.println("Изход (въведете 0)");
		int choice = scanner.nextInt();
		int sum = 0;
		double avg = 0.0;

		/*
		 * Проверяваме дали въведеното число е в интервала 0-2 и даваме възможност на
		 * потребителя да въведе подходящо число, отговарящо на условието.
		 */
		while (choice != 0 && choice != 1 && choice != 2) {
			System.out.println("Въведете число в указания интервал: ");
			choice = scanner.nextInt();
		}

		// Проверяваме какво потребителят иска да направи.
		if (choice == 0) {
			System.exit(0);
		} else if (choice == 1) {
			System.out.println(
					"Въведете интервал, в който искате да търсите перфектни числа (всяка стойност-начало и край- задайте на нов ред):");
			int start = scanner.nextInt();
			int end = scanner.nextInt();
			for (int i = start; i <= end; i++) {
				if (isPerfect(i)) {
					System.out.println(i + " е перфектно");
				}
			}
		}

		else if (choice == 2) {
			System.out.println(
					"Въведете началото и краят на желания от вас интервал(всяка от двете стойности на нов ред):");
			int intervalStart = scanner.nextInt();
			int intervalEnd = scanner.nextInt();
			// Създаваме си променлива count, която ще ни покаже какъв е броят на числата в
			// указания интервал,
			// с нея по- късно ще намерим средно аритметичното.
			int count = 0;
			for (; intervalStart <= intervalEnd; intervalStart++) {
				sum = intervalStart + sum;
				count++;
			}
			avg = (double) sum / (double) count;
			System.out.println("Сумата на числата в избрания от вас интервал е: " + sum);
			System.out.println("Средно аритметичното на числата в избрания от вас интервал е: " + avg);

		}

	}

}
