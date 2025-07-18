package first;

public class PlusMinusSecond {
	public static void main(String[] args) {
		
		int[] arr= {1,1,0,-1,-1};
		PlusMinus(arr);
		
	}
	
	public static void PlusMinus(int[] arr) {
		int positive=0;
		int negative=0;
		int zero=0;
		
		for(int i=0;i<arr.length;i++) {
			if(arr[i]>0) {
				positive++;
			}
			else if(arr[i]<0) {
				negative++;
			}
				else {
				zero++;
			}
		}
		
			
			double positiveResult=(double)positive/arr.length;
			double negativeResult=(double)negative/arr.length;
			double zeroResult=zero/arr.length;
			
			System.out.printf("Poitive= %.6f",positiveResult);
			System.out.printf("Negative= %.6f",negativeResult);

			System.out.printf("Zero= %.6f",zeroResult);
		}
	}


