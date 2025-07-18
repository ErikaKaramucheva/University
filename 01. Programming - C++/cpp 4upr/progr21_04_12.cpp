// Упражнение 4 по Програмиране. 18.10.2021 г.
// Файл: progr21_04_12.cpp
#include <iostream>
using namespace std;
#include <iomanip>
int main() {
  system("chcp 1251 > nul");
  long long next, sum = 0;
  int num = 0;
  do {
    cout << "Въведете цяло число: ";
    cin >> next;
    ++num;
    sum += next;
  } while (sum >= 0);
  cout << "Средно аритмтично: " << sum / (double) (num) << endl;
//system("pause");
}

