// ���������� 4 �� ������������. 18.10.2021 �.
// ����: progr21_04_15.cpp
#include <iostream>
using namespace std;
int main() {
  system("chcp 1251 > nul");
  int x, y;
  do {
    cout << "��e ���� �����, �������� �� ����: ";
    cin >> x >> y;
  } while (x == 0 || !y);
  if (x < 0) x = -x;
  if (y < 0) y = -y;
  int d = x % y;
  while (d) {
    x = y;
    y = d;
    d = x % y;
  }
  cout << "���: " << y << endl;
  //system("pause");
}

