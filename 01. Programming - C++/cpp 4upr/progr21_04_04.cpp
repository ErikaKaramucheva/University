// ���������� 4 �� ������������. 18.10.2021 �.
// ����: progr21_04_04.cpp
#include <iostream>
using namespace std;
int main() {
  system("chcp 1251 > nul");
  int n;
  cout << "�������� ����� �� ��� �� 1 �� 7: ";
  cin >> n;
  switch (n) {
    case 1:
      cout << "���������� 16:0-18:0;\n��������� 17:0-19:0\n";
      break;
    case 2:
      cout << "������ 16:0-17:30\n";
      break;
    case 3:
      cout << "����� 17:0-18:0\n";
      break;
    case 4:
      cout << "��������� 17:0-19:0\n";
      break;
    case 5:
      cout << "���������� 16:0-18:0;\n������ 16:0-17:30\n";
      break;
    case 6:
      cout << "����� 17:0-18:0\n";
      break;
    case 7:
      cout << "���� �������\n";
      break;
    default:
      cout << "���������� �����\n";
  }
  //system("pause");
}

