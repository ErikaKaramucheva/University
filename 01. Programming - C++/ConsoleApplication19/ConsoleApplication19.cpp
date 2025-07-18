#include <iostream>
using namespace std;
#include <cmath>


int main()
{
    //Write a C++ program to find the largest element of a given array of integers.
    int arr[1000];
    int n;
    cin >> n;
    int max = INT_MIN;
    for (int i = 0; i < n; i++)
    {
        cin >> arr[i];
        if (arr[i] > max) {
            max = arr[i];
        }
    } cout <<endl<< max;
     

}

   

