#include <iostream>
#include <string>;
using namespace std;
#include<algorithm>

void secondSmallest(int arr[], int arrSize) {
    cout << "Masivat e: ";
    for (int  i = 0; i < arrSize; i++)
    {
        cout << arr[i]<<endl;
    }
    int one = INT_MAX;
    int two = INT_MAX;
    for (int i = 0; i < arrSize; i++)
    {
        if (arr[i] < one) {
            one = arr[i];
        }
        else if (arr[i] < two) {
            two = arr[i];
        }
    }cout <<  "Second smallest element in this array is: " << two;
}

int main()
{
    //Write a C++ program to find the second smallest elements in a given array of integers.
    int arr[6] = { 5,7,9,100,11,234 };
    int size = sizeof(arr) / sizeof(arr[0]);
    secondSmallest(arr, size);

}


