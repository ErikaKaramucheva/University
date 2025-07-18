package excersise;

import java.util.Scanner;
import java.util.Arrays;

public class exercise {

	public static void main(String[] args) {
		Scanner scanner=new Scanner(System.in);
		String sOne=scanner.nextLine();
		String sTwo=scanner.nextLine();
		if(sOne.equals(sTwo)) {
			System.out.println("They are equals.");
		} else {
			System.out.println("Not equal");
		}
	}

}
