// ���������� 4 �� ������������. 18.10.2021 �.
// ����: progr21_04_08.cpp
#include <iostream>
using namespace std;
#include <iomanip>
int main() {
  system("chcp 1251 > nul");
  int n;
  do {
    cout << "���� �� 1 �� 15: ";
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

