#include <iostream>
using namespace std;
#include<string>
#include<cstring>

int main()
{
    char str1[10] = "Hello";
    char str2[10] = "World";
    char str3[10];


    // copy str1 into str3
    strcpy_s(str3, str1);
    cout << "strcpy( str3, str1) : " << str3<< endl;

    // concatenates str1 and str2
    //strcat(str1, str2);
    //cout << "strcat( str1, str2): " << str1 << endl;

    // total lenghth of str1 after concatenation
    int len = strlen(str1);
    cout << "strlen(str1) : " << len << endl;

    //Returns 0 if s1 and s2 are the same; less than 0 if s1<s2; greater than 0 if s1>s2.
    //cout << "strcmp(str1, str2): " << strcmp(str1, str2);

    strchr(str1, 2);
    cout << "strchr(str1,2): " << strchr(str1, 2);
    //Returns a pointer to the first occurrence of character ch in string s1.

    //strstr(s1, s2);
    //Returns a pointer to the first occurrence of string s2 in string s1.
}

