// ���������� 4 �� ������������. 18.10.2021 �.
// ����: progr21_04_14.cpp
#include <iostream>
using namespace std;
int main() {
  system("chcp 1251 > nul");
  int odd = 2, // ����� ��������� �������
      numEven = 0, // ���� ��������� �����
      next; // �������� ���������
  do {
    cout << "�������� ���� �����: ";
    cin >> next;
    if (next % 2 == 0) ++numEven;
    else if (odd == 2) odd = next;
  } while ( numEven < 5
            && (odd == 2 || next % 2 == 0 || odd == next) );
  cout << "���� �� ����������� �����: " << numEven << endl
       << "��������� �������: ";
  if (odd == 2) cout << "����" << endl;
  else {
    cout << odd;
    if (odd != next && next % 2 != 0)
      cout << ", " << next;
    cout << endl;
  }
  //system("pause");
}

