#include <iostream>
using namespace std;
#include<algorithm>


int main()
{
	//Write a C++ program to find all elements in array of integers which have at-least two greater elements.
	int arr[5] = { 1,2,3,4,5 };
	int size = sizeof(arr) / sizeof(arr[5]);
	sort(arr, arr + size);
	for (int i = 0; i < size; i++) {
		cout << arr[i] << endl;
	}cout << "All elements in array which have at-least two greater elements are: ";
	for (int i = 0; i  < size-2; i ++)
	{
		cout << arr[i] << ",";
	}
}