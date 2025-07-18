package first;

import java.util.Scanner;

public class PlusMinus {

	public static void PlusMinus(int[] arr) {
		int positive=0;
		int negative=0;
		int zero=0;
		
		for(int i=0;i<arr.length;i++) {
			if(arr[i]>0) {
				positive+=1;
			} else if(arr[i]<0) {
				negative+=1;
			}else {
				zero+=1;
			}
		}
		
		double positiveResult=(double)positive/arr.length;
		double negativeResult=(double)negative/arr.length;
		double zeroResult=(double)zero/arr.length;
		
	System.out.println("Positive numbers are: "+String.format("%.6f", positiveResult));
	System.out.println("Negative numbers are: "+ String.format("%.6f", negativeResult));
	System.out.println("Zero numbers are: " +String.format("%.6f", zeroResult));
	}
	
	public static void main(String[] args) {
		Scanner scanner=new Scanner(System.in);
		int n=scanner.nextInt();
		int[] arr=new int[n];
		
		for(int i=0;i<n;i++) {
			arr[i]=scanner.nextInt();
		}
		
		PlusMinus(arr);
		

	}

}
