// ���������� �� ������������ (C++). 25.10.2021 �.
// ����: progr21_05_01_demo.cpp
#include <iostream>
using namespace std;int main() {
  system("chcp 1251 > nul");
  int i = 234;
  cout << i << endl;
  int * u = & i;
  cout << * u << endl;
  double * x = new double;
  cout << "�����: ";
  cin >> *x;
  if( x != NULL ) // ���������� �� �������� x, ������ x!=NULL
    cout << *x << endl;
  delete x;
  x = NULL; // NULL ��������� � ���� �, ������ ��������, �� �����������
            // ��������� � ����� 0 ��� � ������ �������� false
  if ( x ) // ���� � ������������ ����� �� �� �������, �� x!=NULL
    cout << *x << endl;
  else
    cout << "NULL" << endl;
  //system("pause");
}
