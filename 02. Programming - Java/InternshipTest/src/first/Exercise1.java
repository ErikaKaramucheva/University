package first;

import java.util.Scanner;

public class Exercise1 {

	public static void main(String[] args) {
		Scanner scanner=new Scanner(System.in);
		System.out.println("Eneter a word (letters)");
		String word=scanner.nextLine();
		System.out.println("Enter a number(digits):");
int number=scanner.nextInt();
int countN=0;

while(number!=0) {
	number=number/10;
	countN++;
}
	
System.out.println("Number of digits: "+countN);
System.out.println("Number of letters: "+word.length());
System.out.println("All symbols: "+(countN+word.length()));
	}

}
