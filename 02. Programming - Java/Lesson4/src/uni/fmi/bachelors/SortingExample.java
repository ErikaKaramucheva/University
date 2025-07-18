package uni.fmi.bachelors;

public class SortingExample {

	public static void main(String[] args) {
		int[] numbers= {3,55,1,-5,0,-55,76,33,11};
		
		for(int i=0;i<numbers.length;i++) {
			for(int j=0;j<numbers.length-1;j++) {
				if(numbers[i]<numbers[j]) {
					int temp=numbers[i];
					numbers[i]=numbers[j];
					numbers[j]=temp;
				}
			}
		}
		
		for(int i=0; i<numbers.length;i++) {
			System.out.print(numbers[i]+" ");
		}
		

	}

}
