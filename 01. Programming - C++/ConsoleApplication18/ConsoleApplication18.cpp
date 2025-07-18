#include <iostream>
using namespace std;
#include<string>

struct Rabotnik
{
    int id[7];
    char gender;
    string name;
    int ages;
};

char gender(int arr[], int arrSize, struct Rabotnik) {
    int num = 3;
    Rabotnik rabotnik;
    for (int i = 0; i < arrSize; i++)
    {
        if (arr[i] == num) {
            rabotnik.gender = 'm';
        }
    }return rabotnik.gender;
}

int main()
{
    Rabotnik rabotnikInfo;
    cout << "Name: ";
    getline(cin, rabotnikInfo.name);
    cout << "Age: ";
    cin >> rabotnikInfo.ages;
    int x;
    cout << "Array length: ";
    cin >> x;
    if (x < 1 || x > 7) {
        cout << "Array length:";
        cin >> x;
    }
    for (int i = 0; i < x; i++)
    {
            cout << "Number:";
            cin >> rabotnikInfo.id[i];
    }  
    char pol=gender(rabotnikInfo.id,x,rabotnikInfo);
    if (pol == 'm') {
        cout << "Welcome Mr. " << rabotnikInfo.name << ", your age is " << rabotnikInfo.ages<<".";
    }
    else {
        cout << "Welcome Mrs. " << rabotnikInfo.name << ", your age is " << rabotnikInfo.ages<<".";
    }

}

