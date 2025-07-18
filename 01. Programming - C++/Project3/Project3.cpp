#include <iostream>
using namespace std;
#include<cmath>
#include<string>

void threeLargest (int arr[], int arrSize) {
	int first = INT_MIN;
	int two = INT_MIN;
	int three = INT_MIN;
	for (int i = 0; i < arrSize; i++)
	{
		if (arr[i] > first) {
			three = two;
			two = first;
			first = arr[i];
		}
		else if (arr[i] > two) {
			three = two;
			two = arr[i];
		}
		else if (arr[i] > three) {
			three = arr[i];

		}
	}cout << "Parvoto nai-golqmo chislo e: " << first 
		<< ".\n Vtoroto nai-golqmo chislo e: " << two 
		<< ".\n Tretoto nai-golqmo chislo e: " << three;
}

int main()
{
	//Write a C++ program to find the largest three elements in an array.
	int arr[50], number;
	cout << "Vavedete daljina na masiva: ";
	cin >> number;
	for (int i = 0; i < number; i++)
	{
		cout << "Vavedete chislo: ";
		cin>>arr[i];
	}
	threeLargest(arr, number);
}

