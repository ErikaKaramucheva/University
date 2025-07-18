// Упражнение по Програмиране (C++). 25.10.2021 г.
// Файл: progr21_05_05.cpp
#include <iostream>
using namespace std;
int main() {
  system("chcp 1251 > nul");

  // първа конструкция
  double d = 1.111,
         * u1 = & d,
         * * u2 = & u1;
  cout<< * * u2 <<endl;

  // подготовка (пояснения) за втората конструкция
  u1 = new double(2.002);
  u2 = new double* (u1);
  cout << **u2 << endl;
  delete u2;
  u2 = NULL;
  // NULL се присвоява заради добрия стил на програмиране;
  // по-надолу също
  delete u1;
  u1 = NULL;

  // втора конструкция
  u2 = new double* (new double(2.222));
  cout << **u2 << endl;
  delete *u2;
  delete u2;
  u2 = NULL;

  // подготовка (пояснения) за третата конструкция
  double const * const uc1 = new const double(3.003);
  const double * const * uc2 = & uc1;
  cout << * * uc2 << endl;
  // тук е по-добре да няма delete uc1,
  // защото стойността на uc1 не може да се променя,
  // а след delete uc1 стойността на uc1 би била некоректна

  // трета конструкция
  uc2 = new double const * const
            (new double const(3.333));
  cout << * * uc2 << endl;
  delete *uc2;
  delete uc2;
  uc2 = NULL;

  //system("pause");
}
