#include <iostream>
using namespace std;
#include<algorithm>


int main()
{
	/*int arr[8] = {4,15,14,16,17,18,29,28,};
	int n = sizeof(arr) / sizeof(arr[8]);
	int k = n / 2;
	sort(arr, arr+n, greater<int>());
	for (int i = 0; i < k; i++)
	{
		cout << arr[i] << endl;
	}*/

	//Write a C++ program to find the second smallest elements in a given array of integers.
	/*int arr[6] = {3,5,12,24,35,67};
	int n = sizeof(arr) / sizeof(arr[6]);
	int firstSmall = INT_MAX;
	int secondSmall = INT_MAX;
	for (int i = 0; i < n; i++)
	{
		cout << arr[i] << endl;
		if (arr[i] < firstSmall) {
			secondSmall = firstSmall;
			firstSmall = arr[i];
		}
		else if (arr[i] < secondSmall) {
			secondSmall = arr[i];
		}
	}cout <<endl<< secondSmall;*/

	//Write a C++ program to find all elements in array of integers which have at - least two greater elements.
	int arr[6] = { 3,14,32,11,25,56 };
	int n = sizeof(arr) / sizeof(arr[6]);
	sort(arr, arr + n, greater<int>());
	for (int i = 0; i < n; i++)
	{
		cout << arr[i] << endl;
	} 

}
