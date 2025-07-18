#include <iostream>
using namespace std;
static int arr[10];
//1) Напишете програма, която пресмята N! 
int factorial(int n) {
	_asm {
		mov eax,1
		mov ecx,1
		for:
		cmp ecx,n
			jg skip
			mul ecx
			inc ecx
			jmp for
			skip:
	}
}
//2) Напишете програма, която извежда 10 числа със стъпка 2 във вида : 2, 4, 6, 8, 10, 12, 14, 16, 18, 20
void step(int n) {
	_asm {
		mov eax,n
		mov ecx,0
		for:
		cmp ecx,10
			jge skip
			mov [arr+4*ecx],eax
			add eax,n
			inc ecx
			jmp for
			skip:
	}
	for (int i = 0; i < 10; i++) {
		cout << arr[i] << endl;
	}
}
//3) Напишете програма, която 
//отпечатва квадратите на масив с 10 числа.
void quadrat() {
	_asm {
		mov ecx,0
		for:
		cmp ecx,10
			jge skip
			mov eax,[arr+4*ecx]
			mul eax
			mov [arr+4*ecx],eax
			inc ecx
			jmp for
			skip:
	}
	for (int i = 0; i < 10; i++) {
		cout << arr[i] << endl;
	}
}
//4) Напишете програма, която отпечатва 
//първите N члена от редицата на Фибоначи
void fibonacci(int n) {
	_asm {
		mov ecx,0
		mov [arr+4*ecx],1
		mov [arr+4+4*ecx],1
		for:
		cmp ecx,n
			jg skip
			mov eax,[arr+4*ecx]
			mov ebx,[arr+4+4*ecx]
			add eax,ebx
			mov [arr+8+4*ecx],eax
			inc ecx
			jmp for

			skip:
	}
	for (int i = 0; i < 10; i++) {
		cout << arr[i] << endl;
	}
}
/*5) Напишете програма, която сумира
първите
N члена от редицата на Фибоначи
*/
int sum()

int main()
{
	//cout << factorial(5)<<endl;
	//step(2);
	//quadrat();
	fibonacci(10);
}
