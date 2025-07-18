// Упражнение по Програмиране (C++). 25.10.2021 г.
// Файл: progr21_05_02_demo.cpp
#include <iostream>
using namespace std;int main() {
  system("chcp 1251 > nul");
  int i = 123, j=88888;
  int & ref = i;
  cout << i << endl;
  cout << ref << endl;
  i = -5;
  cout << i << endl;
  cout << ref << endl;
  ref = j;
  // тук ref продължава да бъде ново име на i
  cout << i << endl;
  cout << ref << endl;
  //system("pause");
}
