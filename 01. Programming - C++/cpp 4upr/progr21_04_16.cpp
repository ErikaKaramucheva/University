// Упражнение 4 по Програмиране. 18.10.2021 г.
// Файл: progr21_04_16.cpp
#include <iostream>
using namespace std;
int main() {
  system("chcp 1251 > nul");
  long long n;
  do {
    cout << "Положително цяло число: ";
    cin >> n;
  } while (n <= 0);
  cout << "Число с обратен запис: ";
  while (n > 0) {
    cout << n % 10;
    n /= 10;
  }
  //system("pause");
}

