#include <iostream>
using namespace std;

struct Cat
{
    bool gender= true;
    int age=2;
    double weight = 4.5;
    string name= "Lily";
    char child= '2';
};

int main()
{
    Cat cat;
    cat.gender = false;
    cat.name = "Viktor";
    cat.age = 3;
    cat.weight = 5.3;
    cat.child = '1';
    string input;
    cout << "Enter gender:";
    cin >> input;
    if (input=="???")
    {
        cout << "Cat gender is: male" << endl << "Name:" << cat.name << endl
            << "Age: " << cat.age << endl << "Weight: " << cat.weight << "kg.\n" << "Children: " << cat.child << endl;
    }
    else {
        cout << "Cat gender is:female" << endl << "Cat's name is:" << cat.name << endl
            << "Age: " << cat.age << endl << "Weight: " << cat.weight << "kg.\n" << "Children: " << cat.child << endl;
    }

}
