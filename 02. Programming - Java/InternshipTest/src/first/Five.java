package first;

public class Five {

	public static void main(String[] args) {
		int kg=80;
		int cm=171;
		int m=cm/100;
		
		double BMI=kg/(m*m);
		System.out.println(BMI);
		if(BMI<25) {
			System.out.println("You rock");
		} else if(BMI>25) {
			System.out.println("More training, less eating");
		}
	}

}
