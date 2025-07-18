// ���������� �� ������������ (C++). 25.10.2021 �.
// ����: progr21_05_09.cpp
#include <iostream>
using namespace std;
#include <ctime>
const int Len = 8;
int main() {
  system("chcp 1251 > nul");
  srand(time(NULL));
  int ar[Len];
  cout << "����� �� �����: ";
  for (int &elm : ar) {
    elm = rand() % 5 - 3;
    cout << elm << "  ";
  }
  cout << endl;

  // 1-� ����� (������� �� ��� ����� ������� � ������)
  cout << "�������� ����� � ������    (�� ����� �������): ";
  for (int i = 0; i < Len; ++i) {
    int iFirst = 0;
    while( ar[iFirst] != ar[i] ) ++iFirst;
    if( iFirst == i ) cout << ar[i] << "  ";
  }
  cout << endl;

  // 2-� ����� (������� �� ��� �������� ������� � ������)
  // ��������� ��� ��������� � �������� �� ���� ��� 1-� �����
  cout << "�������� ����� � ������ (�� �������� �������): ";
  for (int i = 0; i < Len; ++i) {
    int iLast = Len-1;
    while( ar[iLast] != ar[i] ) --iLast;
    if( iLast == i ) cout << ar[i] << "  ";
  }
  cout << endl;

  //system("pause");
}
