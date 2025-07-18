package fmi.uni.bachelor;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) throws IOException {
		Scanner scanner=new Scanner(System.in);
		System.out.println("Въведете начало на интервала: ");
		int startNumber=scanner.nextInt();
		System.out.println("Въведете край на интервала: ");
		int endNumber=scanner.nextInt();
		File path=new File("C:\\Users\\user\\Desktop\\math.txt");
		FileWriter wr = new FileWriter(path);
		
		for(int i=startNumber;i<=endNumber;i++) {
			//generateInterval(startNumber);
			int temp=i;
			wr.write(temp+" ");
			System.out.print(temp+" ");
			while(temp>1) {
				if(temp%2==0) {
					temp/=2;
				}else {
					temp=(temp*3)+1;
				}
				System.out.print(temp+" ");
				wr.write(temp+" ");
			}
			System.out.println(" ");
			wr.write("\n");
		}
		wr.close();
	}
	/*public static string generateInterval(int startNumber){
	 * 
	 }*/

}
