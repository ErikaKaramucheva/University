// ���������� 4 �� ������������. 18.10.2021 �.
// ����: progr21_04_09.cpp
#include <iostream>
using namespace std;
#include <iomanip>
int main() {
  system("chcp 1251 > nul");
  int k, n;
  do {
    cout << "�������� ���� ����� k �� 0 �� 3: ";
    cin >> k;
  } while (k < 0 || 3 < k);
  do {
    cout << "�������� ���� ����� n �� " << k + 1 << " �� 9: ";
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

