// ���������� �� ������������ (C++). 25.10.2021 �.
// ����: progr21_05_08.cpp
#include <iostream>
using namespace std;
#include <ctime>
const int Len = 10;
int main() {
  system("chcp 1251 > nul");
  srand(time(NULL));
  int ar[Len];
  cout << "������ �����: ";
  for (int &elm : ar) {
    elm = rand() % 8 - 3;
    cout << elm << ' ';
  }
  cout << endl;

  // 1-� �����
  int max = 0;
  for(auto elm : ar) {
    int cnt = 0;
    for (auto n : ar) cnt += n==elm;
    if(max < cnt) max = cnt;
  }
  cout << "���������� ���� ����������� �� ���� � ���� �����: "
       << max << endl
       << "������� ���� �� ���������� �������: ";
  for(auto elm : ar) {
    int cnt = 0;
    for (auto n : ar) cnt += n==elm;
    if(max == cnt) cout << elm << ' ';
  }
  cout << endl;

  // 2-� �����
  max = 0;
  int cntAr[Len] // counts[k] � ����� ����������� �� ar[k]
      = {0}; // ���� � ���-������� ����� �� ��������
             // �� ������ �������� � ������
  for(int i=0; i<Len; ++i) {
    for (auto n : ar) cntAr[i] += n==ar[i];
    if(max < cntAr[i]) max = cntAr[i];
  }
  cout << "���������� ���� ����������� �� ���� � ���� �����: "
       << max << endl
       << "������� ���� �� ���������� �������: ";
  for(int i=0; i<Len; ++i)
    if(max == cntAr[i]) cout << ar[i] << ' ';
  cout << endl;

  //system("pause");
}
