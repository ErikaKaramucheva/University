// Упражнение 4 по Програмиране. 18.10.2021 г.
// Файл: progr21_04_06.cpp
#include <iostream>
using namespace std;
#include <ctime>
int main() {
  system("chcp 1251 > nul");
  srand(time(NULL));
  int odd = 0;
  while (odd < 3) {
    int next = rand() % 16 - 5;
    cout << next << "  ";
    //if (next % 2 != 0) ++odd;
    odd += next % 2 != 0; // odd = odd + (next % 2 != 0)
  }
  cout << "\n\n\n";
  //system("pause");
}

