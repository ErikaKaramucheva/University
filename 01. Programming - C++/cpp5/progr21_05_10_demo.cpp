// ���������� �� ������������ (C++). 25.10.2021 �.
// ����: progr21_05_10_demo.cpp
#include <iostream>
using namespace std;
enum T { // ������� ��� T � ��������� ��������� x==0, y==1, z==8
  x, y, z=8
};
int operator+(T t1, T t2) { // �������� + �� ����� �� ��� T
  return 10 * ((int)t1 + t2); // ���� �� ����� �������� ��������
}
bool operator!(T t) { // �������� ! �� ����� �� ��� T
  return t != z; // ������������ z ���� true;
                 // �. �. !t==true ��� t!=z
}
int main() {
  cout << "x = " << x << endl;
  cout << "y = " << y << endl;
  cout << "z = " << z << endl;
  cout << "x+y = " << x + y << endl;
  cout << "x+z = " << x + z << endl;
  cout << "y+z = " << y + z << endl;
  cout << boolalpha;
  cout << "! x = " << !x << endl;
  cout << "! y = " << !y << endl;
  cout << "! z = " << !z << endl;
  //system("pause");
}
