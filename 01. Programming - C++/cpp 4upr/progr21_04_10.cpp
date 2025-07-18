// Упражнение 4 по Програмиране. 18.10.2021 г.
// Файл: progr21_04_10.cpp
#include <iostream>
using namespace std;
#include <iomanip>
int main() {
  system("chcp 1251 > nul");
  for (int x = 2, n = 30; x < n; ++x)
    if (x % 2 - 1) continue;
    else for (int y = x; y < n; y += 2)
           if (y % 3 == 0) break;
           else cout << y << " ";
  cout << "\n";
  //system("pause");
}

