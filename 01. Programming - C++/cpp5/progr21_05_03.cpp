// Упражнение по Програмиране (C++). 25.10.2021 г.
// Файл: progr21_05_03.cpp
#include <iostream>
using namespace std;int main() {
  system("chcp 1251 > nul");
  double x, y, z;
  cout << "Въведете три числа: ";
  cin >> x >> y >> z;
  double * uMin, * uMax;
  if (x < y) { uMin = &x; uMax = &y; }
  else { uMin = &y; uMax = &x; }
  if (*uMin > z) uMin = &z;
  if (*uMax < z) uMax = &z;
  cout << "Минимален интервал: [ " << *uMin
       << " ; " << *uMax << " ]\n";
  double & refMin = *uMin,
         & refMax = *uMax;
  cout << "Минимален интервал: [ " << refMin
       << " ; " << refMax << " ]\n";
  //system("pause");
}
