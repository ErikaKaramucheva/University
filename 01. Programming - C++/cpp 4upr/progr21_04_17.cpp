// Упражнение 4 по Програмиране. 18.10.2021 г.
// Файл: progr21_04_17.cpp
#include <iostream>
using namespace std;
int main() {
  system("chcp 1251 > nul");
  char Last = ' ', pred; // ' ' не може да се прочете със cin>>
  int num = 0;
  cout << "Въвеждайте знакове до два поредни равни:\n";
  do {
    pred = Last;
    cin >> Last;
    ++num;
  } while (pred != Last);
  cout << "Брой на прочетените знакове: " << num << endl;
  //system("pause");
}
