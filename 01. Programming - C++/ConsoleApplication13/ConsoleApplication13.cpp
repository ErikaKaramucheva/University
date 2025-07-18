#include <iostream>
using namespace std;
#include<string>

struct person1
{
    string firstName="Ivan";
    string lastName = "Ivanov";
    int age = 19;

};
struct person2
{
    string firstName = "Maria";
    string lastName = "Petrova";
    int age = 23;

};
int main()
{
    person1 p1;
    person2 p2;
    string firstName;
    cin >> firstName;
    if (firstName == "Ivan") {
        cout<< p1.firstName<<endl<<p1.lastName<<endl<<p1.age << endl;
    }
    else if (firstName == "Maria") {
        cout<< p2.firstName<<endl<<p2.lastName<<endl<<p2.age << endl;
    }
    else {
        cout << "Not found";
    }
}

