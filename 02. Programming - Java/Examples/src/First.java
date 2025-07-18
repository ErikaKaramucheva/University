import java.util.Scanner;

public class First {

	public static void main(String args[]) {
		Scanner scanner = new Scanner(System.in);
		int number=scanner.nextInt();
		int k=scanner.nextInt();
		int i=0;
		int n=0;
		while(i!=k) {
			n=number%10;
			number/=10;
			i++;
		}

		System.out.println(n);
	
	}
}
