// ���������� 4 �� ������������. 18.10.2021 �.
// ����: progr21_04_17.cpp
#include <iostream>
using namespace std;
int main() {
  system("chcp 1251 > nul");
  char Last = ' ', pred; // ' ' �� ���� �� �� ������� ��� cin>>
  int num = 0;
  cout << "���������� ������� �� ��� ������� �����:\n";
  do {
    pred = Last;
    cin >> Last;
    ++num;
  } while (pred != Last);
  cout << "���� �� ����������� �������: " << num << endl;
  //system("pause");
}
