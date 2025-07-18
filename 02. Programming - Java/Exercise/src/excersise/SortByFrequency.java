package excersise;

import java.util.ArrayList;
import java.util.List;

public class SortByFrequency {

	public static void main(String[] args) {
		int[] arr= {2,4,4,4,4,5,2,8,5,6,8,8};
		int[]result=sortByFrequency(arr);
		for (int i = 0; i < result.length; i++) {
			System.out.println(result[i]);
		}

	}
	public static int[] sortByFrequency2(int[] arr) {
		int[] result=new int[arr.length];
		for(int i=0;i<arr.length;i++) {
			for(int j=0;j<arr.length;j++) {
				if(arr[j]>arr[j+1]) {
					int temp=arr[j];
					arr[j]=arr[j+1];
					arr[j+1]=temp;
				}
			}
			
		}
		
		
		return result;
	}
	
	public static int[] sortByFrequency(int[] arr) {
		int[] result=new int[arr.length];
		int frequent=0;
		int element=arr[0];
		int k=0;
		List<Integer> added=new ArrayList<Integer>();
		List<Integer> one=new ArrayList<Integer>();
		for(int i=0;i<arr.length;i++) {
			int count=0;
			int temp=arr[i];
			if(added.contains(arr[i])) {
				continue;
			}else {
			added.add(arr[i]);
			for(int j=i+1;j<arr.length;j++) {
				if(temp==arr[j]) {
					count++;
				}
			}
			if(frequent<=count) {
				frequent=count;
				element=temp;
				for(int j=0;j<=frequent;k++,j++) {
					result[k]=element;
				}
			}else if(count==0 ) {
				one.add(arr[i]);
			}
			}
			
		}
		int t=0;
		while(one.size()!=0) {
			result[k]=one.get(t);
			one.remove(t);
			t++;k++;
		}
		
		return result;
	}

}
