// Упражнение по Програмиране (C++). 25.10.2021 г.
// Файл: progr21_05_04.cpp
#include <iostream>
using namespace std;
int main() {
  system("chcp 1251 > nul");
  double x, y;
  cout << "Въведет две числа: ";
  cin >> x >> y;
  for(int i=1; i<=2; ++i) {
    double * u;
    if (1 == i) u = x < y ? &x : &y;
    else u = x < y ? &y : &x;
    double & ref = *u;
    cout << ref << " ";
  }
  cout << endl;
  //system("pause");
}
