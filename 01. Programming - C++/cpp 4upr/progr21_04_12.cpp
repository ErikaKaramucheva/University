// ���������� 4 �� ������������. 18.10.2021 �.
// ����: progr21_04_12.cpp
#include <iostream>
using namespace std;
#include <iomanip>
int main() {
  system("chcp 1251 > nul");
  long long next, sum = 0;
  int num = 0;
  do {
    cout << "�������� ���� �����: ";
    cin >> next;
    ++num;
    sum += next;
  } while (sum >= 0);
  cout << "������ ����������: " << sum / (double) (num) << endl;
//system("pause");
}

