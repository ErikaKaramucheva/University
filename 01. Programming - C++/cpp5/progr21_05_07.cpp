// ���������� �� ������������ (C++). 25.10.2021 �.
// ����: progr21_05_07.cpp
#include <iostream>
using namespace std;
const int k = 5;
int main() {
  system("chcp 1251 > nul");
  int ar[k];
  cout << "�������� " << k << " ����� �����:\n";
  for (int i = 0; i < k; ++i)
    do {
      cout << "  " << i + 1 << "-� �����: ";
      cin >> ar[i];
    } while (ar[i] % 2);
  cout << "�������� ����� � ������� ���:\n  ";
  for (int i = k - 1; i >= 0; --i) cout << ar[i] << ' ';
  cout << endl;
  //system("pause");
}
