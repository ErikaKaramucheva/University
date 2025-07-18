// Упражнение по Програмиране (C++). 25.10.2021 г.
// Файл: progr21_05_08.cpp
#include <iostream>
using namespace std;
#include <ctime>
const int Len = 10;
int main() {
  system("chcp 1251 > nul");
  srand(time(NULL));
  int ar[Len];
  cout << "Всички числа: ";
  for (int &elm : ar) {
    elm = rand() % 8 - 3;
    cout << elm << ' ';
  }
  cout << endl;

  // 1-и начин
  int max = 0;
  for(auto elm : ar) {
    int cnt = 0;
    for (auto n : ar) cnt += n==elm;
    if(max < cnt) max = cnt;
  }
  cout << "Максимален брой генерирания на едно и също число: "
       << max << endl
       << "Толкова пъти са генерирани числата: ";
  for(auto elm : ar) {
    int cnt = 0;
    for (auto n : ar) cnt += n==elm;
    if(max == cnt) cout << elm << ' ';
  }
  cout << endl;

  // 2-и начин
  max = 0;
  int cntAr[Len] // counts[k] е броят генерирания на ar[k]
      = {0}; // това е най-бързият начин за нулиране
             // на всички елементи в масива
  for(int i=0; i<Len; ++i) {
    for (auto n : ar) cntAr[i] += n==ar[i];
    if(max < cntAr[i]) max = cntAr[i];
  }
  cout << "Максимален брой генерирания на едно и също число: "
       << max << endl
       << "Толкова пъти са генерирани числата: ";
  for(int i=0; i<Len; ++i)
    if(max == cntAr[i]) cout << ar[i] << ' ';
  cout << endl;

  //system("pause");
}
