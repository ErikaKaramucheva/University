// ���������� 4 �� ������������. 18.10.2021 �.
// ����: progr21_04_03.cpp
#include <iostream>
using namespace std;
int main() {
  system("chcp 1251 > nul");
  int m, y;
  cout << "�������� ����� �� ����� � ������: ";
  cin >> m >> y;
  cout << "���� �� ����� � ��������: "
       << 365 + (y%4==0 && y%100!=0 || y%400==0)
       << endl;
  cout << "���� �� ����� � ��������: ";
  if (y%4==0 && y%100!=0 || y%400==0)
    cout << 366 << endl;
  else
    cout << 365 << endl;
  cout << "���� �� ����� � ������: "
       << (m==2 ? 28 + (y%4==0 && y%100!=0 || y%400==0)
                : 31 - (m==4 || m==6 || m==9 || m==11))
       <<endl;
  cout << "���� �� ����� � ������: ";
  if(m == 2)
    cout << 28 + (y%4 == 0 && y%100 != 0 || y%400 == 0);
  else
    cout << 31 - (m==4 || m==6 || m==9 || m==11);
  cout << endl;
  cout << "���� �� ����� � ������: ";
  switch (m)
  {
    default:
      cout << 31;
      break;
    case 2:
      cout << 28+ (y%4==0 && y%100!=0 || y%400==0);
      break;
    case 4: case 6: case 9: case 11:
      cout << 30;
  }
  cout << endl;
  //system("pause");
}
