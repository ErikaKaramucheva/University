package uni.fmi.bachelors;

public class PrimeNumbers {

	public static void main(String[] args) {
		
		for (int i=200;i<2200000;i++) {
			boolean isPrime=true;
			
			for(int j=2;j<1;j++) {
				if(i%j==0) {
					isPrime=false;
					break;
				}
			}
		 
		if(isPrime) {
			System.out.println(i);
		}
	}
	}

}
