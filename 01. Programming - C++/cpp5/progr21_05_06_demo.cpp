// Упражнение по Програмиране (C++). 25.10.2021 г.
// Файл: progr21_05_06_demo.cpp
#include <iostream>
using namespace std;
int ar1[10]; // в глобалното пространство се инициализират с нули
int main() {
  system("chcp 1251 > nul");
  for (int elm : ar1) cout << elm << " ";
  cout << endl;

  int ar2[4]; // не се инициализира по подразбиране
  for (int elm : ar2) cout << elm << " ";
  cout << endl;

  int ar3[6] = { 1, 2, 3, 4, 5, 6 };
  int ar4[6] = { 11, 22 }; // следващите елементи се нулират
  for (int elm : ar3) cout << elm << " ";
  cout << endl;
  for (int elm : ar4) cout << elm << " ";
  cout << endl;

  int ar5[] = { 10, 20, 30, 40, 50 }; // безразмерен масив
  for (int elm : ar4) cout << elm << " ";
  cout << endl;

  decltype(ar5) ar6 = {1, 2, 3};
  for (int elm : ar6) cout << elm << " ";
  cout << endl << "----------------\n";

  for (auto elm : ar6) ++elm; // масивът остава същия
  for (int elm : ar6) cout << elm << " ";
  cout << endl;

  for (auto & elm : ar6) ++elm; // променя масива
  for (int elm : ar6) cout << elm << " ";
  cout << endl << "----------------\n";

  const int Len6 = sizeof(ar6) / sizeof(ar6[0]); // дължина на ar6
  // sezeof(ar6) дава броя на байтовете, заети от целия масив
  // sezeof(ar6[0]) дава броя на байтовете, заети от елемента
  for (int i = 0; i < Len6; ++i) cout << ar6[i] << " ";
  cout << endl;
  //system("pause");
}
