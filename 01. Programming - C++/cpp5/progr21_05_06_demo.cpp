// ���������� �� ������������ (C++). 25.10.2021 �.
// ����: progr21_05_06_demo.cpp
#include <iostream>
using namespace std;
int ar1[10]; // � ���������� ������������ �� ������������� � ����
int main() {
  system("chcp 1251 > nul");
  for (int elm : ar1) cout << elm << " ";
  cout << endl;

  int ar2[4]; // �� �� ������������ �� ������������
  for (int elm : ar2) cout << elm << " ";
  cout << endl;

  int ar3[6] = { 1, 2, 3, 4, 5, 6 };
  int ar4[6] = { 11, 22 }; // ���������� �������� �� �������
  for (int elm : ar3) cout << elm << " ";
  cout << endl;
  for (int elm : ar4) cout << elm << " ";
  cout << endl;

  int ar5[] = { 10, 20, 30, 40, 50 }; // ����������� �����
  for (int elm : ar4) cout << elm << " ";
  cout << endl;

  decltype(ar5) ar6 = {1, 2, 3};
  for (int elm : ar6) cout << elm << " ";
  cout << endl << "----------------\n";

  for (auto elm : ar6) ++elm; // ������� ������ �����
  for (int elm : ar6) cout << elm << " ";
  cout << endl;

  for (auto & elm : ar6) ++elm; // ������� ������
  for (int elm : ar6) cout << elm << " ";
  cout << endl << "----------------\n";

  const int Len6 = sizeof(ar6) / sizeof(ar6[0]); // ������� �� ar6
  // sezeof(ar6) ���� ���� �� ���������, ����� �� ����� �����
  // sezeof(ar6[0]) ���� ���� �� ���������, ����� �� ��������
  for (int i = 0; i < Len6; ++i) cout << ar6[i] << " ";
  cout << endl;
  //system("pause");
}
