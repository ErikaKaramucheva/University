package excersise;

public class Algorithms {

	public static void main(String[] args) {
		int[] arr= {3,5,7,0,-4,11,22,-100,10};
		//bubbleSort(arr);
		//int number=linearSearch(arr,10);
		//System.out.println(number);
		//System.out.println(binarySearch(arr,8));
//selectionSort(arr);
		//insertionSort(arr);
		int[] result=split(arr);
		for(int i=0;i<result.length;i++) {
			System.out.println(result[i]);
		}
		int[] quick=quickSort(arr,0,arr.length-1);
		for(int i=0;i<arr.length;i++) {
			System.out.println(quick[i]);
		}
		//quick sort
	}
	public static int[] quickSort(int[] arr,int l,int r) {
		int x=arr.length/2;
		int i=l;
		int j=r;
		while(l<=r) {
			while(i<=l&&arr[i]<arr[x])i++;
			while(j>=r&&arr[j]>arr[x])j--;
			if(i<=j) {
				int temp=arr[i];
				arr[i]=arr[j];
				arr[j]=temp;
				i++;j--;
			}
			if(i<r)quickSort(arr,i,r);
			if(j<l)quickSort(arr,l,j);
		}
		return arr;
		
	}
	public static int[] split(int[] arr) {
		if(arr.length==1) {
			return arr;
		}
		int mid=arr.length/2;
		int[] leftArray=new int[mid];
		int[] rightArray=new int[arr.length-mid];
		for (int i = 0; i < leftArray.length; i++) {
			leftArray[i]=arr[i];
		}
		for (int i = 0,j=mid; j < arr.length; i++,j++) {
			rightArray[i]=arr[j];
		}
		leftArray=split(leftArray);
		rightArray=split(rightArray);
		return Merge(leftArray,rightArray);
	}
	public static int[] Merge(int[]left,int[] right) {
		int[] result=new int[left.length+right.length];
		int leftIncrease=0;
		int rightIncrease=0;
		for(int i=0;i<result.length;i++) {
			if(rightIncrease==right.length ||(leftIncrease<left.length && left[leftIncrease]<=right[rightIncrease])) {
				result[i]=left[leftIncrease];
				leftIncrease++;
			}else if(leftIncrease==left.length||(rightIncrease<right.length&& right[rightIncrease]<=left[leftIncrease])){
				result[i]=right[rightIncrease];
				rightIncrease++;
			}
		}
		return result;
	}
	public static void insertionSort(int[] arr) {
		for(int i=0;i<arr.length-1;i++) {
			for(int j=i+1;j>0;j--) {
				if(arr[j-1]>arr[j]) {
					int temp=arr[j];
					arr[j]=arr[j-1];
					arr[j-1]=temp;
				}
			}
		}
			for(int i=0;i<arr.length;i++) {
				System.out.println(arr[i]);
			}
		
	}
	public static void selectionSort(int[] arr) {
		for(int i=0;i<arr.length;i++) {
			int min_idx=i;
			for(int j=i+1;j<arr.length-1;j++) {
				if(arr[j]<arr[min_idx]) {
					min_idx=j;
				}
			}
			int temp=arr[i];
			arr[i]=arr[min_idx];
			arr[min_idx]=temp;
		}
		for(int i=0;i<arr.length;i++) {
			System.out.println(arr[i]);
		}
	}
	public static int binarySearch(int[] arr,int x) {
		int left=0;
	int right=arr.length;
	while(left<=right) {
		int mid=(left+right)/2;
		if(arr[mid]==x) {
			return mid;
		}else if(x<arr[mid]) {
			right=mid;
		}else {
			left=mid;
		}
	}
	
	return -1;
	}
	public static int linearSearch(int[]arr, int number) {
		for(int i=0;i<arr.length;i++) {
			if(arr[i]==number) {
				return i;
			}
		}
		return -1;
	}
	public static void bubbleSort(int[]arr) {
		for(int i=0;i<arr.length;i++) {
			for(int j=0;j<arr.length-1;j++) {
				if(arr[j]>arr[j+1]) {
					int temp=arr[j];
					arr[j]=arr[j+1];
					arr[j+1]=temp;
				}
			}
		}
		
		for(int i=0;i<arr.length;i++) {
			System.out.println(arr[i]);
		}
	}

}
