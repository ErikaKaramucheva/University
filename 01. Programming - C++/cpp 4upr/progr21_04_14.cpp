// Упражнение 4 по Програмиране. 18.10.2021 г.
// Файл: progr21_04_14.cpp
#include <iostream>
using namespace std;
int main() {
  system("chcp 1251 > nul");
  int odd = 2, // първо прочетено нечетно
      numEven = 0, // брой прочетени четни
      next; // последно прочетено
  do {
    cout << "Въведете цяло число: ";
    cin >> next;
    if (next % 2 == 0) ++numEven;
    else if (odd == 2) odd = next;
  } while ( numEven < 5
            && (odd == 2 || next % 2 == 0 || odd == next) );
  cout << "Брой на прочетените четни: " << numEven << endl
       << "Прочетени нечетни: ";
  if (odd == 2) cout << "няма" << endl;
  else {
    cout << odd;
    if (odd != next && next % 2 != 0)
      cout << ", " << next;
    cout << endl;
  }
  //system("pause");
}

