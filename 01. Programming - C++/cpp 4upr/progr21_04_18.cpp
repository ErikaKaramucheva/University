// ���������� 4 �� ������������. 18.10.2021 �.
// ����: progr21_04_18.cpp
#include <iostream>
using namespace std;
int main() {
  system("chcp 1251 > nul");
  string s;
  cout << "�������� ���: ";
  cin >> s;
  for (auto c : s)
    cout << c << "  ";
  cout << endl;
  //system("pause");
}
