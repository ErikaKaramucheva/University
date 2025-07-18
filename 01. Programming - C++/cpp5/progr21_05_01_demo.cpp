// Упражнение по Програмиране (C++). 25.10.2021 г.
// Файл: progr21_05_01_demo.cpp
#include <iostream>
using namespace std;int main() {
  system("chcp 1251 > nul");
  int i = 234;
  cout << i << endl;
  int * u = & i;
  cout << * u << endl;
  double * x = new double;
  cout << "Число: ";
  cin >> *x;
  if( x != NULL ) // обикновено се използва x, вместо x!=NULL
    cout << *x << endl;
  delete x;
  x = NULL; // NULL физически е нула и, когато потрябва, се преобразува
            // съответно в число 0 или в булева стойност false
  if ( x ) // това е естественият начин да се провери, че x!=NULL
    cout << *x << endl;
  else
    cout << "NULL" << endl;
  //system("pause");
}
