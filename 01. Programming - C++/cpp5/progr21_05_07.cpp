// Упражнение по Програмиране (C++). 25.10.2021 г.
// Файл: progr21_05_07.cpp
#include <iostream>
using namespace std;
const int k = 5;
int main() {
  system("chcp 1251 > nul");
  int ar[k];
  cout << "Въведете " << k << " четни числа:\n";
  for (int i = 0; i < k; ++i)
    do {
      cout << "  " << i + 1 << "-о число: ";
      cin >> ar[i];
    } while (ar[i] % 2);
  cout << "Въведени числа в обратен ред:\n  ";
  for (int i = k - 1; i >= 0; --i) cout << ar[i] << ' ';
  cout << endl;
  //system("pause");
}
