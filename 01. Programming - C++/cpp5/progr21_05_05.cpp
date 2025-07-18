// ���������� �� ������������ (C++). 25.10.2021 �.
// ����: progr21_05_05.cpp
#include <iostream>
using namespace std;
int main() {
  system("chcp 1251 > nul");

  // ����� �����������
  double d = 1.111,
         * u1 = & d,
         * * u2 = & u1;
  cout<< * * u2 <<endl;

  // ���������� (���������) �� ������� �����������
  u1 = new double(2.002);
  u2 = new double* (u1);
  cout << **u2 << endl;
  delete u2;
  u2 = NULL;
  // NULL �� ��������� ������ ������ ���� �� ������������;
  // ��-������ ����
  delete u1;
  u1 = NULL;

  // ����� �����������
  u2 = new double* (new double(2.222));
  cout << **u2 << endl;
  delete *u2;
  delete u2;
  u2 = NULL;

  // ���������� (���������) �� ������� �����������
  double const * const uc1 = new const double(3.003);
  const double * const * uc2 = & uc1;
  cout << * * uc2 << endl;
  // ��� � ��-����� �� ���� delete uc1,
  // ������ ���������� �� uc1 �� ���� �� �� �������,
  // � ���� delete uc1 ���������� �� uc1 �� ���� ����������

  // ����� �����������
  uc2 = new double const * const
            (new double const(3.333));
  cout << * * uc2 << endl;
  delete *uc2;
  delete uc2;
  uc2 = NULL;

  //system("pause");
}
