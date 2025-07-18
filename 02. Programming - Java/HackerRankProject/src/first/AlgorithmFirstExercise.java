package first;

import java.util.Scanner;

public class AlgorithmFirstExercise {

	public static void main(String[] args) {
		Scanner scanner=new Scanner(System.in);
		System.out.println("Choose array size: ");
		int size=scanner.nextInt();
		int[] arr=new int[size];
		for (int i = 0; i < arr.length; i++) {
			System.out.println("Enter sn element: ");
			arr[i]=scanner.nextInt();
			
		}
		int sum=0;
		for(int i=0;i<arr.length;i++) {
			sum+=arr[i];
		}
		System.out.println("The sum of all elemnts is: "+sum);
	}
}
