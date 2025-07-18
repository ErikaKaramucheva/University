// Упражнение 4 по Програмиране. 18.10.2021 г.
// Файл: progr21_04_04.cpp
#include <iostream>
using namespace std;
int main() {
  system("chcp 1251 > nul");
  int n;
  cout << "Въведете номер на ден от 1 до 7: ";
  cin >> n;
  switch (n) {
    case 1:
      cout << "математика 16:0-18:0;\nанглийски 17:0-19:0\n";
      break;
    case 2:
      cout << "физика 16:0-17:30\n";
      break;
    case 3:
      cout << "химия 17:0-18:0\n";
      break;
    case 4:
      cout << "английски 17:0-19:0\n";
      break;
    case 5:
      cout << "математика 16:0-18:0;\nфизика 16:0-17:30\n";
      break;
    case 6:
      cout << "химия 17:0-18:0\n";
      break;
    case 7:
      cout << "няма занятия\n";
      break;
    default:
      cout << "неправилен номер\n";
  }
  //system("pause");
}

