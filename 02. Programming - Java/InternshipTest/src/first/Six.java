package first;

import java.util.Scanner;

public class Six {

	public static void main(String[] args) {
		Scanner scanner=new Scanner(System.in);
		System.out.println("Enter a number between 0 and 30:");
		int l=scanner.nextInt();
		if(l<0 && l>30) {
			System.out.println("Enter a number between 0 and 30:");
			l=scanner.nextInt();
		}

		String f="#";
		for (int i = 1; i <= l; i++) {
            if (i == 1 || i == l) {
                for (int j = 1; j <= l; j++) {
                    System.out.print(f);
                }
            } else for (int a = 1; a <= l; a++) {
                if (a == 1 || a == l) {
                    System.out.print(f);
                } else System.out.print(f);
            }
            System.out.print("\n");
        }
	}

}
