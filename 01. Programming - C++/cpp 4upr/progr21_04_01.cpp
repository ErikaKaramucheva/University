// ���������� 4 �� ������������. 18.10.2021 �.
// ����: progr21_04_01.cpp
#include <iostream>
using namespace std;
int main() {
  system("chcp 1251 > nul");
  double n1, n2, n3, buf;
  cout << "�������� ��� �����: ";
  cin >> n1 >> n2 >> n3;
  if (n2 < n1) { buf = n1; n1 = n2; n2 = buf; }
  if (n3 < n1) { buf = n1; n1 = n3; n3 = buf; }
  if (n3 < n2) { buf = n2; n2 = n3; n3 = buf; }
  cout << n1 << " <= " << n2 << " <= " << n3 << endl;
  //system("pause");
}