// Упражнение по Програмиране (C++). 25.10.2021 г.
// Файл: progr21_05_10_demo.cpp
#include <iostream>
using namespace std;
enum T { // изброим тип T с именувани константи x==0, y==1, z==8
  x, y, z=8
};
int operator+(T t1, T t2) { // оператор + за данни от тип T
  return 10 * ((int)t1 + t2); // може да връща всякаква стойност
}
bool operator!(T t) { // оператор ! за данни от тип T
  return t != z; // интерпретира z като true;
                 // т. е. !t==true при t!=z
}
int main() {
  cout << "x = " << x << endl;
  cout << "y = " << y << endl;
  cout << "z = " << z << endl;
  cout << "x+y = " << x + y << endl;
  cout << "x+z = " << x + z << endl;
  cout << "y+z = " << y + z << endl;
  cout << boolalpha;
  cout << "! x = " << !x << endl;
  cout << "! y = " << !y << endl;
  cout << "! z = " << !z << endl;
  //system("pause");
}
