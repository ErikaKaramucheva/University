// ���������� 4 �� ������������. 18.10.2021 �.
// ����: progr21_04_16.cpp
#include <iostream>
using namespace std;
int main() {
  system("chcp 1251 > nul");
  long long n;
  do {
    cout << "����������� ���� �����: ";
    cin >> n;
  } while (n <= 0);
  cout << "����� � ������� �����: ";
  while (n > 0) {
    cout << n % 10;
    n /= 10;
  }
  //system("pause");
}

