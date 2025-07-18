// Упражнение 4 по Програмиране. 18.10.2021 г.
// Файл: progr21_04_05.cpp
#include <iostream>
using namespace std;
int main() {
  system("chcp 1251 > nul");
  double x;
  do {
    cout << "Въведете положително число: ";
    cin >> x;
  } while (x <= 0);
  double Last = 1.0, pred;
  do {
    pred = Last;
    Last = 0.5 * (pred + x / pred);
  } while (Last != pred);
  cout.precision(17);
  cout << "Граница: " << Last << endl;
  //system("pause");
}

