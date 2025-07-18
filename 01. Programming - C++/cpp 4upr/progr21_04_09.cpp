// Упражнение 4 по Програмиране. 18.10.2021 г.
// Файл: progr21_04_09.cpp
#include <iostream>
using namespace std;
#include <iomanip>
int main() {
  system("chcp 1251 > nul");
  int k, n;
  do {
    cout << "Въведете цяло число k от 0 до 3: ";
    cin >> k;
  } while (k < 0 || 3 < k);
  do {
    cout << "Въведете цяло число n от " << k + 1 << " до 9: ";
    cin >> n;
  } while (n <= k || 9 < n);
  for (int f1 = 1, f2 = k + 1, f3 = n + 1;
       f3 > 0;
       f2 == 1 ? --f3 : (++f1, --f2, --f3)
      )
    cout << setw(f1) << '='
         << setw(f2) << '*'
         << setw(f3) << '&' << endl;
  cout << "\n\n";
  //system("pause");
}

