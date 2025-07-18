package first;

public class Comparator {

	int a;
	int b;
	String one;
	String two;
	int[] f1;
	int[] f2;
	
	boolean Compare(int a, int b) {
		if(a==b) {
			return true;
		}
		return false;
	}
	boolean Compare(String one,String two) {
		if(one.equals(two)) {
			return true;
		}
		return false;
	}
	
	boolean Compare(int[] f1,int[] f2) {
		if(f1.length==f2.length) {
			for(int i=0;i<f1.length;i++) {
				if(f1[i]==f2[i]) {
					
				}else {
					return false;
				}
			}return true;
			
		}
		return false;
	}
	
}
