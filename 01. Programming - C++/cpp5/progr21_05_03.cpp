// ���������� �� ������������ (C++). 25.10.2021 �.
// ����: progr21_05_03.cpp
#include <iostream>
using namespace std;int main() {
  system("chcp 1251 > nul");
  double x, y, z;
  cout << "�������� ��� �����: ";
  cin >> x >> y >> z;
  double * uMin, * uMax;
  if (x < y) { uMin = &x; uMax = &y; }
  else { uMin = &y; uMax = &x; }
  if (*uMin > z) uMin = &z;
  if (*uMax < z) uMax = &z;
  cout << "��������� ��������: [ " << *uMin
       << " ; " << *uMax << " ]\n";
  double & refMin = *uMin,
         & refMax = *uMax;
  cout << "��������� ��������: [ " << refMin
       << " ; " << refMax << " ]\n";
  //system("pause");
}
