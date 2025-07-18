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
		System.out.println("����� ������ �� ���������?");
		System.out.println("�������� �� ��������� ����� (�������� 1)");
		System.out.println("�������� �� ���� � ������ �������� �� �������� �� ����� (�������� 2)");
		System.out.println("����� (�������� 0)");
		int choice = scanner.nextInt();
		int sum = 0;
		double avg = 0.0;

		/*
		 * ����������� ���� ���������� ����� � � ��������� 0-2 � ������ ���������� ��
		 * ����������� �� ������ ��������� �����, ���������� �� ���������.
		 */
		while (choice != 0 && choice != 1 && choice != 2) {
			System.out.println("�������� ����� � �������� ��������: ");
			choice = scanner.nextInt();
		}

		// ����������� ����� ������������ ���� �� �������.
		if (choice == 0) {
			System.exit(0);
		} else if (choice == 1) {
			System.out.println(
					"�������� ��������, � ����� ������ �� ������� ��������� ����� (����� ��������-������ � ����- ������� �� ��� ���):");
			int start = scanner.nextInt();
			int end = scanner.nextInt();
			for (int i = start; i <= end; i++) {
				if (isPerfect(i)) {
					System.out.println(i + " � ���������");
				}
			}
		}

		else if (choice == 2) {
			System.out.println(
					"�������� �������� � ����� �� ������� �� ��� ��������(����� �� ����� ��������� �� ��� ���):");
			int intervalStart = scanner.nextInt();
			int intervalEnd = scanner.nextInt();
			// ��������� �� ���������� count, ����� �� �� ������ ����� � ����� �� ������� �
			// �������� ��������,
			// � ��� ��- ����� �� ������� ������ �������������.
			int count = 0;
			for (; intervalStart <= intervalEnd; intervalStart++) {
				sum = intervalStart + sum;
				count++;
			}
			avg = (double) sum / (double) count;
			System.out.println("������ �� ������� � �������� �� ��� �������� �: " + sum);
			System.out.println("������ ������������� �� ������� � �������� �� ��� �������� �: " + avg);

		}

	}

}
