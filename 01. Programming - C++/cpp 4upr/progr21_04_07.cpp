// ���������� 4 �� ������������. 18.10.2021 �.
// ����: progr21_04_07.cpp
#include <iostream>
using namespace std;
int main() {
  system("chcp 1251 > nul");
  int n;
  do {
    cout << "������ �� 1 �� 11000: ";
    cin >> n;
  } while (n < 1 || 11000 < n);
  int R = 4; // 1-� �������
  for (int k = 2; k <= n; ++k)
    // �� �� �������� Rk
    if (k < 5) R = k * (k + 3);
    else if (k % 3 != 0) R += k - 11;
    else R -= 6;
  cout << "R(" << n << ") = " << R << "\n\n";
  //system("pause");
}

