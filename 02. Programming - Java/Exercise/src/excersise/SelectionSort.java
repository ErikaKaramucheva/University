package excersise;

import java.util.Scanner;

public class SelectionSort {

	public static void main(String[] args) {
		Scanner scanner=new Scanner(System.in);
		int[] arr=new int[100];
		System.out.println("Въведете дължина на масива: ");
		int n=scanner.nextInt();
		for(int i=0;i<n;i++) {
		 arr[i]=scanner.nextInt();
		
		}
		int min_index;
		for(int i=0;i<n;i++) {
			if(i<n-1) {
				min_index=i;
				int j=i+1;
				for(;j<n;j++) {
					if(arr[j]<min_index) {
						min_index=j;
						//swap(min_index,j);
					}
				}
			} else {
				System.out.println(arr[i]);
			}}
			for(int i=0;i<n;i++) {
				System.out.println(arr[i]);
			}
		

	}

}
