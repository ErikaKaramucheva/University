// Упражнение по Програмиране (C++). 25.10.2021 г.
// Файл: progr21_05_09.cpp
#include <iostream>
using namespace std;
#include <ctime>
const int Len = 8;
int main() {
  system("chcp 1251 > nul");
  srand(time(NULL));
  int ar[Len];
  cout << "Масив от числа: ";
  for (int &elm : ar) {
    elm = rand() % 5 - 3;
    cout << elm << "  ";
  }
  cout << endl;

  // 1-и начин (извежда се при ПЪРВО срещане в масива)
  cout << "Различни числа в масива    (по първо срещане): ";
  for (int i = 0; i < Len; ++i) {
    int iFirst = 0;
    while( ar[iFirst] != ar[i] ) ++iFirst;
    if( iFirst == i ) cout << ar[i] << "  ";
  }
  cout << endl;

  // 2-и начин (извежда се при ПОСЛЕДНО срещане в масива)
  // наредбата при извеждане е различна от тази при 1-я начин
  cout << "Различни числа в масива (по последно срещане): ";
  for (int i = 0; i < Len; ++i) {
    int iLast = Len-1;
    while( ar[iLast] != ar[i] ) --iLast;
    if( iLast == i ) cout << ar[i] << "  ";
  }
  cout << endl;

  //system("pause");
}
