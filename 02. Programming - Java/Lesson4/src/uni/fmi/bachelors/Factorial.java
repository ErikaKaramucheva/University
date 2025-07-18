package uni.fmi.bachelors;

import java.util.Scanner;

public class Factorial {

	public static void main(String[] args) {
		//1.��������� �� ����� ����� �� �������
		// 2. ��������� �������
		// 3. ��������� ���������
		
		System.out.println("��������� �� ��� ����� �� �������?");
		Scanner scanner=new Scanner(System.in);
		int factorial=scanner.nextInt();
		int result=factorialByCycle(factorial);

		System.out.println(result);
		
		System.out.println(factorialByRecursion(factorial));
		
	}

	
	public static int factorialByRecursion(int f) {
		if(f==1)
			return 1;
		
		return f*factorialByRecursion(f-1);
	}
	
	public static int factorialByCycle(int f) {
		int result=1;
		for(int i=1;i<=f;i++) {
			result=result*i;
		}
		return result;
	}

}
