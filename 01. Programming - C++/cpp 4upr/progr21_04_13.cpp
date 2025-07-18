// Упражнение 4 по Програмиране. 18.10.2021 г.
// Файл: progr21_04_13.cpp
#include <iostream>
using namespace std;
#include <iomanip>
int main() {
  system("chcp 1251 > nul");
  system("chcp 1251 > nul");
  cout << "  x1  x2  xor  ->  <->\n";
  for (int x1 = 0; x1 < 2; ++x1) {
    for (int x2 = 0; x2 < 2; ++x2)
      cout << setw(3) << x1 << setw(4) << x2 // променливи
           << setw(5) << (x1 ^ x2) // разделително или
           << setw(4) << (x1 && x2 || !x1) // импликация
           << setw(5) << (x1 == x2) // равнозначност
           << endl;
  }  
  //system("pause");
}

