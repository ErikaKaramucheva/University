// Упражнение 4 по Програмиране. 18.10.2021 г.
// Файл: progr21_04_08.cpp
#include <iostream>
using namespace std;
#include <iomanip>
int main() {
  system("chcp 1251 > nul");
  int n;
  do {
    cout << "Брой от 1 до 15: ";
    cin >> n;
  } while (n < 1 || 15 < n);
  for (int k = 1; k <= n; ++k) {
    cout.fill('*');
    cout << setw(k) << '*';
    cout.fill('#');
    cout << setw(n - k + 1) << '#' << endl;
  }
  cout << "\n\n\n";
  //system("pause");
}

